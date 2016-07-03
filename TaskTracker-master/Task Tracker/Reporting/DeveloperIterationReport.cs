using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.DAO;

namespace Task_Tracker.Reporting
{
    class DeveloperIterationReport : PrintDocument
    {
        private Developer developer;
        private Iteration iteration;

        // The format to use for dates.
        private string dateFormat = "{0:dd/MM/yyyy}";

        private Graphics graphics;

        // The maximum height and width of the page
        private double maxHeight;
        private double maxWidth;

        // The starting point of horizontal lines
        private int lineStart;
        // The ending point of horizontal line
        private int lineEnd;
        // After printing horizontal line use this value as offset before next row
        private int lineOffset = 20;

        // The size of the checkbox's width and length
        private int checkboxSize = 15;
        
        // Fonts for paragraph, bold paragraph and header.
        private Font paragraphFont = new Font("Verdana", 10);
        private Font paragraphBoldFont = new Font("Verdana", 10, FontStyle.Bold);
        private Font headerFont = new Font("Verdana", 14, FontStyle.Bold);

        // The vertical gap to allow for paragraph
        private int paragraphFontOffSet = 20;
        // The horizontal gap between the header and the text when printed on one line
        private int horizontalSpaceAfterHeader = 5;

        // The spaces to add after a paragraph
        private int paragraphTrailingSpace = 5;

        // The spaces to add after a report header
        private int reportHeaderTrailingSpace = 20;

        // Create a pen to use for horizontal line separator
        private Pen horizontalLinePen = new Pen(Color.Black, 2);

        // Create pen for drawing checkbox
        private Pen checkboxPen = new Pen(Color.Black, 1);
        // Gap between header and checkbox
        private int checkboxGap = 5;
        
        // Store current x and y positions
        private int xPos;
        private int yPos;

        public DeveloperIterationReport(Developer developer, Iteration iteration)
        {
            this.developer = developer;
            this.iteration = iteration;
        }

        protected override void OnPrintPage(PrintPageEventArgs eventArgs)
        {
            // Run base code
            base.OnPrintPage(eventArgs);

            InitialisePrinting(eventArgs);

            // Print the Report header at the top of the page.
            PrintReportHeader();

            // Add project name
            PrintParagraphWithHeader("Project: ", iteration.Project.ProjectName);

            // Add iteration start date
            PrintParagraphWithHeader("Iteration Start Date: ", String.Format(dateFormat, iteration.StartDate));
            
            // Add Iteration end date
            PrintParagraphWithHeader("Iteration End Date: ", String.Format(dateFormat, iteration.EndDate));

            // Add some extra spacing
            yPos += paragraphFontOffSet;
            
            // Draw line before displaying each of the tasks.
            DrawHorizontalLine();

            // Display all the tasks for developer and iteration
            PrintDeveloperTasks();

        }

        private void InitialisePrinting(PrintPageEventArgs eventArgs)
        {
            graphics = eventArgs.Graphics;

            // Calculate the margins.
            int marginLeft = eventArgs.PageSettings.Margins.Left;
            int marginRight = eventArgs.PageSettings.Margins.Right;
            int marginTop = eventArgs.PageSettings.Margins.Top;
            int marginBottom = eventArgs.PageSettings.Margins.Bottom;

            // Calculate usable height and width
            maxHeight = eventArgs.PageSettings.PrintableArea.Height - marginTop - marginBottom;
            maxWidth = eventArgs.PageSettings.PrintableArea.Width - marginLeft - marginRight;

            // Set where horizontal lines will start and end
            lineStart = marginLeft;
            lineEnd = marginLeft + (int)maxWidth;

            // Initialise the x and y positions
            xPos = marginLeft;
            yPos = marginTop;

        }

        private void PrintReportHeader()
        {
            // Add report header, centred
            string reportHeader = "Iteration Report for " + developer;

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            Print(reportHeader, headerFont, reportHeaderTrailingSpace, format);
        }

        private void PrintParagraphWithHeader(string header, string text)
        {
            // Print header in bold and text in regular font.
            Print(header, paragraphBoldFont, text, paragraphFont, paragraphTrailingSpace);
        }

        private void PrintParagraphWithHeaderAndCheckbox(string header)
        {
            // Print a paragraph with a header and a checkbox.

            SizeF headerSize = graphics.MeasureString(header, paragraphBoldFont);
            graphics.DrawString(header, paragraphBoldFont, Brushes.Black, xPos, yPos);

            // Draw the checkbox, it's actually a square
            Rectangle completedRectangle = new Rectangle(xPos + (int)headerSize.Width + checkboxGap, yPos, checkboxSize, checkboxSize);
            graphics.DrawRectangle(checkboxPen, completedRectangle);

            // Increment y position
            yPos += paragraphFontOffSet;
        }

        private void PrintParagraphHeader(string header)
        {
            // Print a paragraph using bold font
            Print(header, paragraphBoldFont, paragraphTrailingSpace);
        }


        private void PrintParagraph(string text)
        {
            // Print paragraph using paragraphFont
            Print(text, paragraphFont, paragraphTrailingSpace);
        }

        private void Print(string text, Font font, int trailingSpace)
        {
            Print(text, font, trailingSpace, GetDefaultStringFormat());
        }

        private void Print(string text, Font font, int trailingSpace, StringFormat format) {
            // Print the text
            RectangleF paragraphRectangle = new RectangleF();
            paragraphRectangle.Location = new Point(xPos, yPos);

            SizeF textSize = graphics.MeasureString(text, font, (int)maxWidth, format);
            paragraphRectangle.Size = new Size((int)maxWidth, (int)textSize.Height);
            graphics.DrawString(text, font, Brushes.Black, paragraphRectangle, format);

            yPos += (int)textSize.Height + trailingSpace;
        }

        private void Print(string header, Font headerFont, string text, Font textFont, int trailingSpace)
        {
            Print(header, headerFont, text, textFont, trailingSpace, GetDefaultStringFormat());
        }

        private void Print(string header, Font headerFont, string text, Font textFont, int trailingSpace, StringFormat format)
        {
            // Print header in one font, and text directly after it in another font.
            // If header expands more than 50% of the line then text is put on next line.
            // If header is under 50% of the line the text continues on header line, but any 
            // text is wrapped where text begins, effectively indenting the text.

            // Print header
            RectangleF headerRectangle = new RectangleF();
            headerRectangle.Location = new Point(xPos, yPos);

            SizeF headerSize = graphics.MeasureString(header, headerFont, (int)maxWidth, format);
            int width = (int)headerSize.Width;
            if (width > (int)maxWidth)
            {
                width = (int)maxWidth;
            }
            headerRectangle.Size = new Size((int)maxWidth, (int)headerSize.Height);
            graphics.DrawString(header, headerFont, Brushes.Black, headerRectangle, format);

            int textXPos = xPos + (int)headerSize.Width + horizontalSpaceAfterHeader;
            int textWidth = (int)maxWidth - (int)headerSize.Width - horizontalSpaceAfterHeader;

            // If header took up at least 50% of width then start text on next line
            if (textXPos > maxWidth / 2)
            {
                textXPos = xPos;
                textWidth = (int)maxWidth;
                yPos += (int)headerSize.Height;
            }

            // Print text.
            RectangleF paragraphRectangle = new RectangleF();
            paragraphRectangle.Location = new Point(textXPos, yPos);

            SizeF textSize = graphics.MeasureString(text, textFont, textWidth, format);
            paragraphRectangle.Size = new Size(textWidth, (int)textSize.Height);
            graphics.DrawString(text, textFont, Brushes.Black, paragraphRectangle, format);

            // Increment y position
            yPos += (int)textSize.Height + trailingSpace;
        }

        private StringFormat GetDefaultStringFormat()
        {
            return new StringFormat();
        }
        
        private void PrintDeveloperTasks() {

            // Print all the developer tasks within an iteration
            List<DeveloperIterationTasksView> tasks = DBInterface.GetDeveloperIterationTasksView(developer.ID, iteration.ID);
            foreach(DeveloperIterationTasksView task in tasks) {
                // Add task name and priority
                PrintParagraphHeader(task.TaskName + " (Priority: " + task.Priority + ")");

                // Add task description
                PrintParagraph(task.Description);

                // Add Other Developers
                List<Developer> otherDevelopers = DBInterface.GetOtherDevelopersForIterationTask(task.ID, iteration.ID, developer.ID);
                if (otherDevelopers.Any())
                {
                    PrintParagraphWithHeader("Other Developers: ", GetDeveloperText(otherDevelopers));
                }

                if (task.CompletionDate == null)
                {
                    // Add Completed checkbox, as taks isn't completed yet.
                    PrintParagraphWithHeaderAndCheckbox("Completed: ");
                }
                else
                {
                    // Task has been completed so include date it was completed instead of checkbox
                    PrintParagraphWithHeader("Completed: ", String.Format(dateFormat, iteration.StartDate));
                }

                // Add an extra gap before horizontal line
                yPos += paragraphFontOffSet;

                // Add a horizontal line to separate tasks
                DrawHorizontalLine();
            }
        }

        private string GetDeveloperText(List<Developer> developers)
        {
            // String all the developer names together, separated by commas
            string text = "";
            if (developers.Any())
            {
                foreach (Developer developer in developers)
                {
                    if (!text.Equals(""))
                    {
                        text += ", ";
                    }
                    text += developer;
                }
            }
            return text;
        }

        private void DrawHorizontalLine()
        {
            // Draw the horizontal line across the usable area of the page.
            graphics.DrawLine(horizontalLinePen, new Point(lineStart, yPos), new Point(lineEnd, yPos));
            yPos += lineOffset;
        }
    }
}

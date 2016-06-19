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
        // The vertical gap to allow for header
        private int headerFontOffSet = 40;
        // The horizontal gap between the header and the text when printed on one line
        private int horizontalSpaceAfterHeader = 5;

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
            SizeF reportHeaderSize = graphics.MeasureString(reportHeader, headerFont);
            // Find starting spot for header so it's in the centre
            int headerX = xPos + ((int)maxWidth - (int)reportHeaderSize.Width) / 2;
            graphics.DrawString(reportHeader, headerFont, Brushes.Black, headerX, yPos);
            yPos += headerFontOffSet;

        }

        private void PrintParagraphWithHeader(string header, string text)
        {
            // Calculate size of header to determine where text begins
            SizeF headerSize = graphics.MeasureString(header, paragraphBoldFont);
            // Print the header
            graphics.DrawString(header, paragraphBoldFont, Brushes.Black, xPos, yPos);
            // Print the text, offset by size of header and value in horizontalSpaceAfterHeader
            graphics.DrawString(text, paragraphFont, Brushes.Black, xPos + headerSize.Width + horizontalSpaceAfterHeader, yPos);
            // Increment y position
            yPos += paragraphFontOffSet;
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
            // Print a paragraph header line
            graphics.DrawString(header, paragraphBoldFont, Brushes.Black, xPos, yPos);
            // Increment y position
            yPos += paragraphFontOffSet;
        }

        private void PrintParagraph(string text)
        {
            // Print a paragraph line
            graphics.DrawString(text, paragraphFont, Brushes.Black, xPos, yPos);
            // Increment y position
            yPos += paragraphFontOffSet;

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

                // Add Completed checkbox
                PrintParagraphWithHeaderAndCheckbox("Completed: ");

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
            Console.WriteLine("lineStart = " + lineStart + ", lineEnd = " + lineEnd + ", yPos = " + yPos);

            // Draw the horizontal line across the usable area of the page.
            graphics.DrawLine(horizontalLinePen, new Point(lineStart, yPos), new Point(lineEnd, yPos));
            yPos += lineOffset;
        }
    }
}

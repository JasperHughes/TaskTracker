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

        public DeveloperIterationReport(Developer developer, Iteration iteration)
        {
            this.developer = developer;
            this.iteration = iteration;
        }

        protected override void OnPrintPage(PrintPageEventArgs eventArgs)
        {
            // Run base code
            base.OnPrintPage(eventArgs);

            string dateFormat = "{0:dd/MM/yyyy}";

            Graphics graphics = eventArgs.Graphics;

            // Calculate the margins.
            int marginLeft = eventArgs.PageSettings.Margins.Left;
            int marginRight = eventArgs.PageSettings.Margins.Right;
            int marginTop = eventArgs.PageSettings.Margins.Top;
            int marginBottom = eventArgs.PageSettings.Margins.Bottom;

            // Calculate print area size
            int printHeight = eventArgs.PageSettings.PaperSize.Height - marginTop - marginBottom;
            int printWidth = eventArgs.PageSettings.PaperSize.Width - marginLeft - marginRight;


            // Work out the usable height and width
            double maxHeight = eventArgs.PageSettings.PrintableArea.Height - marginTop - marginBottom;
            double maxWidth = eventArgs.PageSettings.PrintableArea.Width - marginLeft - marginRight;

            // Fonts for paragraph, bold paragraph and header.
            Font paragraphFont = new Font("Verdana", 10);
            Font paragraphBoldFont = new Font("Verdana", 10, FontStyle.Bold);
            Font headerFont = new Font("Verdana", 14, FontStyle.Bold);

            // The vertical gap to allow for paragraph
            int paragraphFontOffSet = 20;
            // The vertical gap to allow for header
            int headerFontOffSet = 40;
            // The horizontal gap between the header and the text when printed on one line
            int lineHeaderGap = 5;

            // Create a pen to use for horizontal line separator
            Pen horizontalLinePen = new Pen(Color.Black, 2);

            Pen checkboxPen = new Pen(Color.Black, 1);
            // Gap between header and checkbox
            int checkboxGap = 5;

            int lineStart = marginLeft;
            int lineEnd = marginLeft + (int)maxWidth;
            // After printing line use this value as offset before next row
            int lineOffset = 20;

            int startX = marginLeft;
            int startY = marginTop;
            int yPos = startY;
            
            // Add report header, centred
            string reportHeader = "Iteration Report for " + developer;
            SizeF reportHeaderSize = graphics.MeasureString(reportHeader, headerFont);
            // Find starting spot for header so it's in the centre
            int headerX = startX + ((int)maxWidth - (int)reportHeaderSize.Width) / 2;
            graphics.DrawString(reportHeader, headerFont, Brushes.Black, headerX, yPos);
            yPos += headerFontOffSet;

            // Add project name
            string projectHeader = "Project:";
            SizeF projectHeaderSize = graphics.MeasureString(projectHeader, paragraphBoldFont);
            graphics.DrawString(projectHeader, paragraphBoldFont, Brushes.Black, startX, yPos);
            graphics.DrawString(iteration.Project.ProjectName, paragraphFont, Brushes.Black, startX + projectHeaderSize.Width + lineHeaderGap, yPos);
            yPos += paragraphFontOffSet;

            // Add iteration start date
            string startDateHeader = "Iteration Start Date: ";
            SizeF startDateHeaderSize = graphics.MeasureString(startDateHeader, paragraphBoldFont);
            graphics.DrawString(startDateHeader, paragraphBoldFont, Brushes.Black, startX, yPos);
            graphics.DrawString(String.Format(dateFormat, iteration.StartDate), paragraphFont, Brushes.Black,
                startX + startDateHeaderSize.Width + lineHeaderGap, yPos);
            yPos += paragraphFontOffSet;

            // Add Iteration end date
            string endDateHeader = "Iteration End Date: ";
            SizeF endDateHeaderSize = graphics.MeasureString(startDateHeader, paragraphBoldFont);
            graphics.DrawString(endDateHeader, paragraphBoldFont, Brushes.Black, startX, yPos);
            graphics.DrawString(String.Format(dateFormat, iteration.EndDate), paragraphFont, Brushes.Black,
                startX + endDateHeaderSize.Width + lineHeaderGap, yPos);

            // Offset by 2 paragraphFontOffSet's to give some extra spacing
            yPos += paragraphFontOffSet * 2;
            
            // Draw line before displaying each of the tasks.
            graphics.DrawLine(horizontalLinePen, new Point(lineStart, yPos), new Point(lineEnd, yPos));
            yPos += lineOffset;

            // Display all the tasks for developer and iteration
            List<DeveloperIterationTasksView> tasks = DBInterface.GetDeveloperIterationTasksView(developer.ID, iteration.ID);
            foreach(DeveloperIterationTasksView task in tasks) {
                // Add task name and priority
                graphics.DrawString(task.TaskName + " (Priority: " + task.Priority + ")", paragraphBoldFont, Brushes.Black, startX, yPos);
                yPos += paragraphFontOffSet;

                // Add task description
                graphics.DrawString(task.Description, paragraphFont, Brushes.Black, startX, yPos);
                yPos += paragraphFontOffSet;

                // Add Other Developers
                graphics.DrawString("Other Developers: ", paragraphBoldFont, Brushes.Black, startX, yPos);
                yPos += paragraphFontOffSet;

                // Add Completed checkbox
                string completedHeader = "Completed: ";
                SizeF completedHeaderSize = graphics.MeasureString(completedHeader, paragraphBoldFont);
                graphics.DrawString(completedHeader, paragraphBoldFont, Brushes.Black, startX, yPos);
                Rectangle completedRectangle = new Rectangle(startX + (int)completedHeaderSize.Width + checkboxGap, yPos, 15, 15);
                graphics.DrawRectangle(checkboxPen, completedRectangle);
                yPos += paragraphFontOffSet;

                // Add an extra gap before horizontal line
                yPos += paragraphFontOffSet;

                // Add a horizontal line to separate tasks
                graphics.DrawLine(horizontalLinePen, new Point(lineStart, yPos), new Point(lineEnd, yPos));
                yPos += lineOffset;
            }

        }
    }
}

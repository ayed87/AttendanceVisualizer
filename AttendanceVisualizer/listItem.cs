using AttendanceVisualizer.classes;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceVisualizer
{
    public partial class listItem : UserControl
    {
        public listItem()
        {
            InitializeComponent();
        }
        private String dayNumber;
        private Pane timePane;

        [Category("Custom Props")]
        public String DayNumber
        {
            get { return dayNumber; }
            set { dayNumber = lblDayNumber.Text = "fahad"; }
        }
        [Category("Custom Props")]
        public Pane TimePane
        {
            get { return timePane; }

        }
        public void Draw() {

            //Graphics g = lblTimePanel.CreateGraphics();

            //Color timeLineColor = Color.Black;
            //Brush timeLineBrush = new SolidBrush(timeLineColor);
            //Pen timeLinePen = new Pen(timeLineColor);

            //Pen GreenPen = new Pen(Color.Blue);
            //Brush txtBrush = new SolidBrush(Color.Red);
            //AttendanceRecord attendanceRecord = new AttendanceRecord("09:24:41", "10:45:44");
            //double x = attendanceRecord.claculateDeffrence().TotalMinutes;
            //double s = attendanceRecord.StartTime.TotalMinutes;


            //g.FillRectangle(txtBrush, 60, 10, (float)x, 40);


            Graphics g = lblTimePanel.CreateGraphics();

            Color timeLineColor = Color.Black;
            Pen timeLinePen = new Pen(timeLineColor);

            Pen bluePen = new Pen(Color.Blue);
            Brush txtBrush = new SolidBrush(Color.Red);
            //AttendanceRecord attendanceRecord = new AttendanceRecord("09:24:41", "10:45:44");
            //double x = attendanceRecord.claculateDeffrence(); // Assuming CalculateDifference is a method in AttendanceRecord class.
            //double s = attendanceRecord.StartTime;

            // Make sure x is converted to an integer, and the width of the rectangle is not less than 1.
            //int rectangleWidth = Math.Max((int)x, 1);

            //// Draw a filled rectangle with the red brush
            //g.FillRectangle(txtBrush, 60, 10, rectangleWidth, 40);

            //// Draw a blue outline for the rectangle
            //g.DrawRectangle(bluePen, 60, 10, rectangleWidth, 40);


        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

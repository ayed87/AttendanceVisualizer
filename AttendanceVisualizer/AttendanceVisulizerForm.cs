using AttendanceVisualizer.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Excel = Microsoft.Office.Interop.Excel;
namespace AttendanceVisualizer

{
    public partial class AttendanceVisulizerForm : Form

    {
        EmplyoeeRecordReader emplyoeeRecordReader = new EmplyoeeRecordReader();

        public AttendanceVisulizerForm()
        {
            InitializeComponent();

        }

        private void ReadSheet_Button_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            emplyoeeRecordReader.loadData();
            Cursor = Cursors.Arrow;



            SheetContents_ListBox.Items.Clear();
            SheetContents_ListBox.Items.Add("Number of employees = " + emplyoeeRecordReader.getEmployees().Count.ToString());
            foreach (Employee employee in emplyoeeRecordReader.getEmployees())
            {
                SheetContents_ListBox.Items.Add(employee.getId());

            }

        }



        private void VisualizeButton_Click(object sender, EventArgs e)
        {
            string id =SheetContents_ListBox.SelectedItem.ToString();

            Employee employee = emplyoeeRecordReader.getEmployee(id);

            List<AttendanceRecord> attendances = employee.getAttendanceRecords();

            Graphics g = visualizationBox.CreateGraphics();
            g.Clear(Color.White);

            Color timeLineColor = Color.Black;
            Brush timeLineBrush = new SolidBrush(timeLineColor);
            Pen timeLinePen = new Pen(timeLineColor);

            Pen GreenPen = new Pen(Color.LightGray);
            Brush txtBrush = new SolidBrush(Color.Black);
           

            Point p3 = new Point(0, 10);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;

            Brush errorColor = new SolidBrush(Color.DarkBlue);
            Brush goodColor = new SolidBrush(Color.LightGreen);
            Brush LateColor = new SolidBrush(Color.Orange);
            Brush absetColor = new SolidBrush(Color.Red);
            // int main Vertical Destance is 30;
            // box listend Point is 1232; 
            // hour ----> 45
            // hight of each time rectangle is 20
            // small sqaure 15 width and hight
            // start postion for Time is 70 
            


            Point p4;

            for (int i = 0; i < attendances.Count ; i++)
            {
                // small square
                p3 = new Point(0, 10 + 30 * i);
                g.DrawString("Day " + (i+1), DrawButton.Font, txtBrush, p3, sf);

                // to split weeks by line 
                if((i+1)%5 == 0)
                {
                    Point linePoint1 = new Point(0, i*30+25);
                    // 
                    Point linePoint2 = new Point(1232, i*30+25);
                    g.DrawLine(GreenPen, linePoint1, linePoint2);
                }


                try
                {
                    TimeSpan duraitonTimeSpan = attendances[i].calculateDifference();
                    double duraiton = duraitonTimeSpan.TotalHours;
                    String duraitonText = duraitonTimeSpan.ToString();
                    double startTime = attendances[i].getStartTime().TotalHours;
                    double endTime = attendances[i].getEndTime().TotalHours;


                    if (duraiton > 8)
                    {
                        // if everythihng is well 
                        g.FillRectangle(goodColor, 70 + 40 * (float)startTime, 30 * i, 45 * (float)duraiton, 20);
                        g.FillRectangle(goodColor, 45, 2 + 30 * i, 15, 15);
                        Point p5 = new Point((int) endTime*45+70, 10 + 30 * i);
                        g.DrawString(duraitonText, DrawButton.Font, txtBrush, p5, sf);



                    }
                    else if (duraiton > 0 && duraiton< 8)
                    {

                        g.FillRectangle(LateColor, 70 + 40 * (float)startTime, 30 * i, 45 * (float)duraiton, 20);
                        g.FillRectangle(LateColor, 45, 2 + 30 * i, 15, 15);
                        Point p5 = new Point((int)endTime*45+70, 10 + 30 * i);
                        g.DrawString(duraitonText, DrawButton.Font, txtBrush, p5, sf);


                    }
                    else
                    {
                        p4 = new Point(70, 10 + 30 * i);
                        g.DrawString("Absent", DrawButton.Font, absetColor, p4, sf);
                        g.FillRectangle(absetColor, 45, 2 + 30 * i, 15, 15);

                    }




                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    p4 = new Point(70, 10 + 30 * i);
                    g.DrawString("error", DrawButton.Font, errorColor, p4, sf);
                    g.FillRectangle(errorColor, 45, 2 + 30 * i, 15, 15);


                }


            }
            





        }

        private void SheetContents_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttendanceVisulizerForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visualizationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listItem1_Load(object sender, EventArgs e)
        {

        }

        private void listItem1_Load_1(object sender, EventArgs e)
        {

        }

        private void listItem1_Load_2(object sender, EventArgs e)
        {

        }

        private void listItem1_Load_3(object sender, EventArgs e)
        {

        }



        private void DrawButton_Click(object sender, EventArgs e)
        {

        }

        private void visualizationBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}




//g.DrawString("Day 22", DrawButton.Font, txtBrush, p3, sf); //██████████████████████████████
//g.FillRectangle(txtBrush, 45, 2,15, 15);

//// this is the equation
//g.FillRectangle(txtBrush, 70+40*0, 0,45*2, 20);




//p3 = new Point(0, 10+30);

//g.FillRectangle(txtBrush, 70+40*0, 30 ,45*2, 20);

//g.FillRectangle(txtBrush, 45, 2+30, 15, 15);
//g.DrawString("Day 22", DrawButton.Font, txtBrush, p3, sf); //██████████████████████████████
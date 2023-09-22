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
        public AttendanceVisulizerForm()
        {
            InitializeComponent();
        }

        private void ReadSheet_Button_Click(object sender, EventArgs e)
        {
            {
                Excel.Workbook xWorkBook = Globals.ThisAddIn.Application.ActiveWorkbook;

                Excel.Worksheet xWorksheet = xWorkBook.Worksheets.Item[1];
                Excel.Range usedRng;
                usedRng = xWorksheet.UsedRange;
                int numberOfRows = usedRng.Rows.Count;
                int row = 1;
                Person person = new Person();
                SheetContents_ListBox.Items.Clear();
                SheetContents_ListBox.Items.Add("Number of Rows = " + numberOfRows.ToString());
                Excel.Range rng;


                while ( row <= numberOfRows  )
                {
                    rng = xWorksheet.Cells[row, 1];
                    SheetContents_ListBox.Items.Add(row.ToString() + ": " + rng.Value);
                    row += 1;

                }            
            }

        }

        private void VisualizeButton_Click(object sender, EventArgs e)
        {
            visualizationBox.Items.Clear();
            //Panel panel = new Panel();
            //panel.BackColor = Color.Black;
            Graphics g = new Panel().CreateGraphics(); 

            Color timeLineColor = Color.Black;
            Brush timeLineBrush =  new SolidBrush(timeLineColor);
            Pen timeLinePen = new Pen(timeLineColor);

            Pen GreenPen = new Pen(Color.Blue);
            Brush txtBrush = new SolidBrush(Color.Blue);


            Point p1 = new Point(20, 20);
            Point p2 = new Point(200, 200);
            g.DrawLine(GreenPen, p1, p2); // ██████████████████████████████


            StringFormat sf =  new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString("This is a string", DrawButton.Font, txtBrush, p2, sf); //██████████████████████████████


            g.FillRectangle(txtBrush, 30, 300, 300, 10); // ██████████████████████████████
            visualizationBox.Items.Add(g);

        }

        private void SheetContents_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimeLineDrawingPanel_Paint(object sender, PaintEventArgs e)
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
    }
}

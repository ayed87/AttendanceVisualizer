using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceVisualizer.classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AttendanceVisualizer.classes
{
     public class EmplyoeeRecordReader
    {

        private List<Employee> employees = new List<Employee>();


        public EmplyoeeRecordReader()
        {

        }
        public List<Employee> getEmployees()
        {
            return employees;
        }

        public Employee getEmployee(string employeeId) { 

            foreach (Employee employee in employees)
            {
                if(employee.getId().Equals(employeeId))
                {
                    return employee;
                }
            }

            return null;
        }


        public void loadData()
        {

            // loading the excel sheet
            Excel.Workbook xWorkBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet xWorksheet = xWorkBook.Worksheets.Item[1];
            Excel.Range usedRng;
            usedRng = xWorksheet.UsedRange;
            int numberOfRows = usedRng.Rows.Count;
            int row = 1;

            // reading the first record in the excel file 

            string id = ""+xWorksheet.Cells[row, 1].Value;
            string startTime = (String)xWorksheet.Cells[row, 3].text;
            string endTime = (String)xWorksheet.Cells[row, 4].text;

            string currentEmployeeId = id;
            AttendanceRecordCollection currentAttendanceRecordCollection = new AttendanceRecordCollection();
            AttendanceRecord attendanceRecord = new AttendanceRecord(startTime, endTime);
            currentAttendanceRecordCollection.addAttendanceRecord(attendanceRecord);
             row++;

            while (row <= numberOfRows)
            {
                id = "" + xWorksheet.Cells[row, 1].Value;
                startTime = (String)xWorksheet.Cells[row, 3].text;
                endTime = (String)xWorksheet.Cells[row, 4].text;
                // checking if the current record belongs to the current emplyoee?
                // if yes than just add the new record
                if(currentEmployeeId.Equals(id))
                {
                    attendanceRecord = new AttendanceRecord(startTime, endTime);
                    currentAttendanceRecordCollection.addAttendanceRecord(attendanceRecord);

                }
                // otherwise, create Employee object and store the collection
                // and id in it and add it to employee list
                else
                {
                    Employee employee = new Employee(currentEmployeeId,currentAttendanceRecordCollection);
                    employees.Add(employee);
                    // changing the current id to the new one
                    currentEmployeeId = id;
                    currentAttendanceRecordCollection= new AttendanceRecordCollection();
                    // making sure that also we store its first record for the new employee
                    // before going to the next itiration
                    attendanceRecord = new AttendanceRecord(startTime, endTime);
                    currentAttendanceRecordCollection.addAttendanceRecord(attendanceRecord);

                }
                row += 1;


            }

            // last employee 
            Employee lastEmployee = new Employee(currentEmployeeId, currentAttendanceRecordCollection);
            employees.Add(lastEmployee);


        }
    }
}



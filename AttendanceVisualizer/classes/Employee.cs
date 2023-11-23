using AttendanceVisualizer.classes;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Xml.Linq;

public class Employee
{
    private string id;
    private AttendanceRecordCollection employeeRecordCollection;

    public Employee(string id, AttendanceRecordCollection employeeRecordCollection) {
        this.id = id;
        this.employeeRecordCollection = employeeRecordCollection;
    }

    public string getId()
    {
        return id;
    }

    public List<AttendanceRecord> getAttendanceRecords()
    {
        return employeeRecordCollection.getAttendanceRecords();
    }


}
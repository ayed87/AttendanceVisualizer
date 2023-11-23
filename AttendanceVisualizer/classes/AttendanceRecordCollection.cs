using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceVisualizer.classes
{
    public class AttendanceRecordCollection
    {
        private List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();

        public AttendanceRecordCollection() { }

        public void addAttendanceRecord(AttendanceRecord attendanceRecord)
        {
            attendanceRecords.Add(attendanceRecord);
        }
        public List<AttendanceRecord> getAttendanceRecords() { return attendanceRecords; }
    }
}

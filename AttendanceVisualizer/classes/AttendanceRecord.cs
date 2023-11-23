using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceVisualizer.classes
{
    public class AttendanceRecord
    {
        // private String date;
        // for homework 1, we do not need the date
        private String startTime;
        private String endTime;

        public AttendanceRecord(String startTime, String endTime) { 
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public TimeSpan getStartTime()
        {
            if (startTime.Equals("-"))
            {
                return TimeSpan.Parse("00:00:00");
            }
            return TimeSpan.Parse(startTime);
        }

        public TimeSpan getEndTime() {
            if (endTime.Equals("-"))
            {
                return TimeSpan.Parse("00:00:00");
            }
            return TimeSpan.Parse(endTime);
        }
        
        public TimeSpan calculateDifference()
        {
            // if he/she is absent
            if (startTime.Equals("-") && endTime.Equals("-")){
                return TimeSpan.Parse("00:00:00");
            }
            // an exception might occur
            TimeSpan time1 = TimeSpan.Parse(startTime);
            TimeSpan time2 = TimeSpan.Parse(endTime);

            TimeSpan difference = time2.Subtract(time1);
            
            return difference;

        }

    }

}

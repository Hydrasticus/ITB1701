using System;

namespace HW09 {
    public class TimeCalculator {
        DateTime _initialTime = new DateTime(2000, 1, 1);

        public DateTime FindTime(double hours) {
            return _initialTime.AddHours(hours);
        }
        
        public DateTime AddDay(double days) {
            return _initialTime.AddDays(Math.Abs(days));
        }

        public DateTime SubtractDay(double days) {
            return _initialTime.AddDays(-Math.Abs(days));
        }
        
        
    }
}
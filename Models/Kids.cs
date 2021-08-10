using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class Kids
    {
        public long TzKids { get; set; }
        public string NameKids { get; set; }
        public string AgeKids { get; set; }
        public int? ClassId { get; set; }
        public DateTime DateBorn { get; set; }
        public long? ParentsId { get; set; }
        public int? AttendanceId { get; set; }

        public KidsAttendance Attendance { get; set; }
        public Classes Class { get; set; }
        public Parents Parents { get; set; }
    }
}

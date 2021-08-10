using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class ActivityUpdate
    {
        public int IdActivityUpdate { get; set; }
        public string WeeklyColumn { get; set; }
        public string Calendar { get; set; }
        public string DailyActivity { get; set; }
        public string LostSabbath { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }

        public Classes Class { get; set; }
        public TeacherAndManager Teacher { get; set; }
    }
}

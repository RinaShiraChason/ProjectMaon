using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class KidsAttendance
    {
        public KidsAttendance()
        {
            Kids = new HashSet<Kids>();
        }

        public int AttendanceId { get; set; }
        public int KidId { get; set; }
        public int ParentId { get; set; }
        public DateTime CurrentDate { get; set; }
        public bool Check { get; set; }

        public ICollection<Kids> Kids { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class PlacementOfATeacher
    {
        public int IdPlacementOfATeacher { get; set; }
        public string Shifts { get; set; }
        public DateTime DateShifts { get; set; }
        public int? ClassId { get; set; }
        public long? TeacherId { get; set; }

        public Classes Class { get; set; }
        public TeacherAndManager Teacher { get; set; }
    }
}

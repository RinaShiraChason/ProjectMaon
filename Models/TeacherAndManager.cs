using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class TeacherAndManager
    {
        public TeacherAndManager()
        {
            ActivityUpdate = new HashSet<ActivityUpdate>();
            PlacementOfATeacher = new HashSet<PlacementOfATeacher>();
            TypeEmployee = new HashSet<TypeEmployee>();
        }

        public long TeacherId { get; set; }
        public long TeacherTz { get; set; }
        public long? PersonTz { get; set; }

        public Person PersonTzNavigation { get; set; }
        public ICollection<ActivityUpdate> ActivityUpdate { get; set; }
        public ICollection<PlacementOfATeacher> PlacementOfATeacher { get; set; }
        public ICollection<TypeEmployee> TypeEmployee { get; set; }
    }
}

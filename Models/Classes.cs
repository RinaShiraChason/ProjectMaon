using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class Classes
    {
        public Classes()
        {
            ActivityUpdate = new HashSet<ActivityUpdate>();
            Kids = new HashSet<Kids>();
            PlacementOfATeacher = new HashSet<PlacementOfATeacher>();
            TypeClass = new HashSet<TypeClass>();
        }


        public int ClassId { get; set; }
        public int KindOfClassId { get; set; }

        public ICollection<ActivityUpdate> ActivityUpdate { get; set; }
        public ICollection<Kids> Kids { get; set; }
        public ICollection<PlacementOfATeacher> PlacementOfATeacher { get; set; }
        public ICollection<TypeClass> TypeClass { get; set; }
    }
}

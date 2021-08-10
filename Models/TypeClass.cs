using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class TypeClass
    {
        public int IdTypeClass { get; set; }
        public string TypeClassName { get; set; }
        public int? ClassId { get; set; }

        public Classes Class { get; set; }
    }
}

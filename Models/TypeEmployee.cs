using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class TypeEmployee
    {
        public int IdTypeEmp { get; set; }
        public string TypeEmpName { get; set; }
        public long? TeacherId { get; set; }

        public TeacherAndManager Teacher { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class Person
    {
        public Person()
        {
            Parents = new HashSet<Parents>();
            TeacherAndManager = new HashSet<TeacherAndManager>();
        }

        public long PersonTz { get; set; }
        public string PersonName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNamber1 { get; set; }
        public string PhoneNamber2 { get; set; }

        public ICollection<Parents> Parents { get; set; }
        public ICollection<TeacherAndManager> TeacherAndManager { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class Parents
    {
        public Parents()
        {
            Kids = new HashSet<Kids>();
        }

        public long ParentsId { get; set; }
        public long ParentsTz { get; set; }
        public long? PersonTz { get; set; }

        public Person PersonTzNavigation { get; set; }
        public ICollection<Kids> Kids { get; set; }
    }
}

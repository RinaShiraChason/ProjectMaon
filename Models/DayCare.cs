using System;
using System.Collections.Generic;

namespace exampleProject.Models
{
    public partial class DayCare//מעון יום
    {
        public int IdDayCare { get; set; }
        public string NameDayCare { get; set; }
        public int NumClasses { get; set; }
        public string DressDayCare { get; set; }
        public string AboutDayCare { get; set; }
    }
}

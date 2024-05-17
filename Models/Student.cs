using SE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE.Models
{
    public class Student : Users
    {
        public string Name { get; set; }
        public decimal CGPA { get; set; }
    }
}
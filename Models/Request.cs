using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int Complete { get; set; }
        public int studentid { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public string rollno { get; set; }
        public string program { get; set; }
        public string degree { get; set; }
        public string gender { get; set; }
        public int dues { get; set; }
        public int fees { get; set; }
        public int fyp { get; set; }
    }
}
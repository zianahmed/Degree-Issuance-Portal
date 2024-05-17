using SE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AdminToken : Request
    {
        public string remarks { get; set; }
        public int status { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
    }
}
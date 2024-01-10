using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fw.Models
{
    public class Trace
    {
        public string TracerId { get; set; }
        public string ProjectId { get; set; }
        
        public DateTime Date { get; set; }
        //public string Day { get; set; }
        public int HoursWorked { get; set; }
        public string UserId { get; set;}
        public string WorkedDescription { get; set; }
        public int IsActive { get; set; }
    }
}
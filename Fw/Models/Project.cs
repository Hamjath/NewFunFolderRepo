using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Fw.Models
{
    public class Project
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public int HoursAllocated { get; set; }
        public int IsActive { get; set; }
        public string UserId { get; set; }

    }
}
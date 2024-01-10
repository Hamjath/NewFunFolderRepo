using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fw.Models
{
	public class User
	{
		public string UserId { get; set; }
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public int IsActive { get; set; }
		
	}
}
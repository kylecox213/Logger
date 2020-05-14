using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroLogger.Models
{
	public class Controller
	{
		public int ID { get; set; }
		public int Model { get; set; }
		public string Type { get; set; }
		public bool Functional { get; set; }

		public virtual ICollection<Console> Consoles { get; set; }
	}
}
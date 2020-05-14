using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroLogger.Models
{
	public class Game
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public bool Complete { get; set; }
		public bool Beaten { get; set; }
		public bool Duplicate { get; set; }

		public virtual ICollection<Controller> Controllers { get; set; }
		public virtual ICollection<Console> Consoles { get; set; }
	}
}
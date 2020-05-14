using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroLogger.Models
{
	public class Console
	{
		public int ID { get; set; }
		public string Type { get; set; }
		public string Model { get; set; }
		public bool Functional { get; set; }
		public int GameID { get; set; }
		public int ControllerID { get; set; }

		public virtual Game Game { get; set; }
		public virtual Controller Controller { get; set; }
	}
}
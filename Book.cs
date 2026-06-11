using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Tracker
{
	internal class Book
	{
	   public string Title { get; set; }
	   public string Author { get; set; }
	   public string Genre { get; set; }
	   public string Status { get; set; }

	   public int PublicationYear { get; set; }

	   public int Rating { get; set; }
	}
}

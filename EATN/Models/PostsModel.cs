using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EATN.Models
{
	public class Posts
	{
		[Key]
		public int PostID { get; set; }
		public string PostedBy { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public DateTime LastModified { get; set; }
	}
}

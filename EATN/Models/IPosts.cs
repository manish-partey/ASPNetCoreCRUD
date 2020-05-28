using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EATN.Models
{
	public interface IPosts
	{
		IEnumerable<Posts> GetAllPosts();
		Posts GetPostByID(int id);

	}
}

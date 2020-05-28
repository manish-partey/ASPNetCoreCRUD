using EATN.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EATN.Models
{
	public class PostsRepository : IPosts
	{
		private readonly ApplicationDbContext applicationDbContext;

		public PostsRepository(ApplicationDbContext applicationDbContext)
		{
			this.applicationDbContext = applicationDbContext;
		}
		IEnumerable<Posts> IPosts.GetAllPosts()
		{
			return applicationDbContext.Posts.ToList();
		}
		Posts IPosts.GetPostByID(int id)
		{
			return applicationDbContext.Posts.FirstOrDefault(e => e.PostID == id);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using EATN.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;

namespace EATN.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Posts> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Posts>().HasData(
				new Posts
				{
					PostID = 1,
					PostedBy = "Manish",
					ShortDescription = "Short Description",
					LongDescription = "Long Description",
					LastModified = System.DateTime.Now
				}
				) ;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EATN.Models;
using Microsoft.AspNetCore.Mvc;

namespace EATN.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPosts posts;

        public PostsController(IPosts posts)
        {
            this.posts = posts;
        }
        public IActionResult Index()
        {
            var Posts = posts.GetAllPosts().OrderBy(e => e.LastModified);
            return View(Posts);
        }
    }
}
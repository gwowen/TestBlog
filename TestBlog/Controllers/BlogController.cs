using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBlog.Core;

namespace TestBlog.Controllers
{
    public class BlogController : Controller
    {
       public class BlogController
       {
           private readonly IBlogRepository _blogRepository;

           public BlogController(IBlogRepository blogRepository)
           {
               _blogRepository = blogRepository;
           }

           public ViewResult Posts(int p = 1)
           {
               //TODO: read and return posts from repository
           }
       }

    }
}

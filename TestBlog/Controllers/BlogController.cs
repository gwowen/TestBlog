﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBlog.Core;
using TestBlog.Core.Objects;
using TestBlog.Models;

namespace TestBlog.Controllers
{
    public class BlogController : Controller
    {
           private readonly IBlogRepository _blogRepository;

           public BlogController(IBlogRepository blogRepository)
           {
               _blogRepository = blogRepository;
           }

           public ViewResult Posts(int p = 1)
           {
               var viewModel = new ListViewModel(_blogRepository, p);

               ViewBag.Title = "Latest Posts";
               return View("List", viewModel);
           }
       }

}


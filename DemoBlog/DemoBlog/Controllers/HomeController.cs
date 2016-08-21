﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoBlog.Models;
using System.Data.Entity;

namespace DemoBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var latestPosts = db.Posts.Include(p => p.Author)
                .OrderByDescending(p => p.Date).Take(3);

            return View(latestPosts);
        }
    }
}
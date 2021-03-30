using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.ViewComponents
{
    public class LatesArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            List<Article> articles = new List<Article>()
            {   new Article(1, "آموزش illustror","کاملترین پکیج اموزشی به زبان فارسی", "blog-post-thumb-card-1.jpg"),
                   
                new Article(2, "آموزش Photophop","کاملترین پکیج اموزشی به زبان فارسی", "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش premier","کاملترین پکیج اموزشی به زبان فارسی", "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش after effect","کاملترین پکیج اموزشی به زبان فارسی", "blog-post-thumb-card-4.jpg")

            };
            return View("_LatesArticles",articles);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            List<Project> projects = new List<Project>()
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg","neshi"),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg","ZoodFood"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس","project-3.jpg","MONOP"),
                new Project(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "project-4.jpg","NASA")

            };
            return View("_Project",projects);
        }
    }
}

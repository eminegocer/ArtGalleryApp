using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)

        {
            if (id == null)
            {
                return RedirectToAction("list", "course");
            }
            var kurs = Repository.GetById(id);

            return View(kurs);
        }

        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);
        }
    }
}
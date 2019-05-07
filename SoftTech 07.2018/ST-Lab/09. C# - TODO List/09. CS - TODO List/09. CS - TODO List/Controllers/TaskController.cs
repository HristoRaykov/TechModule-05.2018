using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODOList.Models;
using Task = System.Threading.Tasks.Task;

namespace _09._CS___TODO_List.Controllers
{
    public class TaskController : Controller
    {
        public readonly TaskDbContext context;

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (task==null)
            {
                return RedirectToAction("Index", "Home");
            }

            context.Tasks.Add(task);
            context.SaveChanges();

            return View();
        }
    }
}
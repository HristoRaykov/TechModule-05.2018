
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http.Features;

namespace ProjectRider.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ProjectRider.Models;

    public class ProjectController : Controller
    {
        private readonly ProjectDbContext context;

        public ProjectController(ProjectDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            List<Project> projects = context.Projects.ToList();

            return View(projects);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                context.Projects.Add(project);
                context.SaveChanges();

                return Redirect("/");
            }
            
            return View(project);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            Project project = context.Projects.Find(id);
            
            return View(project);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Project projectModel)
        {
            Project project = context.Projects.Find(id);

            if (ModelState.IsValid)
            {
                project.Title = projectModel.Title;
                project.Description = projectModel.Description;
                project.Budget = projectModel.Budget;

                context.Projects.Update(project);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit",projectModel);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Project project = context.Projects.Find(id);

            return View(project);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Project projectModel)
        {
            Project project = context.Projects.Find(id); 

            context.Projects.Remove(project);
            context.SaveChanges();

            return RedirectToAction("Index"); 
        }
    }
}

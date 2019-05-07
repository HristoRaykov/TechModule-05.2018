using System.Collections.Generic;

namespace IssueTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IssueTracker.Models;
    using System.Linq;
    using System.Collections.Generic;

    public class IssueController : Controller
    {
        private readonly IssueDbContext context;

        public IssueController(IssueDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            List<Issue> issues = context.Issues.ToList();
			
            return View(issues);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Issue issue)
        {
            if (ModelState.IsValid)
            {
                context.Issues.Add(issue);
                context.SaveChanges();

                return Redirect("/");
            }

            return View(issue);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            Issue issue = context.Issues.Find(id);
            
            return View(issue);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Issue issueModel)
        {
            Issue issue = context.Issues.Find(id);

            if (ModelState.IsValid)
            {
                issue.Title = issueModel.Title;
                issue.Content = issueModel.Content;
                issue.Priority = issueModel.Priority;

                context.Issues.Update(issue);
                context.SaveChanges();

                return Redirect("/");
            }

            return RedirectToAction("Edit",issueModel);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Issue issue = context.Issues.Find(id);

            return View(issue);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Issue issueModel)
        {
            Issue issue = context.Issues.Find(id);

            context.Issues.Remove(issue);
            context.SaveChanges();

            return Redirect("/");
        }
    }
}

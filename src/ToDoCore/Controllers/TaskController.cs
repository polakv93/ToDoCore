using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoCore.Model;
using ToDoCore.ViewModel;

namespace ToDoCore.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.Tasks.Where(t => t.IsActive).ToList();
            var viewTasks = new List<TaskViewModel>();
            tasks.ForEach(t => viewTasks.Add(new TaskViewModel(t)));
            return View(viewTasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Tasks.Add(new Task() {Description = model.Description, IsActive = true});
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

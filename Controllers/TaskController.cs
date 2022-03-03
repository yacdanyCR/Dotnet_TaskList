using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskList
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TaskController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<TaskModel> objTasksList=_db.Tasks;
            return View(objTasksList);
        }
    }
}
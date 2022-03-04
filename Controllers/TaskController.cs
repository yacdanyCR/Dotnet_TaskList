using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TaskList
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TaskController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TaskModel> objTasksList = _db.Tasks;
            return View(objTasksList);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var taskObj=await _db.Tasks.FirstOrDefaultAsync(e=>e.Id==id);
            if(taskObj==null){
                return NotFound();
            }

            _db.Remove(taskObj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
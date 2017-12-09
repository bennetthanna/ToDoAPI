using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using System.Linq;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;

            if (_context.ToDoItems.Count() == 0)
            {
                _context.ToDoItems.Add(new ToDoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }
    }
}
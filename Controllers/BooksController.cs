using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Book_API.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

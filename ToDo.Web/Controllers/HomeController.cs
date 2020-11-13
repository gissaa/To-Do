using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interface;

namespace ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        IAssignmentService _assignmentService;
        public HomeController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

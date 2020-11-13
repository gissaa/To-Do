using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interface;
using ToDo.Entities.Concrete;
using ToDo.Web.Areas.Admin.Models;

namespace ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrgencyController : Controller
    {
        private readonly IUrgencyService _urgencyService;
        public UrgencyController(IUrgencyService urgencyService)
        {
            _urgencyService = urgencyService;
        }
        public ActionResult Index()
        {
            List<Urgency> urgencies = _urgencyService.GetAll().ToList();
            List<UrgencyListViewModel> model = new List<UrgencyListViewModel>();
            foreach(var item in urgencies)
            {
                UrgencyListViewModel urgencyListViewModel = new UrgencyListViewModel();
                urgencyListViewModel.Id = item.Id;
                urgencyListViewModel.Definition = item.Definition;
                model.Add(urgencyListViewModel);
            }
            return View(model);
        }
        public IActionResult AddUrgency()
        {
            return View(new UrgencyAddViewModel());
        }
        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel urgencyAddViewModel)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Add(new Urgency()
                {
                    Definition = urgencyAddViewModel.Definition
                });
                return RedirectToAction("Index");
            }
            return View(urgencyAddViewModel);
        }
        public IActionResult UpdateUrgency(int id)
        {
           var urgency= _urgencyService.GetById(id);
            UrgencyUpdateViewModel model = new UrgencyUpdateViewModel
            {
                Id = urgency.Id,
                Definition = urgency.Definition
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateUrgency(UrgencyUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _urgencyService.Update(new Urgency
                {
                    Id = model.Id,
                    Definition = model.Definition
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}

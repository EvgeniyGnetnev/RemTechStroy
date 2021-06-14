using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemTechStroy.Domain;
using RemTechStroy.Domain.Entities;
using RemTechStroy.Service;

namespace RemTechStroy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public TableController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new TableTemplate() : dataManager.TableTemplates.GetTableItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(TableTemplate model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TableTemplates.SaveTableItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.TableTemplates.DeleteTableItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
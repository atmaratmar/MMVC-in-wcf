using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MMVC.Controllers
{
    public class PPPController : Controller
    {
       
        // GET: PPP
        public async Task<ActionResult> Index()
        {
            var service = new ServiceReference2.PersonWcfServiceClient();
            var personer = await service.GetAllePersonerAsync();
            return View(personer);
        }

        public async Task<ActionResult> Detail(int id)
        {
            var service = new ServiceReference2.PersonWcfServiceClient();
            var personer = await service.GetAllePersonerAsync();
            return View(personer[id]);
        }
        // GET: PPP/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
            
        //}

        // GET: PPP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PPP/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PPP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PPP/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PPP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PPP/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
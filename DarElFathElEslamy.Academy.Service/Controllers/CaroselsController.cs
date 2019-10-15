using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DarElFathElEslamy.Academy.Data.EF;
using DarElFathElEslamy.Academy.Domain.Models.LookUps;
using DarElFathElEslamy.Academy.Domain.Services;
using System.IO;

namespace DarElFathElEslamy.Academy.Service.Controllers
{
    public class CaroselsController : BaseController
    {
        private readonly CaroselService cs = new CaroselService(new EFRepository<Carosel>(new EFUnitOfWork()));


        // GET: Carosels
        public ActionResult Index()
        {
            return View(cs.GetAll().ToList());
        }

        // GET: Carosels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }
            Carosel carosel = cs.GetCarosel(id);
            if (carosel == null)
            {
                throw new ArgumentNullException();
            }
            return View(carosel);
        }

        // GET: Carosels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carosels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EnTitle,EnDesc,FrTitle,FrDesc")] Carosel carosel, HttpPostedFileBase file)
        {
            if (file != null)
            {
                string path = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(file.FileName));
                file.SaveAs(path);

                string fileName = Path.GetFileName(path);
                file.SaveAs(path);
                carosel.ImagePath = fileName;
            }
            if (ModelState.IsValid)
            {
                cs.Add(carosel);
                return RedirectToAction("Index");
            }

            return View(carosel);
        }

        // GET: Carosels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            Carosel carosel = cs.GetCarosel(id);

            if (carosel == null)
            {
                throw new ArgumentNullException();
            }
            return View(carosel);
        }

        // POST: Carosels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EnTitle,EnDesc,FrTitle,FrDesc,ImagePath")] Carosel carosel)
        {
            if (ModelState.IsValid)
            {
                cs.Modify(carosel);
                return RedirectToAction("Index");
            }
            return View(carosel);
        }

        // GET: Carosels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }
            Carosel carosel = cs.GetCarosel(id);
            if (carosel == null)
            {
                throw new ArgumentNullException();
            }
            return View(carosel);
        }

        // POST: Carosels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carosel carosel = cs.GetCarosel(id);
            cs.Remove(carosel);
            return RedirectToAction("Index");
        }
    }
}

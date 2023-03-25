using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRM4.Models;

namespace CRM4.Controllers
{
    public class ApplicantsController : Controller
    {
        private CRM4Entities db = new CRM4Entities();

        // GET: Applicants
        public ActionResult Index()
        {
            var applicants = db.Applicants.Include(a => a.AssetType).Include(a => a.AssetType1).Include(a => a.AssetType2).Include(a => a.AssetType3);
            return View(applicants.ToList());
        }

        // GET: Applicants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicants/Create
        public ActionResult Create()
        {
            ViewBag.AskingAssetType1 = new SelectList(db.AssetTypes, "AssetTypeId", "Name");
            ViewBag.AskingAssetType2 = new SelectList(db.AssetTypes, "AssetTypeId", "Name");
            ViewBag.AskingAssetType3 = new SelectList(db.AssetTypes, "AssetTypeId", "Name");
            ViewBag.AskingAssetType4 = new SelectList(db.AssetTypes, "AssetTypeId", "Name");
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicantId,Name,Age,Gender,Address,ContactingNumber,SharingInfo,Income,Employer,AskingAssetType1,AskingAssetType2,AskingAssetType3,AskingAssetType4")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AskingAssetType1 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType1);
            ViewBag.AskingAssetType2 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType2);
            ViewBag.AskingAssetType3 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType3);
            ViewBag.AskingAssetType4 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType4);
            return View(applicant);
        }

        // GET: Applicants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            ViewBag.AskingAssetType1 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType1);
            ViewBag.AskingAssetType2 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType2);
            ViewBag.AskingAssetType3 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType3);
            ViewBag.AskingAssetType4 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType4);
            return View(applicant);
        }

        // POST: Applicants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicantId,Name,Age,Gender,Address,ContactingNumber,SharingInfo,Income,Employer,AskingAssetType1,AskingAssetType2,AskingAssetType3,AskingAssetType4")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AskingAssetType1 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType1);
            ViewBag.AskingAssetType2 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType2);
            ViewBag.AskingAssetType3 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType3);
            ViewBag.AskingAssetType4 = new SelectList(db.AssetTypes, "AssetTypeId", "Name", applicant.AskingAssetType4);
            return View(applicant);
        }

        // GET: Applicants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testtest.Models;

namespace testtest.Controllers
{
    public class HomeController : Controller
    {
        entiteFramworkEntities db = new entiteFramworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //--------------------  Operatoin CRUD specialite  ----------------------//
        [HttpGet]
        public ActionResult ActionSpecialite()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActionSpecialite(Specialite s)
        {
            db.Specialites.Add(s);
            db.SaveChanges();
            return RedirectToAction("Tableau");
        }

        public ActionResult Tableau()
        {
            ViewBag.Specialite = db.Specialites.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var specialite = db.Specialites.Find(id);

            return View("Edit", specialite);
        }

        [HttpPost]
        public ActionResult Edit(Specialite s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Tableau");
        }

        public ActionResult Delete(int id)
        {  
            var specialite = db.Specialites.Find(id);
            db.Specialites.Remove(specialite);
            db.SaveChanges();
            return RedirectToAction("Tableau");
        }
        //-----------------------------------------------------//


        //--------------------  Operatoin CRUD stagiaire  ----------------------//
        [HttpGet]
        public ActionResult ActionStagiaire()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActionStagiaire(Stagiaire s)
        {
            db.Stagiaires.Add(s);
            db.SaveChanges();
            return RedirectToAction("Tableau2");
        }

        public ActionResult Tableau2()
        {
            ViewBag.Stagiaire = db.Stagiaires.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Edit2(int id)
        {
            var stagiaire = db.Stagiaires.Find(id);

            return View("Edit2", stagiaire);
        }

        [HttpPost]
        public ActionResult Edit2(Stagiaire s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Tableau2");
        }

        public ActionResult Delete2(int id)
        {
            var stagiaire = db.Stagiaires.Find(id);
            db.Stagiaires.Remove(stagiaire);
            db.SaveChanges();
            return RedirectToAction("Tableau2");
        }
        //-----------------------------------------------------//


    }
}
﻿using debesalgo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace debesalgo.Controllers
{    
    public class ClosedBusinessController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ClosedBusiness
        public ActionResult Index()
        {
            /*                                   
            El Obrero
            Jose Enrique
            Cafe Puerto Rico
            Empresas Sultanas
            Bambi
            La Patisserie de France
            Flora by Arquetipo
            Party Line
            PR Exhibit Manufacturing
            La Habichuela y Arrocito con
            Valcor-Samcor
            Euromoda*/            
            return Json(db.ClosedBusinesses.ToList(), JsonRequestBehavior.AllowGet);
        }        
    }
}

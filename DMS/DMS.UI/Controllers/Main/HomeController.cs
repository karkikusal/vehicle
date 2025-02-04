﻿using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
   // [CustomAuthentication]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;

        public HomeController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public ActionResult AccessDeniedPage()
        {
            return View();
        }


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
            
            return View();
        }

        public async Task<ActionResult> Dashboard()
        {
            return RedirectToAction("Index");
        }
        public ActionResult Homeappliance()
        {
            
            return View();
        }
        public ActionResult Ghar()
        {

            return View();
        }
        public ActionResult accessories()
        {

            return View();
        }
        public ActionResult computing()
        {

            return View();
        }
        public ActionResult mobile()
        {

            return View();
        }

        public ActionResult search()
        {

            return View();
        }

        public ActionResult service()
        {

            return View();
        }
    }
}
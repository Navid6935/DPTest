using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using DPTest.Models;

namespace DPTest.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        // GET: Utilities/CostCenters/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserName", user.UserName);
            parameters.Add("@UserMobile", user.UserMobile);
            parameters.Add("@UserEmail", user.UserEmail);
            
            return View(user);
        }
    }
}
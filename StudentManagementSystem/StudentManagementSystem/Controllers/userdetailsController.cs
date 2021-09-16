using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class userdetailsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(userdetail model)
        {
            using (project_1Entities context = new project_1Entities())
            {
                bool IsValidUser = context.userdetails.Any(user => user.userid.ToLower() ==
                     model.userid.ToLower() && user.password == model.password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(model.userid, false);
                    return RedirectToAction("Index", "userdetails");
                }
                ModelState.AddModelError("", "invalid Username or Password");
                return View();
            }
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(userdetail model)
        {
            using (project_1Entities context = new project_1Entities())
            {
                context.userdetails.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
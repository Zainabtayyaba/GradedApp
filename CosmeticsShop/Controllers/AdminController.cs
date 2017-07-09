using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using CosmeticsShop.Models;
using CosmeticsShop.Models.ViewModels;

namespace CosmeticsShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private shoppingappEntities1 db = new shoppingappEntities1();

        // GET: User
        [HttpGet]
        public ActionResult AdminSignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminSignUp(Models.user u)
        {
            if (ModelState.IsValid)
            {
                u.Password = Crypto.Hash(u.Password);
                u.ConfirmPassword =Crypto.Hash(u.ConfirmPassword);

                u.Isadmin = true;
                db.users.Add(u);
                db.SaveChanges();

            }
            else
            {
                ViewBag.Message = "InvalidRequest";
            }

            return View(u);
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            if (System.Web.HttpContext.Current.Session["username"] != null)
            {
                return RedirectToAction("Cart", "User", new { username = Session["username"].ToString() });
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(LogInViewModel login, string returnUrl)
        {

            var v = db.users.SingleOrDefault(x => x.Email == login.Email);

            

            if (v != null && String.CompareOrdinal(Crypto.Hash(login.Password), v.Password) == 0)
            {
                ViewBag.message = "Login";
                ViewBag.triedOnce = "yes";
                System.Web.HttpContext.Current.Session["username"] = v.Email;
                return RedirectToAction("Cart", "Users", new { username = login.Email});

            }

            else
            {
                ViewBag.triedOnce = "yes";
                return View();

            }


        }



        [HttpGet]
        public ActionResult AdminLogOut()
        {
            System.Web.HttpContext.Current.Session.RemoveAll();
            System.Web.HttpContext.Current.Session.Clear();
            System.Web.HttpContext.Current.Session.Abandon();

            return RedirectToAction("Login");
        }




        public ActionResult AdminView(string username)
        {

            if (Session["username"] == null)
            {
                return RedirectToAction("Login", "Users");
            }
            else
            {
                ViewBag.username = Session["username"];
                return View();
            }
        }


    }
}
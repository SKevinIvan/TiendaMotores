﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaMotores.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            if (HttpContext.Request.Cookies["usuario"] != null)
            {
                HttpCookie usuario = HttpContext.Request.Cookies.Get("usuario");
                string rol="";
                string items="";
                rol = Request.Cookies.Get("usuario").Values.Get("rol");
                if (rol != "Cliente")
                {
                    Session["nombre"] = "";
                    Session["usuario"] = "";
                    Session["itemTotal"] = 0;
                    Session["cart"] = null;
                    if ((Request.IsAuthenticated) && (Session["nombre"] == null))
                    {
                        string correo = User.Identity.Name;
                        return RedirectToAction("IndexLogin", "Acceso", routeValues: new { email = correo });
                    }
                }
                else
                {
                    items = Request.Cookies.Get("usuario").Values.Get("itemTotal");
                    Session["itemTotal"] = items;
                    if ((Request.IsAuthenticated) && (Session["nombre"] == null))
                    {
                        string correo = User.Identity.Name;
                        return RedirectToAction("IndexLogin", "Acceso", routeValues: new { email = correo });
                    }
                }
            }
            else
            {

                if (Session["cart"] == null)
                {
                    Session["itemTotal"] = 0;
                    Session["cart"] = null;
                }
            }
            return View();
        }
        public ActionResult Usuario()
        {
           
            return RedirectToAction("Index");
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
    }
}
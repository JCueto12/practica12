using System;
using Microsoft.AspNetCore.Mvc;
namespace Practica12.Controllers
{
    public class AreaController : Controller
    {
        public ActionResult Index(string bcse, string altura, string tipo)
        {
            int a = Convert.ToInt32(bcse);
            int b = Convert.ToInt32(altura);
            int c = 0;
            if(tipo=="Triangulo")
            {
                c = (a*b)/2;
                ViewBag.Result = c;
            }
            else if(tipo=="Rectangulo")
            {
                c = a*b;
                ViewBag.Result = c;
            }
            else
            {
                ViewBag.Result = c;
            }
            return View();
        }
    }
}
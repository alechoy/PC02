using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC02.Models;

namespace PC02.Controllers
{

    public class SolicitudController : Controller
    {
        
        public IActionResult Solicitud() {
            return View();
        }

        [HttpPost]
        public IActionResult Solicitud(Solicitud solicitud) {
            Console.WriteLine(solicitud.Nombres);
            Console.WriteLine(solicitud.ApellidoPaterno);
            Console.WriteLine(solicitud.ApellidoMaterno);
            Console.WriteLine(solicitud.TipoDeMascota);
            Console.WriteLine(solicitud.Descripción);
            Console.WriteLine(solicitud.Telefono);
            Console.WriteLine(solicitud.Distrito);
            Console.WriteLine(solicitud.Direccion);
            return RedirectToAction("SolicitudConfirmacion");
        }

      public IActionResult SolicitudConfirmacion(){
            return View();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepasoMVCvehiculos.Datos;
using RepasoMVCvehiculos.Models;

namespace RepasoMVCvehiculos.Controllers
{
    public class VehiculoController : Controller
    {
        VehiculoAdmin admin = new VehiculoAdmin();
        // GET: Vehiculo
        public ActionResult Index()
        {
            IEnumerable<VEHICULOS> lista = admin.consultar();
            return View(lista);
        }
    }
}
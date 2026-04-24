
using Microsoft.AspNetCore.Mvc;
using ShippingCalculator.Models;

namespace ShippingCalculator.Controllers
{
    public class EnvioController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Envio modelo)
        {
            if (modelo.Peso <= 0)
            {
                ViewBag.Error = "Ingrese un peso válido";
                return View("Index");
            }

            switch (modelo.Pais)
            {
                case "India":
                    modelo.Costo = modelo.Peso * 5;
                    break;

                case "US":
                    modelo.Costo = modelo.Peso * 8;
                    break;

                case "UK":
                    modelo.Costo = modelo.Peso * 10;
                    break;
            }

            return View("Index", modelo);
        }
    }
}

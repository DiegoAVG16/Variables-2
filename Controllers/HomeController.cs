using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Variables_2.Models;

namespace Variables_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string cedula, string nombre, string apellido, string edad, int? estado)
    {
        List<EmprendedorModel> _listaEmprendedor = new List<EmprendedorModel>();
            var emprendedor = new EmprendedorModel

            {
                Apellido = apellido,
                Cedula_Ruc = cedula,
                Direccion = "Santo Domingo",
                Edad = edad,
                Genero = true,
                Telefono = "0958726867",
                Nombre = nombre,
                Id = 1
            };
            _listaEmprendedor.Add(emprendedor);
                 
            return View(_listaEmprendedor);


    }

    public IActionResult Privacy(string nombre, string apellido, string edad, int? estado)
    { 
        int _estado = estado == null ? 0 : (int)estado;
        var emprendedor = new EmprendedorModel

        {
            Apellido = apellido,
            Cedula_Ruc = "1715711147",
            Direccion = "Santo Domingo",
            Edad = edad,
            Genero = true,
            Telefono = "0958726867",
            Nombre = nombre,
            Id = 1
        };
    
        return View(emprendedor);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ClienteModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Cliente> ListaClientes = new List<Cliente>(); 
        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();

        Cliente cliente1 = new Cliente(01, "Cliente", "12345678911", "email@email.com", "lulu");
        Cliente cliente2 = new Cliente(02, "Cliente2", "12345678911", "email@email.com", "lulu");
        Cliente cliente3 = new Cliente(03, "Cliente3", "12345678911", "email@email.com", "lulu");
        Cliente cliente4 = new Cliente(04, "Cliente4", "12345678911", "email@email.com", "lulu");
        Cliente cliente5 = new Cliente(05, "Cliente5", "12345678911", "email@email.com", "lulu");

        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        Fornecedor fornecedor1 = new Fornecedor(01, "fornecedor", "123456789", "email@email.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "fornecedor2", "123456789", "email@email.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "fornecedor3", "123456789", "email@email.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "fornecedor4", "123456789", "email@email.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "fornecedor5", "123456789", "email@email.com");

        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaClientes = ListaClientes;
        ViewBag.ListaFornecedores = ListaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

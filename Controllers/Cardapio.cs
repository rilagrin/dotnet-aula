using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace UniFood.Controllers;

public class Cardapio : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    /*public string Index(string nome, int idade=1)
    {
        return HtmlEncoder.Default.Encode(
            $"Hello World {nome},{idade}"
            );
    }*/

    public string Pedido()
    {
        return "Em manutenção.";
    }
}
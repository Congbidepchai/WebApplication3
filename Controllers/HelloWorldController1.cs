using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "Day la action mac dinh (Index)...";
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    // GET: /HelloWorld/Welcome/3?name=Rick
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Xin chao {name}, ID la: {ID}");
    }
}
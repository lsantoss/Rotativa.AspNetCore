using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Rotativa.Models;

namespace Rotativa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){ Cpf="127.256.369.35", Nome="Lucas Santos", Sexo="Masculino", Idade=23, Telefone="3841-3856" },
                new Pessoa(){ Cpf="185.989.636.85", Nome="Júlia Almeida", Sexo="Feminino", Idade=13, Telefone="3142-3885" },
                new Pessoa(){ Cpf="589.245.854.14", Nome="Carlos Cesar", Sexo="Masculino", Idade=35, Telefone="3885-1212" },
                new Pessoa(){ Cpf="753.357.147.25", Nome="Altair Silva", Sexo="Masculino", Idade=58, Telefone="3696-1296" },
                new Pessoa(){ Cpf="441.258.369.85", Nome="Ana Clara", Sexo="Feminino", Idade=21, Telefone="3758-4745" },
                new Pessoa(){ Cpf="758.969.354.14", Nome="Lara Magalhães", Sexo="Feminino", Idade=18, Telefone="3996-6658" },
                new Pessoa(){ Cpf="894.758.263.21", Nome="Ronaldo Santos", Sexo="Masculino", Idade=40, Telefone="3745-7585" },
                new Pessoa(){ Cpf="141.456.251.32", Nome="Marcus Vinícius", Sexo="Masculino", Idade=32, Telefone="3442-3365" },
            };

            return new ViewAsPdf("Index", pessoas);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

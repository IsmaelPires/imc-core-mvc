using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoTesteCoreMVC.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjetoTesteCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ListaTabela = PreparaTabela();

            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Salvar(dynamic obj)
        {
            return obj;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<PessoaViewModel> PreparaTabela()
        {
            var listaPessoa = new List<PessoaViewModel>();
            var pessoa = new PessoaViewModel();
            pessoa.Cpf = "75579820100";
            pessoa.Nome = "Ismael";
            pessoa.Idade = 25;
            pessoa.Altura = 1.77;

            listaPessoa.Add(pessoa);

            var pessoa2 = new PessoaViewModel();
            pessoa2.Cpf = "70018398170";
            pessoa2.Nome = "Ewelin";
            pessoa2.Idade = 26;
            pessoa2.Altura = 1.70;

            listaPessoa.Add(pessoa2);

            return listaPessoa;
        }
    }
}

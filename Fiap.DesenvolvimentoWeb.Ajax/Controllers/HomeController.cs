using Fiap.DesenvolvimentoWeb.Ajax.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.DesenvolvimentoWeb.Ajax.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MostrarProduto()
        {
            return View();
        }

        [HttpPost]
        public string BuscarProduto(int query)
        {
            return Db.BuscarProduto(query);
        }

        [HttpGet]
        public ActionResult PesquisarProdutos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PesquisarProdutos(string query)
        {
            List<Product> lista = Db.ListarProdutos(query);

            if (Request.IsAjaxRequest())
                return PartialView("_ListaProdutos", lista);

            return View(lista);
        }
    }
}
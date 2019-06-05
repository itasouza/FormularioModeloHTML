using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using JQueryDataTableCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace JQueryDataTableCore.Controllers
{
    public class ServerProcessingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
////https://www.devmedia.com.br/integrando-jquery-datatables-com-asp-net-mvc/27767 -->

        [HttpGet]
        public IActionResult Processar()
        {
            
            string echo        = HttpContext.Request.Query["sEcho"].ToString();
            string iColumns    = HttpContext.Request.Query["iColumns"].ToString();
            string sColumns    = HttpContext.Request.Query["sColumns"].ToString();
            int iDisplayStart  = int.Parse(HttpContext.Request.Query["iDisplayStart"].ToString());
            int iDisplayLength = int.Parse(HttpContext.Request.Query["iDisplayLength"].ToString());
            string mDataProp_0 = HttpContext.Request.Query["mDataProp_0"].ToString();
            string sSearch     = HttpContext.Request.Query["sSearch"].ToString();
            string iSortCol_0  = HttpContext.Request.Query["iSortCol_0"].ToString();
            string sSortDir_0  = HttpContext.Request.Query["sSortDir_0"].ToString();
            string iSortingCols= HttpContext.Request.Query["iSortingCols"].ToString();
            string bSortable_0 = HttpContext.Request.Query["bSortable_0"].ToString();
            int regExibir      = iDisplayLength;
            int startExibir    = iDisplayStart;

            IList<Cliente> clientesCadastrados = Repositorio.RepositorioFake.GetClientesCadastrados();
            IList<Cliente> clientesFiltrados = clientesCadastrados
                .Where(x =>
                    (x.Id.ToString().Contains(sSearch.ToUpper())) ||
                    (x.Nome.ToUpper().Contains(sSearch.ToUpper())) ||
                    (x.Sexo.ToUpper().Contains(sSearch.ToUpper())) ||
                    (x.Estado.ToUpper().Contains(sSearch.ToUpper())) ||
                    (x.Idade.ToString().Contains(sSearch.ToUpper()))
                    ).ToList<Cliente>();


            if (iDisplayStart > clientesFiltrados.Count)
                startExibir = 0;

            if (iDisplayStart + iDisplayLength > clientesFiltrados.Count)
                regExibir = clientesFiltrados.Count - startExibir;

            if (sSortDir_0 == "asc")
            {
                if (iSortCol_0 == "0")
                    clientesFiltrados = clientesFiltrados.OrderBy(x => x.Id).ToList<Cliente>();
                if (iSortCol_0 == "1")
                    clientesFiltrados = clientesFiltrados.OrderBy(x => x.Nome).ToList<Cliente>();
                if (iSortCol_0 == "2")
                    clientesFiltrados = clientesFiltrados.OrderBy(x => x.Sexo).ToList<Cliente>();
                if (iSortCol_0 == "3")
                    clientesFiltrados = clientesFiltrados.OrderBy(x => x.Estado).ToList<Cliente>();
                if (iSortCol_0 == "4")
                    clientesFiltrados = clientesFiltrados.OrderBy(x => x.Idade).ToList<Cliente>();
            }
            else
            {
                if (iSortCol_0 == "0")
                    clientesFiltrados = clientesFiltrados.OrderByDescending(x => x.Id).ToList<Cliente>();
                if (iSortCol_0 == "1")
                    clientesFiltrados = clientesFiltrados.OrderByDescending(x => x.Nome).ToList<Cliente>();
                if (iSortCol_0 == "2")
                    clientesFiltrados = clientesFiltrados.OrderByDescending(x => x.Sexo).ToList<Cliente>();
                if (iSortCol_0 == "3")
                    clientesFiltrados = clientesFiltrados.OrderByDescending(x => x.Estado).ToList<Cliente>();
                if (iSortCol_0 == "4")
                    clientesFiltrados = clientesFiltrados.OrderByDescending(x => x.Idade).ToList<Cliente>();
            }



            return Json(
                new
                {
                    iTotalRecords = clientesCadastrados.Count,
                    iTotalDisplayRecords = clientesFiltrados.Count,
                    sEcho = echo,
                    aaData = clientesFiltrados.ToList<Cliente>().GetRange(startExibir, regExibir)
                });


        }



    }
}
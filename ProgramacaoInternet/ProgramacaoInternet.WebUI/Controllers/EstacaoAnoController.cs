using ProgramacaoInternet.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramacaoInternet.WebUI.Controllers
{
    public class EstacaoAnoController : Controller
    {
        private IEstacaoAnoRepository repository;
        public EstacaoAnoController(IEstacaoAnoRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List()
        {
            return View(repository.EstacoesAno);
        }
    }
}
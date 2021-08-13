using LanchesWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using LanchesWeb.ViewModels;

namespace LanchesWeb.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List() 
        {
            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categorias";

            // var lanches = _lancheRepository.Lanches;
            // return View(lanches);

            var LanchesListViewModel = new LancheListViewModel();
            LanchesListViewModel.Lanches = _lancheRepository.Lanches;
            LanchesListViewModel.CategoriaAtual = "CategoriaAtual";
            return View(LanchesListViewModel);
        }
    }
}

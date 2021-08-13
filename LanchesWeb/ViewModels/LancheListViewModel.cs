using LanchesWeb.Models;
using System.Collections.Generic;

namespace LanchesWeb.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; } 
    }
}

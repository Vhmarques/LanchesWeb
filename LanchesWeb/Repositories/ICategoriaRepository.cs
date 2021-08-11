using LanchesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesWeb.Repositories
{
    interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}

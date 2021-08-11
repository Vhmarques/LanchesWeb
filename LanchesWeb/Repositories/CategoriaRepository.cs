using LanchesWeb.Context;
using LanchesWeb.Models;
using System.Collections.Generic;

namespace LanchesWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context )
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}

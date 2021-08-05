﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesWeb.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string ImageThumbnailUrl { get; set; }
        public bool LanchePreferido { get; set; }
        public bool Estoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}

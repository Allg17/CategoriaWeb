using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categorias
    {
        [Key]
        public int Idcategoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Presupuesto { get; set; }

        public Categorias(int idcategoria, string descripcion, decimal presupuesto)
        {
            Idcategoria = idcategoria;
            Descripcion = descripcion;
            Presupuesto = presupuesto;
        }

        public Categorias()
        {
            Idcategoria = 0;
            Descripcion = string.Empty;
            Presupuesto = 0;
        }
    }
}

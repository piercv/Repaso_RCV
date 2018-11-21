using System.Collections.Generic;

namespace Repaso_RCV.Models
{
    public class Categoria
    {
        public int Id {get; set;}
        public string Nombre {get; set;}

        public string Descripcion {get; set;}

        public List<Producto> Productos {get; set;}

        public Categoria()
        {
            Productos = new List<Producto>();
        }
    }
}
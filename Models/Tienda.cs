using System.Collections.Generic;

namespace Repaso_RCV.Models
{
    public class Tienda
    {
        public int Id {get; set;}

        public string Nombre {get; set;}

        public string Descripcion {get; set;}

        //Para obtener los Productos por tienda
        public List<Producto> Productos { get; set; }

        public Tienda() {
            Productos = new List<Producto>();
        }
    }
}
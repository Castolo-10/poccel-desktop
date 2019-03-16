using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poccel_desktop
{
    class Producto
    {
        public Producto()
        {
            this.codigo = "";
            this.nombre = "";
            this.descripcion = "";
            this.precio = 0.00f;
            this.cantidad = 0;
            this.imagenB64 = "";
        }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
        public string imagenB64 { get; set; }

    }
}

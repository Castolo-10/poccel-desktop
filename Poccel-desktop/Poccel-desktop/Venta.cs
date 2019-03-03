using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poccel_desktop
{
    class Venta
    {
        public int idVenta { get; set; }
        public int idSucursal { get; set; }
        public int idEmpleado { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
    }
}

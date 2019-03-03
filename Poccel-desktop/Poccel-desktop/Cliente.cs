using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poccel_desktop
{
    class Cliente
    {
        public int idCliente { get; }
        public String correo { get; set; }
        public String contraseña { get; set; }
        public DateTime ferchaNacimiento { get; set; }
        public char sexo { get; set; }
        public String nombre { get; set; }
        public String aPaterno { get; set; }
        public String aMaterno { get; set; }
        public String calle { get; set; }
        public String numeroDom { get; set; }
        public String colonia { get; set; }
        public String ciudad { get; set; }
        public int cp { get; set; }

        public Cliente(int id, String c, String p, DateTime fn, char s, String n, String ap, String am, String ca, String nd, String co, String ci, int cp )
        {
            this.idCliente = id;
            this.correo = c;
            this.contraseña = p;
            this.ferchaNacimiento = fn;
            this.sexo = s;
            this.nombre = n;
            this.aPaterno = ap;
            this.aMaterno = am;
            this.calle = ca;
            this.numeroDom = nd;
            this.colonia = co;
            this.ciudad = ci;
            this.cp = cp;
        }

    }
}

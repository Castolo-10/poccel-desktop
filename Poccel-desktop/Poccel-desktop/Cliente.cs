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
        public string correo { get; set; }
        public string contraseña { get; set; }
        public DateTime ferchaNacimiento { get; set; }
        public char sexo { get; set; }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string calle { get; set; }
        public string numeroDom { get; set; }
        public string colonia { get; set; }
        public string ciudad { get; set; }
        public int cp { get; set; }
       
        public Cliente(int id, string c, string p, DateTime fn, char s, string n, string ap, string am, string ca, string nd, string co, string ci, int cp )
        {
            this.idCliente = id;
            this.correo = c.ToUpper();
            this.contraseña = p.ToUpper();
            this.ferchaNacimiento = fn;
            this.sexo = s;
            this.nombre = n.ToUpper();
            this.aPaterno = ap.ToUpper();
            this.aMaterno = am.ToUpper();
            this.calle = ca.ToUpper();
            this.numeroDom = nd.ToUpper();
            this.colonia = co.ToUpper();
            this.ciudad = ci.ToUpper();
            this.cp = cp;
        }

    }
}

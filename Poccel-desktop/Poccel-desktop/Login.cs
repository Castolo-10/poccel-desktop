using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ctrlDatos;

namespace Poccel_desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador form = new Administrador();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            ControlDatos.placeHolder_Leave((TextBox)sender);
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            ControlDatos.placeHolder_Enter((TextBox)sender);
        }
    }
}

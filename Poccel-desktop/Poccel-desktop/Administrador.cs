using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color Azul Poccel: System.Drawing.ColorTranslator.FromHtml("#0965B0");
//Color Amarillo Poccel: System.Drawing.ColorTranslator.FromHtml("#FEE40B");
//Color Gris Poccel: System.Drawing.ColorTranslator.FromHtml("#7E888F");
//Color Rojo Poccel: System.Drawing.ColorTranslator.FromHtml("#DF2F3B");



namespace Poccel_desktop
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            bloquearBoton(btnAgregar_Ventas);
            dtpFechaCliente.MaxDate = DateTime.Today;
            dtpFechaCliente.Value = DateTime.Today;
        }

        private void bloquearBoton(Button btn)
        {
            btn.Enabled = false;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#7E888F");
            btn.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Navegación entre pestañas

        private void actualizar_botones(object sender)
        {
            Button[] buttons = new Button[7] { btnAbonos, btnChat, btnClientes, btnConfiguracion, btnEmpleados, btnInventario, btnVentas};
            foreach(Button b in buttons)
            {
                if(sender == b)
                {
                    b.ForeColor = Color.Yellow;
                    b.BackColor = Color.Navy;
                }
                else
                {
                    b.ForeColor = Color.White;
                    b.BackColor = System.Drawing.ColorTranslator.FromHtml("#0965B0");

                }
            }

        }
        private void cambioMenu(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tabControlAdministrador.SelectedIndex = btn.TabIndex;
            actualizar_botones(sender);
            btn.Focus();

        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            VentaCredito form = new VentaCredito();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VentaContado form = new VentaContado();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AgregarProducto form = new AgregarProducto();
            form.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void txb_Leave(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(txb.Text == "")
            {
                Control.Text(txb, txb.Tag.ToString());
                Control.ForeColor(txb, Color.Silver);
            }
        }

        private void txb_Enter(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (txb.Text == txb.Tag.ToString())
            {
                Control.Text(txb, "");
                Control.ForeColor(txb, Color.Black);
            }
        }

        private void btnBuscar_Ventas_Click(object sender, EventArgs e)
        {
            Control.EnabledUnabled(btnCancelar_Ventas);
        }
    }
}

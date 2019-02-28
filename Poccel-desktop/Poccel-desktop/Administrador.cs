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
//Color Azul Poccel: System.Drawing.ColorTranslator.FromHtml("#FEE40B");
//Color Gris Poccel: System.Drawing.ColorTranslator.FromHtml("#7E888F");
//Color Rojo Poccel: System.Drawing.ColorTranslator.FromHtml("#DF2F3B");



namespace Poccel_desktop
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            bloquearBoton(btnAgregarVentas);
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

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 0;
            actualizar_botones(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 1;
            actualizar_botones(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 2;
            actualizar_botones(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 3;
            actualizar_botones(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 4;
            actualizar_botones(sender);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 5;
            actualizar_botones(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControlAdministrador.SelectedIndex = 6;
            actualizar_botones(sender);

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

    }
}

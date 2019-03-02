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
        private TextBox[] camposClientes;
        private TextBox[] camposEmpleados;

        public Administrador()
        {
            InitializeComponent();
            dtpFecha_Clientes.MaxDate = DateTime.Today;
            dtpFecha_Clientes.Value = DateTime.Today;

            camposClientes = new TextBox[]
            {
                txbNumero_Clientes, txbContraseña_Clientes, txbContraseñaRep_Clientes,
                txbNombre_Clientes, txbAPaterno_Clientes, txbAMaterno_Clientes,
                txbEmail_Clientes, txbTelefono_Clientes,
                txbCalle_Clientes, txbNumeroDom_Clientes, txbCiudad_Clientes, txbColonia_Clientes, txbCP_Clientes
            };
            camposEmpleados = new TextBox[]
            {
                txbNumero_Empleados, txbContraseña_Empleados, txbContraseñaRep_Empleados,
                txbNombre_Empleados, txbAPaterno_Empleados, txbAMaterno_Empleados,
                txbEmail_Empleados, txbTelefono_Empleados,
                txbCalle_Empleados, txbNumeroDom_Empleados, txbCiudad_Empleados, txbColonia_Empleados, txbCP_Empleados
            };
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
        #region PlaceHolder
        private void txb_Leave(object sender, EventArgs e)
        {
            Control.placeHolder_Leave((TextBox)sender);
        }

        private void txb_Enter(object sender, EventArgs e)
        {
            Control.placeHolder_Enter((TextBox)sender);
        }
        #endregion

        private void btnBuscar_Ventas_Click(object sender, EventArgs e)
        {
            ////Si Encuentra Cliente
            //Habilita botón cancelar ventaç
            btnCancelar_Ventas.Visible = true;
            Control.btnEnabled(btnCancelar_Ventas, "rojo");
            
            Control.btnEnabled(btnAgregar_Ventas, "azul");

            //Habilita botones

        }

        private void btnAgregar_Ventas_Click(object sender, EventArgs e)
        {
            //Si agrega un producto
            Control.btnEnabled(btnCredito_Ventas, "azul");
            Control.btnEnabled(btnContado_Ventas, "azul");
            Control.btnEnabled(btnEliminar_Ventas, "rojo");

        }

        private void btnBuscar_Clientes_Click(object sender, EventArgs e)
        {
            //Si encuentra cliente
            Control.btnEnabled(btnModificar_Clientes, "azul");
            Control.btnEnabled(btnBaja_Clientes, "rojo");

            //Inhabilita Campos
            foreach (TextBox txb in camposClientes)
            {
                txb.Enabled = false;
                Control.placeHolder_Enter(txb);
            }
        }

        private void btnBuscar_Abonos_Click(object sender, EventArgs e)
        {
            //Si encuentra Cliente y Tiene Cuentas
            Control.btnEnabled(btnAbonar_Abonos, "azul");
        }

        private void btnNuevo_Clientes_Click(object sender, EventArgs e)
        {
            //Habilita Campos
            foreach(TextBox txb in camposClientes)
            {
                txb.Enabled = true;
                txb.Text = "";
                Control.placeHolder_Leave(txb);
            }
            btnModificar_Clientes.Visible = false;
            btnBaja_Clientes.Visible = false;
            dtpFecha_Clientes.Enabled = true;
            cboxSexo_Clientes.Enabled = true;

        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //Si encuentra cliente
            Control.btnEnabled(btnModificar_Empleados, "azul");
            Control.btnEnabled(btnBaja_Empleados, "rojo");

            //Inhabilita Campos
            foreach (TextBox txb in camposEmpleados)
            {
                txb.Enabled = false;
                Control.placeHolder_Enter(txb);
            }

        }

        private void btnNuevo_Empleados_Click(object sender, EventArgs e)
        {
            //Habilita Campos
            foreach (TextBox txb in camposEmpleados)
            {
                txb.Enabled = true;
                txb.Text = "";
                Control.placeHolder_Leave(txb);
            }
            btnModificar_Empleados.Visible = false;
            btnBaja_Empleados.Visible = false;
            dtpFecha_Empleados.Enabled = true;
            cboxSexo_Empleados.Enabled = true;
        }
    }
}

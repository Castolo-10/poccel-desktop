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
using DataBase;

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
                txbContraseña_Clientes, txbContraseñaRep_Clientes,
                txbNombre_Clientes, txbAPaterno_Clientes, txbAMaterno_Clientes,
                txbEmail_Clientes, txbTelefono_Clientes,
                txbCalle_Clientes, txbNumeroDom_Clientes, txbCiudad_Clientes, txbColonia_Clientes, txbCP_Clientes
            };
            camposEmpleados = new TextBox[]
            {
                txbContraseña_Empleados, txbContraseñaRep_Empleados,
                txbNombre_Empleados, txbAPaterno_Empleados, txbAMaterno_Empleados,
                txbEmail_Empleados, txbTelefono_Empleados,
                txbCalle_Empleados, txbNumeroDom_Empleados, txbCiudad_Empleados, txbColonia_Empleados, txbCP_Empleados
            };
            foreach(TextBox tb in camposClientes)
            {
                toolTipMessage.SetToolTip(tb, tb.Tag.ToString().Split(',')[2]);
            }
            toolTipMessage.SetToolTip(txbBuscar_Clientes, "Ingresa el número de cliente a buscar");


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
            switch(btn.TabIndex)
            {
                case 0: cargarPaginaVentas(); break;
                case 1: break;
                case 2: cargarPaginaClientes(); break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
            }

        }
        #endregion

        #region Cargadores de Pestañas
        private void cargarPaginaClientes()
        {
            foreach (TextBox txb in camposClientes)
            {
                txb.Text = ("");
                ControlDatos.placeHolder_Leave(txb);
                txb.Enabled = false;
            }
            txbNumero_Clientes.Text = "Nº de Cliente";
            cboxSexo_Clientes.Enabled = false;
            dtpFecha_Clientes.Enabled = false;
        }
        private void cargarPaginaEmpleados()
        {
            foreach (TextBox txb in camposEmpleados)
            {
                txb.Text = ("");
                ControlDatos.placeHolder_Leave(txb);
                txb.Enabled = false;
            }
            txbNumero_Empleados.Text = "Nº de Cliente";
            cboxPuesto_Empleados.Enabled = false;
            cboxSexo_Empleados.Enabled = false;
            dtpFecha_Empleados.Enabled = false;

        }

        private void cargarPaginaVentas()
        {
            ControlDatos.btnUnabled(btnCancelar_Ventas, "rojo", false);
            ControlDatos.btnUnabled(btnContado_Ventas, "gris", true);
            ControlDatos.btnUnabled(btnCredito_Ventas, "gris", true);
            ControlDatos.btnUnabled(btnAgregar_Ventas, "gris", true);
            ControlDatos.btnUnabled(btnEliminar_Ventas, "rojo", false);
            ControlDatos.txbBorrar(txbProducto_Ventas);
            ControlDatos.txbBorrar(txbCantidad_Ventas);
            ControlDatos.txbBorrar(txbBuscar_Ventas);
            dgvProductos_Ventas.Rows.Clear();
            txbProducto_Ventas.Enabled = false;
            txbCantidad_Ventas.Enabled = false;
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
            ControlDatos.placeHolder_Leave((TextBox)sender);
        }

        private void txb_Enter(object sender, EventArgs e)
        {
            ControlDatos.placeHolder_Enter((TextBox)sender);
        }
        #endregion

        #region Pestaña Ventas

        private void actualizarBotones_Ventas(String str)
        {
            switch(str.ToLower())
            {
                case "cancelar":
                    cargarPaginaVentas(); break;
                case "buscar":
                    btnCancelar_Ventas.Visible = true;
                    ControlDatos.btnEnabled(btnCancelar_Ventas, "rojo");
                    ControlDatos.btnEnabled(btnAgregar_Ventas, "azul");
                    txbProducto_Ventas.Enabled = true;
                    txbCantidad_Ventas.Enabled = true;
                    



                    break;
            }
        }

        private void btnBuscar_Ventas_Click(object sender, EventArgs e)
        {
            ////Si Encuentra Cliente
            //Habilita botón cancelar ventaç
            actualizarBotones_Ventas("buscar");

            //Habilita botones

        }

        private void btnAgregar_Ventas_Click(object sender, EventArgs e)
        {
            //Si agrega un producto
            ControlDatos.txbBorrar(txbProducto_Ventas);
            ControlDatos.txbBorrar(txbCantidad_Ventas);
            ControlDatos.btnEnabled(btnCredito_Ventas, "azul");
            ControlDatos.btnEnabled(btnContado_Ventas, "azul");
            ControlDatos.btnEnabled(btnEliminar_Ventas, "rojo");

        }

        private void btnCancelar_Ventas_Click(object sender, EventArgs e)
        {
            actualizarBotones_Ventas("cancelar");
        }
        #endregion

        #region Pestaña Abonos
        private void btnBuscar_Abonos_Click(object sender, EventArgs e)
        {
            //Si encuentra Cliente y Tiene Cuentas
            ControlDatos.btnEnabled(btnAbonar_Abonos, "azul");
        }
        #endregion

        #region Pestaña Clientes

        private void actualizaBotones_Clientes(String str)
        {
            switch(str.ToLower())
            {
                case "buscar":
                    ControlDatos.Text(btnAceptarModificar_Clientes, "Modificar");
                    ControlDatos.Text(btnBajaCancelar_Clientes, "Dar de Baja");
                    ControlDatos.btnEnabled(btnAceptarModificar_Clientes, "azul");
                    ControlDatos.btnEnabled(btnBajaCancelar_Clientes, "rojo");
                    cboxSexo_Clientes.Enabled = false;
                    dtpFecha_Clientes.Enabled = false;
                    break;
                case "nuevo":
                    ControlDatos.Text(btnAceptarModificar_Clientes, "Aceptar");
                    ControlDatos.Text(btnBajaCancelar_Clientes, "Cancelar");
                    ControlDatos.btnEnabled(btnAceptarModificar_Clientes, "azul");
                    ControlDatos.btnEnabled(btnBajaCancelar_Clientes, "rojo");
                    cboxSexo_Clientes.Enabled = true;
                    dtpFecha_Clientes.Enabled = true;
                    break;
                case "ocultar":
                    ControlDatos.Text(btnAceptarModificar_Clientes, "boton");
                    ControlDatos.Text(btnBajaCancelar_Clientes, "boton");
                    ControlDatos.btnUnabled(btnAceptarModificar_Clientes, "azul", false);
                    ControlDatos.btnUnabled(btnBajaCancelar_Clientes, "rojo", false);
                    break;
            }

        }

        private void btnBuscar_Clientes_Click(object sender, EventArgs e)
        {
            //Si encuentra cliente
            actualizaBotones_Clientes("buscar");

            //Inhabilita Campos
            foreach (TextBox txb in camposClientes)
            {
                txb.Enabled = false;
                ControlDatos.placeHolder_Enter(txb);
            }
        }

        private void btnNuevo_Clientes_Click(object sender, EventArgs e)
        {
            //Habilita Campos
            foreach (TextBox txb in camposClientes)
            {
                txb.Enabled = true;
                txb.Text = "";
                ControlDatos.placeHolder_Leave(txb);
            }
            txbNumero_Clientes.Enabled = false;
            actualizaBotones_Clientes("nuevo");

            dtpFecha_Clientes.Enabled = true;
            cboxSexo_Clientes.Enabled = true;

            //Lee ID asignado del cliente
            txbNumero_Clientes.Text = BdConexion.consultar_datos("SELECT last_value FROM cliente_id_cliente_seq").Rows[0][0].ToString();
            
        }

        private void btnBajaCancelar_Clientes_Click(object sender, EventArgs e)
        {
            if (btnBajaCancelar_Clientes.Text == "Dar de Baja")
            {
            }
            else if (btnBajaCancelar_Clientes.Text == "Cancelar")
            {
            }
            cargarPaginaClientes();
            actualizaBotones_Clientes("ocultar");
        }

        private void btnAceptarModificar_Clientes_Click(object sender, EventArgs e)
        {
            if(btnAceptarModificar_Clientes.Text == "Aceptar")
            {
                bool error = false;
                error = ControlDatos.validar(camposClientes);
                if(dtpFecha_Clientes.Value == null || cboxSexo_Clientes.SelectedItem == null)
                {
                    error = true;
                }
                if(txbContraseña_Clientes.Text != txbContraseñaRep_Clientes.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    error = true;
                }
                if(error)
                {
                    MessageBox.Show("Existe algún error en el formulario o hace falta algún dato.");
                }
                else
                {
                    Cliente nuevo = new Cliente(
                        int.Parse(txbNumero_Clientes.Text), 
                        txbEmail_Clientes.Text, 
                        txbContraseña_Clientes.Text, 
                        dtpFecha_Clientes.Value, 
                        cboxSexo_Clientes.SelectedItem.ToString()[0],
                        txbNombre_Clientes.Text,
                        txbAPaterno_Clientes.Text,
                        txbAMaterno_Clientes.Text,
                        txbCalle_Clientes.Text,
                        txbNumeroDom_Clientes.Text,
                        txbColonia_Clientes.Text,
                        txbCiudad_Clientes.Text,
                        int.Parse(txbCP_Clientes.Text)
                        );

                    if(MessageBox.Show("¿Está seguro de agregar un nuevo cliente?","Está usted agregando un nuevo cliente.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //AgregarBD

                        MessageBox.Show($"Se agregó a {nuevo.nombre} {nuevo.aPaterno} {nuevo.aMaterno} con el número de cliente {nuevo.idCliente} exitosamente.");

                        cargarPaginaClientes();
                        actualizaBotones_Clientes("ocultar");
                    }
                }

            }
        }
        #endregion

        #region Pestaña Inventario
        #endregion

        #region Pestaña Empleados

        private void actualizaBotones_Empleados(String str)
        {
            switch (str.ToLower())
            {
                case "buscar":
                    ControlDatos.Text(btnAceptarModificar_Empleados, "Modificar");
                    ControlDatos.Text(btnBajaCancelar_Empleados, "Dar de Baja");
                    ControlDatos.btnEnabled(btnAceptarModificar_Empleados, "azul");
                    ControlDatos.btnEnabled(btnBajaCancelar_Empleados, "rojo");
                    cboxPuesto_Empleados.Enabled = false;
                    cboxSexo_Empleados.Enabled = false;
                    dtpFecha_Empleados.Enabled = false;
                    break;
                case "nuevo":
                    ControlDatos.Text(btnAceptarModificar_Empleados, "Aceptar");
                    ControlDatos.Text(btnBajaCancelar_Empleados, "Cancelar");
                    ControlDatos.btnEnabled(btnAceptarModificar_Empleados, "azul");
                    ControlDatos.btnEnabled(btnBajaCancelar_Empleados, "rojo");
                    cboxPuesto_Empleados.Enabled = true;
                    cboxSexo_Empleados.Enabled = true;
                    dtpFecha_Empleados.Enabled = true;
                    break;
                case "ocultar":
                    ControlDatos.Text(btnAceptarModificar_Empleados, "boton");
                    ControlDatos.Text(btnBajaCancelar_Empleados, "boton");
                    ControlDatos.btnUnabled(btnAceptarModificar_Empleados, "azul", false);
                    ControlDatos.btnUnabled(btnBajaCancelar_Empleados, "rojo", false);
                    break;
            }

        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //Si encuentra cliente
            actualizaBotones_Empleados("buscar");

            //Inhabilita Campos
            foreach (TextBox txb in camposEmpleados)
            {
                txb.Enabled = false;
                ControlDatos.placeHolder_Enter(txb);
            }

        }
        private void btnNuevo_Empleados_Click(object sender, EventArgs e)
        {
            //Habilita Campos
            foreach (TextBox txb in camposEmpleados)
            {
                txb.Enabled = true;
                txb.Text = "";
                ControlDatos.placeHolder_Leave(txb);
            }
            actualizaBotones_Empleados("nuevo");
        }
        private void btnBajaCancelar_Empleados_Click(object sender, EventArgs e)
        {
            actualizaBotones_Empleados("ocultar");
            cargarPaginaEmpleados();
        }
        #endregion

        #region Eventos validador de TextBox

        private void validarCampos(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            ControlDatos.validar(txb, txb.Tag.ToString().Split(',')[1]);
        }
        #endregion


    }
}

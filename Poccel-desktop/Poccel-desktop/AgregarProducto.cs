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
    public partial class AgregarProducto : Form
    {
        private Producto producto;
        private TextBox[] camposProducto;
        public AgregarProducto()
        {
            InitializeComponent();
            producto = new Producto();
            camposProducto = new TextBox[] { txbCodigoProducto, txbNombreProducto, txbDescripcionProducto, txbPrecioProducto, txbCantidadProducto };
            foreach(TextBox tb in camposProducto)
            {
                toolTipMensaje.SetToolTip(tb, tb.Tag.ToString().Split(',')[2]);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de Imágen(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pboxProducto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void PlaceHolder_Enter(object sender, EventArgs e)
        {
            ControlDatos.placeHolder_Enter((TextBox)sender);
        }
        private void PlaceHolder_Leave(object sender, EventArgs e)
        {
            ControlDatos.placeHolder_Leave((TextBox)sender);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = ControlDatos.validar(camposProducto);
            if(error || pboxProducto.Image == null)
            {
                MessageBox.Show("Existe un error en el formulario, o hace falta algún dato.");
            }
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void validarCampos(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            ControlDatos.validar(txb, txb.Tag.ToString().Split(',')[1]);
        }
    }
}

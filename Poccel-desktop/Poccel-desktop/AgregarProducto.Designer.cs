namespace Poccel_desktop
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbCantidadProducto = new System.Windows.Forms.TextBox();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.txbPrecioProducto = new System.Windows.Forms.TextBox();
            this.txbDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txbCodigoProducto = new System.Windows.Forms.TextBox();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.toolTipMensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbert DemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(170, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 30);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(176)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbert DemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(24, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 30);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbCantidadProducto
            // 
            this.txbCantidadProducto.Font = new System.Drawing.Font("Corbert DemiBold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidadProducto.ForeColor = System.Drawing.Color.Silver;
            this.txbCantidadProducto.Location = new System.Drawing.Point(24, 341);
            this.txbCantidadProducto.Name = "txbCantidadProducto";
            this.txbCantidadProducto.Size = new System.Drawing.Size(140, 30);
            this.txbCantidadProducto.TabIndex = 37;
            this.txbCantidadProducto.Tag = "Cantidad, numero, Inserte la cantidad de productos en inventario";
            this.txbCantidadProducto.Text = "Cantidad";
            this.txbCantidadProducto.Enter += new System.EventHandler(this.PlaceHolder_Enter);
            this.txbCantidadProducto.Leave += new System.EventHandler(this.PlaceHolder_Leave);
            this.txbCantidadProducto.Validated += new System.EventHandler(this.validarCampos);
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Font = new System.Drawing.Font("Corbert DemiBold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreProducto.ForeColor = System.Drawing.Color.Silver;
            this.txbNombreProducto.Location = new System.Drawing.Point(24, 83);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(286, 30);
            this.txbNombreProducto.TabIndex = 36;
            this.txbNombreProducto.Tag = "Nombre, alfanumerico, Inserte el nombre del producto";
            this.txbNombreProducto.Text = "Nombre";
            this.txbNombreProducto.Enter += new System.EventHandler(this.PlaceHolder_Enter);
            this.txbNombreProducto.Leave += new System.EventHandler(this.PlaceHolder_Leave);
            this.txbNombreProducto.Validated += new System.EventHandler(this.validarCampos);
            // 
            // txbPrecioProducto
            // 
            this.txbPrecioProducto.Font = new System.Drawing.Font("Corbert DemiBold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioProducto.ForeColor = System.Drawing.Color.Silver;
            this.txbPrecioProducto.Location = new System.Drawing.Point(24, 289);
            this.txbPrecioProducto.Name = "txbPrecioProducto";
            this.txbPrecioProducto.Size = new System.Drawing.Size(140, 30);
            this.txbPrecioProducto.TabIndex = 35;
            this.txbPrecioProducto.Tag = "Precio, moneda, Inserte el precio del producto con dos decimales";
            this.txbPrecioProducto.Text = "Precio";
            this.txbPrecioProducto.Enter += new System.EventHandler(this.PlaceHolder_Enter);
            this.txbPrecioProducto.Leave += new System.EventHandler(this.PlaceHolder_Leave);
            this.txbPrecioProducto.Validated += new System.EventHandler(this.validarCampos);
            // 
            // txbDescripcionProducto
            // 
            this.txbDescripcionProducto.Font = new System.Drawing.Font("Corbert DemiBold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcionProducto.ForeColor = System.Drawing.Color.Silver;
            this.txbDescripcionProducto.Location = new System.Drawing.Point(24, 135);
            this.txbDescripcionProducto.Multiline = true;
            this.txbDescripcionProducto.Name = "txbDescripcionProducto";
            this.txbDescripcionProducto.Size = new System.Drawing.Size(286, 132);
            this.txbDescripcionProducto.TabIndex = 34;
            this.txbDescripcionProducto.Tag = "Descripción, alfanumerico, Inserte la descripción del producto";
            this.txbDescripcionProducto.Text = "Descripción";
            this.txbDescripcionProducto.Enter += new System.EventHandler(this.PlaceHolder_Enter);
            this.txbDescripcionProducto.Leave += new System.EventHandler(this.PlaceHolder_Leave);
            this.txbDescripcionProducto.Validated += new System.EventHandler(this.validarCampos);
            // 
            // txbCodigoProducto
            // 
            this.txbCodigoProducto.Font = new System.Drawing.Font("Corbert DemiBold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoProducto.ForeColor = System.Drawing.Color.Silver;
            this.txbCodigoProducto.Location = new System.Drawing.Point(24, 31);
            this.txbCodigoProducto.Name = "txbCodigoProducto";
            this.txbCodigoProducto.Size = new System.Drawing.Size(286, 30);
            this.txbCodigoProducto.TabIndex = 38;
            this.txbCodigoProducto.Tag = "Código, alfanumerico, Inserte el código del producto";
            this.txbCodigoProducto.Text = "Código";
            this.txbCodigoProducto.Enter += new System.EventHandler(this.PlaceHolder_Enter);
            this.txbCodigoProducto.Leave += new System.EventHandler(this.PlaceHolder_Leave);
            this.txbCodigoProducto.Validated += new System.EventHandler(this.validarCampos);
            // 
            // pboxProducto
            // 
            this.pboxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxProducto.Location = new System.Drawing.Point(335, 31);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(163, 208);
            this.pboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProducto.TabIndex = 39;
            this.pboxProducto.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(101)))), ((int)(((byte)(176)))));
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Corbert DemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(346, 245);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(140, 30);
            this.btnExaminar.TabIndex = 40;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // AgregarProducto
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pboxProducto);
            this.Controls.Add(this.txbCodigoProducto);
            this.Controls.Add(this.txbCantidadProducto);
            this.Controls.Add(this.txbNombreProducto);
            this.Controls.Add(this.txbPrecioProducto);
            this.Controls.Add(this.txbDescripcionProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbCantidadProducto;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.TextBox txbPrecioProducto;
        private System.Windows.Forms.TextBox txbDescripcionProducto;
        private System.Windows.Forms.TextBox txbCodigoProducto;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.ToolTip toolTipMensaje;
    }
}
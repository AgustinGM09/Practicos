namespace Practico2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMastercard = new System.Windows.Forms.CheckBox();
            this.checkBoxVisa = new System.Windows.Forms.CheckBox();
            this.checkBoxNaranja = new System.Windows.Forms.CheckBox();
            this.LTarjetaCredito = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.radioButtonVaron = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.labelNuevoCliente = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LDni.Location = new System.Drawing.Point(75, 152);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(35, 16);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "*DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LNombre.Location = new System.Drawing.Point(75, 193);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(61, 16);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "*Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LApellido.Location = new System.Drawing.Point(74, 233);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(62, 16);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "*Apellido";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LNya.Location = new System.Drawing.Point(75, 92);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(119, 16);
            this.LNya.TabIndex = 3;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(228, 92);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(139, 117);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 22);
            this.TNombre.TabIndex = 6;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(139, 160);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 22);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(139, 79);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 22);
            this.TDni.TabIndex = 10;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.checkBoxMastercard);
            this.panel1.Controls.Add(this.checkBoxVisa);
            this.panel1.Controls.Add(this.checkBoxNaranja);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LTarjetaCredito);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Location = new System.Drawing.Point(66, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 335);
            this.panel1.TabIndex = 11;
            // 
            // checkBoxMastercard
            // 
            this.checkBoxMastercard.AutoSize = true;
            this.checkBoxMastercard.Location = new System.Drawing.Point(142, 301);
            this.checkBoxMastercard.Name = "checkBoxMastercard";
            this.checkBoxMastercard.Size = new System.Drawing.Size(97, 20);
            this.checkBoxMastercard.TabIndex = 5;
            this.checkBoxMastercard.Text = "Mastercard";
            this.checkBoxMastercard.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            this.checkBoxVisa.AutoSize = true;
            this.checkBoxVisa.Location = new System.Drawing.Point(142, 274);
            this.checkBoxVisa.Name = "checkBoxVisa";
            this.checkBoxVisa.Size = new System.Drawing.Size(56, 20);
            this.checkBoxVisa.TabIndex = 4;
            this.checkBoxVisa.Text = "Visa";
            this.checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaranja
            // 
            this.checkBoxNaranja.AutoSize = true;
            this.checkBoxNaranja.Location = new System.Drawing.Point(142, 247);
            this.checkBoxNaranja.Name = "checkBoxNaranja";
            this.checkBoxNaranja.Size = new System.Drawing.Size(77, 20);
            this.checkBoxNaranja.TabIndex = 3;
            this.checkBoxNaranja.Text = "Naranja";
            this.checkBoxNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjetaCredito
            // 
            this.LTarjetaCredito.AutoSize = true;
            this.LTarjetaCredito.Location = new System.Drawing.Point(9, 247);
            this.LTarjetaCredito.Name = "LTarjetaCredito";
            this.LTarjetaCredito.Size = new System.Drawing.Size(116, 16);
            this.LTarjetaCredito.TabIndex = 2;
            this.LTarjetaCredito.Text = "Tarjeta de credito:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(9, 200);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(61, 16);
            this.LTelefono.TabIndex = 0;
            this.LTelefono.Text = "Telefono";
            // 
            // radioButtonVaron
            // 
            this.radioButtonVaron.AutoSize = true;
            this.radioButtonVaron.Checked = true;
            this.radioButtonVaron.Location = new System.Drawing.Point(397, 316);
            this.radioButtonVaron.Name = "radioButtonVaron";
            this.radioButtonVaron.Size = new System.Drawing.Size(64, 20);
            this.radioButtonVaron.TabIndex = 13;
            this.radioButtonVaron.TabStop = true;
            this.radioButtonVaron.Text = "Varón";
            this.radioButtonVaron.UseVisualStyleBackColor = true;
            this.radioButtonVaron.CheckedChanged += new System.EventHandler(this.radioButtonVaron_CheckedChanged);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(536, 318);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(61, 20);
            this.radioButtonMujer.TabIndex = 14;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // labelNuevoCliente
            // 
            this.labelNuevoCliente.AutoSize = true;
            this.labelNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNuevoCliente.Location = new System.Drawing.Point(226, 20);
            this.labelNuevoCliente.Name = "labelNuevoCliente";
            this.labelNuevoCliente.Size = new System.Drawing.Size(178, 29);
            this.labelNuevoCliente.TabIndex = 16;
            this.labelNuevoCliente.Text = "Nuevo Cliente";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Image = global::Practico2.Properties.Resources.salir50x50_1_;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalir.Location = new System.Drawing.Point(501, 435);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(96, 91);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico2.Properties.Resources.varon200x200;
            this.pictureBox1.Location = new System.Drawing.Point(397, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BEliminar.Location = new System.Drawing.Point(241, 435);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(92, 91);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BGuardar.Location = new System.Drawing.Point(66, 435);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(87, 91);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 543);
            this.ControlBox = false;
            this.Controls.Add(this.labelNuevoCliente);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.radioButtonMujer);
            this.Controls.Add(this.radioButtonVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTarjetaCredito;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxMastercard;
        private System.Windows.Forms.CheckBox checkBoxVisa;
        private System.Windows.Forms.CheckBox checkBoxNaranja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonVaron;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelNuevoCliente;
    }
}


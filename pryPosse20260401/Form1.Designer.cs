namespace pryPosse20260401
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
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCargaDatos = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mtbStock = new System.Windows.Forms.MaskedTextBox();
            this.lblRegistroIG = new System.Windows.Forms.Label();
            this.lblRegVariables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(31, 61);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(59, 16);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombre ";
            this.lblNombreP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(31, 114);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(256, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción ";
            // 
            // lblCargaDatos
            // 
            this.lblCargaDatos.AutoSize = true;
            this.lblCargaDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaDatos.Location = new System.Drawing.Point(179, 9);
            this.lblCargaDatos.Name = "lblCargaDatos";
            this.lblCargaDatos.Size = new System.Drawing.Size(159, 20);
            this.lblCargaDatos.TabIndex = 3;
            this.lblCargaDatos.Text = "Gestión de inventario";
            this.lblCargaDatos.Click += new System.EventHandler(this.lblCargaDatos_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(31, 180);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(256, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(361, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(138, 60);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(99, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(220, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 34);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(399, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(256, 183);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoría";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "pan ",
            "queso",
            "pan",
            "queso",
            "pan"});
            this.cmbCategoria.Location = new System.Drawing.Point(361, 178);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(138, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.Location = new System.Drawing.Point(99, 110);
            this.mtbCodigo.Mask = "999999";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(100, 20);
            this.mtbCodigo.TabIndex = 1;
            this.mtbCodigo.ValidatingType = typeof(int);
            this.mtbCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigo_MaskInputRejected);
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(361, 131);
            this.mtbPrecio.Mask = "999999";
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(138, 20);
            this.mtbPrecio.TabIndex = 4;
            this.mtbPrecio.ValidatingType = typeof(int);
            this.mtbPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPrecio_MaskInputRejected);
            // 
            // mtbStock
            // 
            this.mtbStock.Location = new System.Drawing.Point(99, 176);
            this.mtbStock.Mask = "999999";
            this.mtbStock.Name = "mtbStock";
            this.mtbStock.Size = new System.Drawing.Size(100, 20);
            this.mtbStock.TabIndex = 2;
            this.mtbStock.ValidatingType = typeof(int);
            this.mtbStock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbStock_MaskInputRejected);
            // 
            // lblRegistroIG
            // 
            this.lblRegistroIG.AutoSize = true;
            this.lblRegistroIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroIG.Location = new System.Drawing.Point(70, 322);
            this.lblRegistroIG.Name = "lblRegistroIG";
            this.lblRegistroIG.Size = new System.Drawing.Size(12, 18);
            this.lblRegistroIG.TabIndex = 20;
            this.lblRegistroIG.Text = ".";
            this.lblRegistroIG.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRegVariables
            // 
            this.lblRegVariables.AutoSize = true;
            this.lblRegVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegVariables.Location = new System.Drawing.Point(396, 322);
            this.lblRegVariables.Name = "lblRegVariables";
            this.lblRegVariables.Size = new System.Drawing.Size(12, 18);
            this.lblRegVariables.TabIndex = 21;
            this.lblRegVariables.Text = ".";
            this.lblRegVariables.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegVariables);
            this.Controls.Add(this.lblRegistroIG);
            this.Controls.Add(this.mtbStock);
            this.Controls.Add(this.mtbPrecio);
            this.Controls.Add(this.mtbCodigo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCargaDatos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombreP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCargaDatos;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbStock;
        private System.Windows.Forms.Label lblRegistroIG;
        private System.Windows.Forms.Label lblRegVariables;
    }
}


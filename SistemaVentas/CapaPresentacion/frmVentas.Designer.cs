namespace CapaPresentacion
{
    partial class frmVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtidproducto = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtstock = new TextBox();
            txtprecio = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtcantidad = new NumericUpDown();
            label7 = new Label();
            btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtidcliente = new TextBox();
            label5 = new Label();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            txttotalapagar = new TextBox();
            label12 = new Label();
            txtcambio = new TextBox();
            label2 = new Label();
            label13 = new Label();
            txtpagacon = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 10, 0, 0);
            label1.Size = new Size(973, 511);
            label1.TabIndex = 22;
            label1.Text = "Registrar Venta";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(123, 22);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(32, 23);
            txtidproducto.TabIndex = 26;
            txtidproducto.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(668, 33);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 30;
            label11.Text = "Cantidad: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(563, 33);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 29;
            label10.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 33);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 26;
            label9.Text = "Precio: ";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(563, 51);
            txtstock.Name = "txtstock";
            txtstock.ReadOnly = true;
            txtstock.Size = new Size(92, 23);
            txtstock.TabIndex = 28;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(465, 51);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(92, 23);
            txtprecio.TabIndex = 26;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.White;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.ForeColor = Color.Black;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 16;
            btnbuscarproducto.Location = new Point(174, 51);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(44, 23);
            btnbuscarproducto.TabIndex = 27;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(224, 51);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(226, 23);
            txtproducto.TabIndex = 3;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(6, 51);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(162, 23);
            txtcodproducto.TabIndex = 2;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 33);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 0;
            label8.Text = "Cod. Producto:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtstock);
            groupBox3.Controls.Add(txtprecio);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(85, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(802, 96);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de producto";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(668, 51);
            txtcantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(88, 23);
            txtcantidad.TabIndex = 31;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(224, 33);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.BackColor = Color.White;
            btnbuscarcliente.Cursor = Cursors.Hand;
            btnbuscarcliente.FlatAppearance.BorderColor = Color.Black;
            btnbuscarcliente.FlatStyle = FlatStyle.Flat;
            btnbuscarcliente.ForeColor = Color.Black;
            btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarcliente.IconColor = Color.Black;
            btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcliente.IconSize = 16;
            btnbuscarcliente.Location = new Point(226, 54);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(44, 23);
            btnbuscarcliente.TabIndex = 26;
            btnbuscarcliente.UseVisualStyleBackColor = false;
            btnbuscarcliente.Click += btnbuscarproveedor_Click;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(286, 54);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(233, 23);
            txtnombrecliente.TabIndex = 3;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(6, 55);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(201, 23);
            txtdoccliente.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 37);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 0;
            label6.Text = "Número de Documento";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidcliente);
            groupBox2.Controls.Add(btnbuscarcliente);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(483, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 96);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de cliente";
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(487, 25);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(32, 23);
            txtidcliente.TabIndex = 25;
            txtidcliente.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 36);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 1;
            label5.Text = "Nombre Completo:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(189, 51);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(197, 23);
            cbotipodocumento.TabIndex = 24;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(6, 51);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(162, 23);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 33);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(85, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 96);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de venta";
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.BackColor = SystemColors.Control;
            btnagregarproducto.Cursor = Cursors.Hand;
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregarproducto.IconColor = Color.ForestGreen;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(903, 164);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(105, 86);
            btnagregarproducto.TabIndex = 29;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = false;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, Subtotal, btneliminar });
            dgvdata.Location = new Point(85, 256);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(802, 250);
            dgvdata.TabIndex = 30;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 30;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(893, 297);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.ReadOnly = true;
            txttotalapagar.Size = new Size(100, 23);
            txttotalapagar.TabIndex = 33;
            txttotalapagar.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(893, 279);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 32;
            label12.Text = "Total a Pagar:";
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(893, 418);
            txtcambio.Name = "txtcambio";
            txtcambio.ReadOnly = true;
            txtcambio.Size = new Size(100, 23);
            txtcambio.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(893, 400);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 34;
            label2.Text = "Cambio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(893, 342);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 36;
            label13.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            txtpagacon.Location = new Point(893, 360);
            txtpagacon.Name = "txtpagacon";
            txtpagacon.Size = new Size(100, 23);
            txtpagacon.TabIndex = 37;
            txtpagacon.KeyDown += txtpagacon_KeyDown;
            txtpagacon.KeyPress += txtpagacon_KeyPress;
            // 
            // btnregistrar
            // 
            btnregistrar.Cursor = Cursors.Hand;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = SystemColors.Highlight;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 27;
            btnregistrar.Location = new Point(893, 463);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(100, 43);
            btnregistrar.TabIndex = 38;
            btnregistrar.Text = "Crear Venta";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 607);
            Controls.Add(btnregistrar);
            Controls.Add(txtpagacon);
            Controls.Add(label13);
            Controls.Add(txtcambio);
            Controls.Add(label2);
            Controls.Add(txttotalapagar);
            Controls.Add(label12);
            Controls.Add(dgvdata);
            Controls.Add(btnagregarproducto);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtidproducto;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtstock;
        private TextBox txtprecio;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox txtcodproducto;
        private Label label8;
        private GroupBox groupBox3;
        private NumericUpDown txtcantidad;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtidcliente;
        private Label label5;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btneliminar;
        private TextBox txttotalapagar;
        private Label label12;
        private TextBox txtcambio;
        private Label label2;
        private Label label13;
        private TextBox txtpagacon;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}
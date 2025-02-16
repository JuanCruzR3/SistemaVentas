namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            label10 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            label1 = new Label();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtnumerodocumento = new TextBox();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtmontototal = new TextBox();
            label12 = new Label();
            btnexpotar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(74, 9);
            label10.Name = "label10";
            label10.Padding = new Padding(2, 0, 0, 0);
            label10.Size = new Size(853, 506);
            label10.TabIndex = 21;
            label10.Text = "Detalle Compra";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(656, 22);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(89, 23);
            btnbuscar.TabIndex = 64;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Black;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(751, 22);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(89, 23);
            btnlimpiarbuscador.TabIndex = 65;
            btnlimpiarbuscador.Text = "Limpiar";
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(469, 22);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(181, 23);
            txtbusqueda.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(370, 30);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 62;
            label11.Text = "Nro Documento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(162, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 84);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de compra";
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(189, 36);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(226, 23);
            txttipodocumento.TabIndex = 27;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(447, 36);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(196, 23);
            txtusuario.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 25;
            label1.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(6, 36);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(162, 23);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 18);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(604, 40);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(62, 23);
            txtnumerodocumento.TabIndex = 25;
            txtnumerodocumento.Visible = false;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(229, 40);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.ReadOnly = true;
            txtnombreproveedor.Size = new Size(233, 23);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(6, 40);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.ReadOnly = true;
            txtdocproveedor.Size = new Size(207, 23);
            txtdocproveedor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 22);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Razón Social:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 0;
            label6.Text = "Número de Documento";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(162, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(678, 88);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de proveedor";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, Subtotal });
            dgvdata.Location = new Point(162, 247);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(678, 211);
            dgvdata.TabIndex = 68;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 150;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 180;
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
            // txtmontototal
            // 
            txtmontototal.Location = new Point(242, 470);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(100, 23);
            txtmontototal.TabIndex = 70;
            txtmontototal.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(162, 473);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 69;
            label12.Text = "Monto Total:";
            // 
            // btnexpotar
            // 
            btnexpotar.BackColor = SystemColors.Control;
            btnexpotar.Cursor = Cursors.Hand;
            btnexpotar.FlatAppearance.BorderColor = Color.Black;
            btnexpotar.FlatStyle = FlatStyle.Flat;
            btnexpotar.ForeColor = Color.Black;
            btnexpotar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnexpotar.IconColor = SystemColors.ControlDarkDark;
            btnexpotar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexpotar.IconSize = 16;
            btnexpotar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexpotar.Location = new Point(668, 464);
            btnexpotar.Name = "btnexpotar";
            btnexpotar.Size = new Size(172, 29);
            btnexpotar.TabIndex = 71;
            btnexpotar.Text = "Descargar en PDF";
            btnexpotar.UseVisualStyleBackColor = false;
            btnexpotar.Click += btnexpotar_Click;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 593);
            Controls.Add(btnexpotar);
            Controls.Add(txtmontototal);
            Controls.Add(label12);
            Controls.Add(dgvdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(label11);
            Controls.Add(label10);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox txtusuario;
        private Label label1;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private TextBox txttipodocumento;
        private TextBox txtnumerodocumento;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox txtmontototal;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnexpotar;
    }
}
namespace CapaPresentacion
{
    partial class frmNegocio
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
            label9 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtdireccion = new TextBox();
            txtruc = new TextBox();
            txtnombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnsubir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            piclogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(22, 19);
            label9.Name = "label9";
            label9.Size = new Size(158, 23);
            label9.TabIndex = 20;
            label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(548, 506);
            label1.TabIndex = 19;
            label1.Text = "Detalle Negocio";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnsubir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(22, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 229);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = SystemColors.Control;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Folder;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 16;
            btnguardar.Location = new Point(210, 177);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(253, 23);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar Cambios";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(210, 139);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(253, 23);
            txtdireccion.TabIndex = 8;
            // 
            // txtruc
            // 
            txtruc.Location = new Point(210, 95);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(253, 23);
            txtruc.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(210, 51);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(253, 23);
            txtnombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 121);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 5;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 77);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "R.U.C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 33);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Negocio:";
            // 
            // btnsubir
            // 
            btnsubir.BackColor = SystemColors.Control;
            btnsubir.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnsubir.IconColor = Color.Black;
            btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsubir.IconSize = 16;
            btnsubir.Location = new Point(26, 177);
            btnsubir.Name = "btnsubir";
            btnsubir.Size = new Size(132, 23);
            btnsubir.TabIndex = 2;
            btnsubir.Text = "Subir Imagen";
            btnsubir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsubir.UseVisualStyleBackColor = false;
            btnsubir.Click += btnsubir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo:";
            // 
            // piclogo
            // 
            piclogo.BorderStyle = BorderStyle.FixedSingle;
            piclogo.Location = new Point(26, 37);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(132, 125);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 506);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox piclogo;
        private FontAwesome.Sharp.IconButton btnsubir;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txtdireccion;
        private TextBox txtruc;
        private TextBox txtnombre;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
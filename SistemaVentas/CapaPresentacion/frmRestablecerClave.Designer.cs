namespace CapaPresentacion
{
    partial class frmRestablecerClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestablecerClave));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnFin = new FontAwesome.Sharp.IconButton();
            btnRestablecer = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtDocumento = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(378, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(221, 9);
            label5.Name = "label5";
            label5.Size = new Size(224, 21);
            label5.TabIndex = 21;
            label5.Text = "RESTABLECER CONTRASEÑA";
            // 
            // btnFin
            // 
            btnFin.BackColor = Color.Firebrick;
            btnFin.Cursor = Cursors.Hand;
            btnFin.FlatAppearance.BorderColor = Color.Black;
            btnFin.FlatStyle = FlatStyle.Flat;
            btnFin.ForeColor = Color.White;
            btnFin.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            btnFin.IconColor = Color.White;
            btnFin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFin.IconSize = 21;
            btnFin.Location = new Point(221, 150);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(132, 41);
            btnFin.TabIndex = 20;
            btnFin.Text = "Finalizar Proceso";
            btnFin.TextAlign = ContentAlignment.MiddleRight;
            btnFin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFin.UseVisualStyleBackColor = false;
            btnFin.Click += btnFin_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = Color.RoyalBlue;
            btnRestablecer.Cursor = Cursors.Hand;
            btnRestablecer.FlatAppearance.BorderColor = Color.Black;
            btnRestablecer.FlatStyle = FlatStyle.Flat;
            btnRestablecer.ForeColor = Color.White;
            btnRestablecer.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnRestablecer.IconColor = Color.White;
            btnRestablecer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestablecer.IconSize = 21;
            btnRestablecer.Location = new Point(221, 92);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(112, 41);
            btnRestablecer.TabIndex = 19;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.TextAlign = ContentAlignment.MiddleRight;
            btnRestablecer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestablecer.UseVisualStyleBackColor = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 36);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 17;
            label3.Text = "Nro Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(221, 54);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(204, 23);
            txtDocumento.TabIndex = 15;
            txtDocumento.KeyPress += textBoxNumeros_KeyPress;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 115;
            iconPictureBox1.Location = new Point(41, 30);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(115, 115);
            iconPictureBox1.TabIndex = 14;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 13;
            label2.Text = "SUPER PRIMAVERA";
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 245);
            label1.TabIndex = 12;
            // 
            // frmRestablecerClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 245);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(btnFin);
            Controls.Add(btnRestablecer);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRestablecerClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRestablecerClave";
            Load += frmRestablecerClave_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnFin;
        private FontAwesome.Sharp.IconButton btnRestablecer;
        private Label label3;
        private TextBox txtDocumento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label1;
    }
}
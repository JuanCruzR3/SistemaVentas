namespace CapaPresentacion.Modales
{
    partial class mdAcercade
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 286);
            label1.Name = "label1";
            label1.Size = new Size(247, 15);
            label1.TabIndex = 0;
            label1.Text = "Sistema desarrollado por Juan Cruz Rodriguez\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(345, 54);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Gestión de Supermercados\r\n\r\nSuper Primavera\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 84);
            label3.Name = "label3";
            label3.Size = new Size(447, 80);
            label3.TabIndex = 2;
            label3.Text = "Sistema desarrollado para el supermercado \"SUPER PRIMAVERA\". \r\nSistema ABM con posibilidad de registrar ventas, compras,\r\nproveedores, productos, clientes y usuarios \r\n(en caso de ser ADMIN), \r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2, 176);
            label4.Name = "label4";
            label4.Size = new Size(369, 80);
            label4.TabIndex = 3;
            label4.Text = "Este sistema también ha sido desarrollado con el fin \r\nde rendir ingeniería de software y trabajo de diploma \r\nen la UAI (Universidad Abierta Interamericana) \r\n\r\n";
            // 
            // mdAcercade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 329);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "mdAcercade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdAcercade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
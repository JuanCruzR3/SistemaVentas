using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRestablecerClave : Form
    {
        public frmRestablecerClave()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuario.RestablecerClave(txtDocumento.Text);
                MessageBox.Show("La nueva clave ha sido enviada al correo del usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmRestablecerClave_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Login newForm = new Login(); 
            newForm.Show();
            this.Close(); 
        }
    }
}

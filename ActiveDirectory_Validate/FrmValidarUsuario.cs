using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveDirectory_Validate
{
    public partial class FrmValidarUsuario : Form
    {
        public FrmValidarUsuario()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string domain = txtDominio.Text;
                string username = txtUsuario.Text;
                string password = txtContraseña.Text;

                bool isValid = ActiveDirectoryHelper.ValidateUser(domain, username, password);

                if (isValid)
                {
                    txtResultado.Text = "Usuario y contraseña válidos.";
                    txtResultado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtResultado.Text = "Usuario o contraseña inválidos.";
                    txtResultado.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = ex.Message;
            }
        }
    }
}

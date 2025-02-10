using ActiveDirectory_Validate.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ActiveDirectory_Validate
{
    public partial class FrmValidarUsuario : Form
    {
        private byte[] _archivoDetalle;

        public FrmValidarUsuario()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string domain = txtDominio.Text;
                string usernameAdmin = txtUsuario.Text;
                string passwordAdmin = txtContraseña.Text;
                string username = txtUsuario.Text;
                string password = txtContraseña.Text;

                ActiveDirectoryHelper Adh = new ActiveDirectoryHelper(domain, usernameAdmin, passwordAdmin);

                bool isValid = Adh.ValidateUser(domain, username, password);

                if (isValid)
                {
                    txtResultado.Text = "Usuario y contraseña válidos.";
                    txtResultado.ForeColor = System.Drawing.Color.Green;

                    UserPrincipal user = Adh.GetUserInformation(username);

                    if (user != null)
                    {
                        var s0 = $"Account Name: {user.SamAccountName}";
                        var s1 = $"Display Name: {user.DisplayName}";
                        var s2 = $"Email: {user.EmailAddress}";
                        var s3 = $"Account Status: {(user.Enabled.HasValue && user.Enabled.Value ? "Enabled" : "Disabled")}";
                        var s4 = $"Last Logon: {user.LastLogon}";
                        var s5 = $"Date Account Expiration: {(user.AccountExpirationDate.HasValue ? user.AccountExpirationDate.ToString() : string.Empty)}";

                        txtInformacion.Text = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}", s0, s1, s2, s3, s4, s5);
                    }
                }
                else
                {
                    txtResultado.Text = "Usuario o contraseña inválidos.";
                    txtResultado.ForeColor = System.Drawing.Color.Red;
                    txtInformacion.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = ex.Message;
            }
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            string domain = txtDominio.Text;
            string usernameAdmin = txtAdminUser.Text;
            string passwordAdmin = txtAdminPassword.Text;
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            ActiveDirectoryHelper Adh = new ActiveDirectoryHelper(domain, usernameAdmin, passwordAdmin);

            List<UserPrincipal> users = Adh.GetAllUsers(domain);

            if (users != null && users.Count() > 0)
            {
                DataTable tablaUsers = new DataTable();
                tablaUsers.Columns.Add(new DataColumn(gcAccountName.FieldName, typeof(string)));
                tablaUsers.Columns.Add(new DataColumn(gcDisplayName.FieldName, typeof(string)));
                tablaUsers.Columns.Add(new DataColumn(gcEmail.FieldName, typeof(string)));
                tablaUsers.Columns.Add(new DataColumn(gcStatus.FieldName, typeof(bool)));
                tablaUsers.Columns.Add(new DataColumn(gcLastLogon.FieldName, typeof(string)));


                foreach (var user in users)
                {
                    DataRow row = tablaUsers.NewRow();
                    row[gcAccountName.FieldName] = user.SamAccountName;
                    row[gcDisplayName.FieldName] = user.DisplayName;
                    row[gcEmail.FieldName] = user.EmailAddress;
                    row[gcStatus.FieldName] = (user.Enabled.HasValue && user.Enabled.Value ? true : false);
                    row[gcLastLogon.FieldName] = user.LastLogon;
                    tablaUsers.Rows.Add(row);
                }

                gvUsers.DataSource = tablaUsers;
                gvUsers.ResetBindings();

            }
            else
            {
                gvUsers.DataSource = null;
                gvUsers.ResetBindings();
            }



        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "GIF files (*.gif)|*.gif|All files (*.*)|*.*";
                    openFileDialog.Title = "Select a GIF file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox2.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}

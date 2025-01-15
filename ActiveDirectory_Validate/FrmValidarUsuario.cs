using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                    UserPrincipal user = ActiveDirectoryHelper.GetUserInformation(domain, username, password);

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
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            List<UserPrincipal> users = ActiveDirectoryHelper.GetAllUsers(domain, username, password);

            if(users != null && users.Count() > 0)
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
    }
}

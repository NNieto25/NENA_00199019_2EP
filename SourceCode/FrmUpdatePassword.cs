using System;
using System.Windows.Forms;
using LiveCharts;

namespace SourceCode
{
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
        {
            InitializeComponent();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("")|| txtCurrentPassword.Text.Equals("") || txtNewPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los campos", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    User user = UserDAO.VerifyUser(txtUsername.Text, txtCurrentPassword.Text);
                    UserDAO.UpdatePassword(user, txtNewPassword.Text);
                    MessageBox.Show("La contraseña se ha actualizado con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error. Revise los campos.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmUpdatePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmUpdatePassword updatePassword = new FrmUpdatePassword();
            updatePassword.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe rellenar los campos.", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    User loginUser = UserDAO.VerifyUser(txtUsername.Text, txtPassword.Text);
                    if (loginUser.UserType) //Si el usuario es administrador
                    {
                       frmAdmin formAdmin = new frmAdmin();
                       formAdmin.Show();
                    }
                    else
                    {
                        FrmUser formUser = new FrmUser(loginUser);
                        formUser.Show();
                    }
                    Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("El usuario no existe. Revise sus credenciales.", "Hugo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
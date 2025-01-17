using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prg282Project.DataLayer;

namespace Prg282Project
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();

            this.ControlBox = false; // Removes top exit, minimize and maximize
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            FileHandler.CreateLoginTxt();
            this.UserName.Text = ""; // Clear the username field
            this.Password.Text = ""; // Clear the password field
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            string userNameValidate = UserName.Text;
            string passwordValidate = Password.Text;

            try
            {
                FileHandler.ValidateAdmin(userNameValidate, passwordValidate);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login unsuccessful" + ex.Message);
            }

        }
    }
}

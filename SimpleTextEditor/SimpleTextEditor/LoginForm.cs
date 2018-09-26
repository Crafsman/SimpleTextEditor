using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleTextEditor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_newUser_Click(object sender, EventArgs e)
        {
            NewUserForm newUser = new NewUserForm(this);
            newUser.StartPosition = FormStartPosition.CenterScreen;
            newUser.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditor
{
    public partial class LoginForm : Form
    {
        private static string LOGINFILE = "login.txt";
        public string UserName { set; get; } = string.Empty;

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

        private void button_login_Click(object sender, EventArgs e)
        {
            UserInformationStruct userInfo;
            userInfo.userType = "edit";
            //read file into  a collection, 
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            bool isMatch = false;
            string line;

            if (!File.Exists(LOGINFILE))
                return;

            // Retrieve file to match current input user information  
            StreamReader file = new StreamReader(LOGINFILE);
            while ((line = file.ReadLine()) != null)
            {
                string[] currentUserInfo = line.Split(',');
                if(username == currentUserInfo[0] && password == currentUserInfo[1])
                {
                    userInfo.userType = currentUserInfo[2];
                    isMatch = true;
                    UserName = username;
                    break;
                }               

            }

            if (isMatch)
            {
                TextEditorForm textEditor;
                if (userInfo.userType.ToLower() == "edit")
                    textEditor = new TextEditorForm(true, this);
                else
                    textEditor = new TextEditorForm(false, this);

                textEditor.StartPosition = FormStartPosition.CenterScreen;
                textEditor.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Invalid account or password", "Notice");
                return;
            }
              

        }
    }
}

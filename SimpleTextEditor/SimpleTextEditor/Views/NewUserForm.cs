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



    public partial class NewUserForm : Form
    {
        private LoginForm loginForm;

        private static string LOGINFILE = "login.txt";
        public string CustomFormat { get; set; }

        public NewUserForm(LoginForm form)
        {
            InitializeComponent();

            loginForm = form;

            dateTimePicker_DoB.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DoB.CustomFormat = "dd-MM-yyyy";

            if (comboBox_userType.Items.Count >=1 )
            {
                comboBox_userType.SelectedIndex = 0;
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool IsInputValid()
        {
            if (textBox_username.Text == "")
                return false;
            if (textBox_password.Text == "")
                return false;
            if (comboBox_userType.Text == "")
                return false;
            if (textBox_firstName.Text == "")
                return false;
            if (textBox_lastName.Text == "")
                return false;
            if (textBox_password.Text != textBox_rePassword.Text)
            {
                MessageBox.Show("Password not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckUserIsAvailable())
                    return;

                if (!IsInputValid())
                    return;

                string configContent = File.ReadAllText(LOGINFILE);
                var lastNewLinePosition = configContent.LastIndexOf("\n");

                var totalFileLength = configContent.Length;

                TextWriter tw = new StreamWriter(LOGINFILE, true);

                if (totalFileLength - 1 != lastNewLinePosition)
                {
                    tw.Write(Environment.NewLine);
                }
                tw.WriteLine(ReadInfoFromNewUserForm());
                tw.Close();

                //Close();
                MessageBox.Show("Register successfully");
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private string ReadInfoFromNewUserForm()
        {
            UserInformationStruct userInfo;
            userInfo.userName = textBox_username.Text;
            userInfo.password = textBox_password.Text;
            userInfo.userType = comboBox_userType.Text;
            userInfo.firstName = textBox_firstName.Text;
            userInfo.lastName = textBox_lastName.Text;
            userInfo.dateOfBirth = dateTimePicker_DoB.Text;

            string info = "";

            info += textBox_username.Text + ",";
            info += textBox_password.Text + ",";
            info += comboBox_userType.Text + ",";
            info += textBox_firstName.Text + ",";
            info += textBox_lastName.Text + ",";
            info += dateTimePicker_DoB.Text;

            return info;        
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            // Show login form
            loginForm.Show();
            Hide();
        }

        private void textBox_rePassword_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text != textBox_rePassword.Text)
            {
                MessageBox.Show("Password not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private bool CheckUserIsAvailable()
        {
            if (!File.Exists(LOGINFILE))
                return false;

            string username = textBox_username.Text;
            string line = "";
            // Retrieve file to match current input user information  
            StreamReader file = new StreamReader(LOGINFILE);
            while ((line = file.ReadLine()) != null)
            {
                string[] currentUserInfo = line.Split(',');
                if (username == currentUserInfo[0])
                {
                    MessageBox.Show(username + " exists \nPlease change the name");
                    file.Close();
                    return false;
                }

            }
            file.Close();

            return true;
        }

    }
}

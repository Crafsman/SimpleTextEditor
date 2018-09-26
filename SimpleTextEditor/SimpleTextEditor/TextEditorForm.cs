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
    public partial class TextEditorForm : Form
    {
        bool isEditable;
        private LoginForm loginForm;

        public TextEditorForm(bool editable, LoginForm form)
        {
            InitializeComponent();

            isEditable = editable;
            loginForm = form;
            if (isEditable)
                richTextBox1.Enabled = true;
            else
                richTextBox1.Enabled = false;

        }

        private void TextEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.StartPosition = FormStartPosition.CenterScreen;
            aboutbox.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show login form
            loginForm.Show();
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

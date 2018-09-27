using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string currentFileAbsolutePath = "";


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

        private void toolStripSplitButton_new_Click(object sender, EventArgs e)
        {

        }

        //https://www.c-sharpcorner.com/UploadFile/mahesh/savefiledialog-in-C-Sharp/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new SaveFileDialog and show
            if(currentFileAbsolutePath == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.Filter = "Text files (*.rtf)|*.rtf";
                saveFileDialog1.DefaultExt = "rtf";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        sw.WriteLine(richTextBox1.Text);
                    currentFileAbsolutePath = saveFileDialog1.FileName;

                    this.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
            else //save directly
            {
                using (StreamWriter sw = new StreamWriter(currentFileAbsolutePath))
                    sw.WriteLine(richTextBox1.Text);
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //always show save as dialog, and update current file path 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.Filter = "Text files (*.rtf)|*.rtf";
            saveFileDialog1.DefaultExt = "rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(richTextBox1.Text);
                    //sw.Close();
                }
               
                currentFileAbsolutePath = saveFileDialog1.FileName;
            }


            //current rich text editor becomes the new name????????

            this.Text = Path.GetFileName(saveFileDialog1.FileName);


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }

            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                string text = File.ReadAllText(fileName);
                richTextBox1.Text = text;

                this.Text = Path.GetFileName(fileName);
            }
        }
    }
}

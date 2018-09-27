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
    struct FileInfo
    {
        public string abosolutPath;
        public string fileName;  //test.txt
        public string content;
        public bool isSaved;
        public bool IsContentChanged;

        public FileInfo(string abosolutPath, string fileName, string content, bool isSaved)
        {
            this.abosolutPath = abosolutPath;
            this.fileName = fileName;
            this.content = content;
            this.isSaved = isSaved;
            IsContentChanged = false;
        }
    }

    public partial class TextEditorForm : Form
    {
        bool isEditable;
        private LoginForm loginForm;
        FileInfo currentFileInfo;

        public TextEditorForm(bool editable, LoginForm form)
        {
            InitializeComponent();

            isEditable = editable;
            loginForm = form;
            if (isEditable)
                richTextBox1.Enabled = true;
            else
                richTextBox1.Enabled = false;

            currentFileInfo = new FileInfo("Untitled", "", "", false);


            // new file
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

        private bool IsFileChanged()
        {
          
            //currentFileInfo.abosolutPath
            if (currentFileInfo.content.Trim() == richTextBox1.Text.Trim())
                return false;
            return true;
        }

        private void NewFile()
        {

            //detect if current file is saved?
            if (IsFileChanged())
            {

                string prompt = "Do you want to save changes to " + currentFileInfo.abosolutPath;

                DialogResult result = MessageBox.Show(prompt, "Simple Text Editor", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFile();
                        break;
                    case DialogResult.No:
                       
                        break;
                    case DialogResult.Cancel:
                        Console.WriteLine("The color is blue");
                        break;
                    default:
                        Console.WriteLine("The color is unknown.");
                        break;
                }

                return;
            }

            if (currentFileInfo.abosolutPath == "")
                return;

            if (currentFileInfo.isSaved || !currentFileInfo.IsContentChanged)
            {
                //clean the panel
                richTextBox1.Clear();

                //update current path                
                currentFileInfo = new FileInfo("Untitled", "", "", false);

                //change title -> "Untitled"
                this.Text = "Untitled";

                return;
            }




        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();

        }

        private void toolStripSplitButton_new_Click(object sender, EventArgs e)
        {

        }

        //https://www.c-sharpcorner.com/UploadFile/mahesh/savefiledialog-in-C-Sharp/
        private void SaveFile()
        {
            //new SaveFileDialog and show
            if (currentFileInfo.fileName == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.Filter = "Text files (*.rtf)|*.rtf";
                saveFileDialog1.DefaultExt = "rtf";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        sw.WriteLine(richTextBox1.Text);

                    currentFileInfo.abosolutPath = saveFileDialog1.FileName;
                    currentFileInfo.fileName = Path.GetFileName(saveFileDialog1.FileName);


                    this.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
            else //save directly
            {
                using (StreamWriter sw = new StreamWriter(currentFileInfo.abosolutPath))
                    sw.WriteLine(richTextBox1.Text);
                currentFileInfo.isSaved = true;
            }

            currentFileInfo.content = richTextBox1.Text;
            currentFileInfo.IsContentChanged = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFile();
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
               
                currentFileInfo.abosolutPath = saveFileDialog1.FileName;
            }

            //current rich text editor becomes the new name????????
            this.Text = Path.GetFileName(saveFileDialog1.FileName);

        }


        //Open file
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

                currentFileInfo.abosolutPath = fileName;
                this.Text = Path.GetFileName(fileName);


                currentFileInfo = new FileInfo(fileName, Path.GetFileName(fileName), text, true);
            }
        }

        private void richTextBox1_ModifiedChanged(object sender, EventArgs e)
        {
            bool isChanged = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            currentFileInfo.IsContentChanged = true;
        }
    }
}

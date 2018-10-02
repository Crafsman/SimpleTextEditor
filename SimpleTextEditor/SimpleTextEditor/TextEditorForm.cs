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

    struct FontStatus
    {
        public bool Regular;

        public bool Bold;

        public bool Italic;

        public bool Underline;

    }


    public partial class TextEditorForm : Form
    {
        bool isEditable;
        private LoginForm loginForm;
        FileInfo currentFileInfo;
        FontStatus fontStatus;
        CurrentClickButton currentBtn;

        public enum CurrentClickButton
        {
            Regular,
            Bold,
            Italic,
            Underline
        }

        public TextEditorForm(bool editable, LoginForm form)
        {
            InitializeComponent();

            isEditable = editable;
            loginForm = form;
            if (isEditable)
            {
                editToolStripMenuItem.Enabled = true;
                richTextBox1.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                richTextBox1.Enabled = false;
            }


            currentFileInfo = new FileInfo("Untitled", "", "", false);
            fontStatus = new FontStatus();


            //set userNmae
            toolStrip_userName.Text = "User Name: " + loginForm.UserName;
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
            NewFile();
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
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            currentFileInfo.IsContentChanged = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            /*
            //cursor position
            int i = richTextBox1.SelectionStart;

            string selectedText = richTextBox1.SelectedText;
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);

            Clipboard.SetText(selectedText);

            richTextBox1.SelectionStart = i;
            */
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            /*
            string selectedText = richTextBox1.SelectedText;

            if (selectedText == "")
                return;

            Clipboard.SetText(selectedText);*/
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            /*
            //cursor position
            int i = richTextBox1.SelectionStart;

            string pastText = Clipboard.GetText();
            richTextBox1.Text += pastText;

            richTextBox1.SelectionStart = i + pastText.Length;
            */
        }

        private void TextEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile(); ;
        }

        private void toolStripButton_saveAs_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton_bold_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionLength <= 0)
                return;
            currentBtn = CurrentClickButton.Bold;

            if (toolStripButton_bold.Checked)
            {
                toolStripButton_bold.Checked = false;
                fontStatus.Bold = false;

            }
            else
            {
                toolStripButton_bold.Checked = true;
                fontStatus.Bold = true;
                // richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
            UpdateFontStatus();

        }

        private void toolStripButton_italic_Click(object sender, EventArgs e)
        {


            if (richTextBox1.SelectionLength <= 0)
                return;
            currentBtn = CurrentClickButton.Italic;

            if (toolStripButton_italic.Checked)
            {
                toolStripButton_italic.Checked = false;
                fontStatus.Italic = false;

            }
            else
            {
                toolStripButton_italic.Checked = true;
                fontStatus.Italic = true;
                // richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }

            UpdateFontStatus();
        }

        private void toolStripButton_underLine_Click(object sender, EventArgs e)
        {


            if (richTextBox1.SelectionLength <= 0)
                return;

            currentBtn = CurrentClickButton.Underline;

            if (toolStripButton_underLine.Checked)
            {
                toolStripButton_underLine.Checked = false;
                fontStatus.Underline = false;

            }
            else
            {
                toolStripButton_underLine.Checked = true;
                fontStatus.Underline = true;
                // richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            UpdateFontStatus();


        }

        private void UpdateFontStatus()
        {


            switch (currentBtn)
            {
                case CurrentClickButton.Bold:
                    if (fontStatus.Bold)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    }
                    else
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    }
                    break;

                case CurrentClickButton.Italic:
                    if (fontStatus.Italic)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                    }
                    else
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                    }
                    break;

                case CurrentClickButton.Underline:
                    if (fontStatus.Underline)
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                    }
                    else
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                    }
                    break;
                default:

                    break;
            }

            currentBtn = CurrentClickButton.Regular;

        }

        private void toolStripButton_bold_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength <= 0)
                return;

            Object selectedItem = toolStrip_font.SelectedItem;
            int fontsize = Convert.ToInt16(selectedItem);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontsize, richTextBox1.SelectionFont.Style);

        }

        private void toolStripButton_font_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton_copy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton_paste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton_question_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }
    }
}

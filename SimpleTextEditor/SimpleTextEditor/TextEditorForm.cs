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

        public TextEditorForm(bool editable)
        {
            isEditable = editable;

            InitializeComponent();
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
    }
}

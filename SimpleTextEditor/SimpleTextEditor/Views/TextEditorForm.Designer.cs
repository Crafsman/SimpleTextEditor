﻿namespace SimpleTextEditor
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_saveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_underLine = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_font = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_question = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_userName = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_paste = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_new,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton_saveAs,
            this.toolStripButton4,
            this.toolStripButton_bold,
            this.toolStripButton_italic,
            this.toolStripButton_underLine,
            this.toolStrip_font,
            this.toolStripButton_question,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStrip_userName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton_new
            // 
            this.toolStripSplitButton_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton_new.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_new.Image")));
            this.toolStripSplitButton_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_new.Name = "toolStripSplitButton_new";
            this.toolStripSplitButton_new.Size = new System.Drawing.Size(23, 22);
            this.toolStripSplitButton_new.Text = "toolStripSplitButton1";
            this.toolStripSplitButton_new.ToolTipText = "New";
            this.toolStripSplitButton_new.Click += new System.EventHandler(this.toolStripSplitButton_new_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton_saveAs
            // 
            this.toolStripButton_saveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_saveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_saveAs.Image")));
            this.toolStripButton_saveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_saveAs.Name = "toolStripButton_saveAs";
            this.toolStripButton_saveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_saveAs.Text = "toolStripButton3";
            this.toolStripButton_saveAs.ToolTipText = "Save As";
            this.toolStripButton_saveAs.Click += new System.EventHandler(this.toolStripButton_saveAs_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_bold
            // 
            this.toolStripButton_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_bold.Image")));
            this.toolStripButton_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bold.Name = "toolStripButton_bold";
            this.toolStripButton_bold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_bold.Text = "toolStripButton5";
            this.toolStripButton_bold.ToolTipText = "Bold";
            this.toolStripButton_bold.Click += new System.EventHandler(this.toolStripButton_bold_Click);
            // 
            // toolStripButton_italic
            // 
            this.toolStripButton_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_italic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_italic.Image")));
            this.toolStripButton_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_italic.Name = "toolStripButton_italic";
            this.toolStripButton_italic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_italic.Text = "toolStripButton6";
            this.toolStripButton_italic.ToolTipText = "Italics";
            this.toolStripButton_italic.Click += new System.EventHandler(this.toolStripButton_italic_Click);
            // 
            // toolStripButton_underLine
            // 
            this.toolStripButton_underLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_underLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_underLine.Image")));
            this.toolStripButton_underLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_underLine.Name = "toolStripButton_underLine";
            this.toolStripButton_underLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_underLine.Text = "toolStripButton7";
            this.toolStripButton_underLine.ToolTipText = "Underline";
            this.toolStripButton_underLine.Click += new System.EventHandler(this.toolStripButton_underLine_Click);
            // 
            // toolStrip_font
            // 
            this.toolStrip_font.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.toolStrip_font.Name = "toolStrip_font";
            this.toolStrip_font.Size = new System.Drawing.Size(140, 25);
            this.toolStrip_font.Text = "Font Size";
            this.toolStrip_font.ToolTipText = "Font size";
            this.toolStrip_font.SelectedIndexChanged += new System.EventHandler(this.toolStripButton_font_SelectedIndexChanged);
            // 
            // toolStripButton_question
            // 
            this.toolStripButton_question.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_question.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_question.Image")));
            this.toolStripButton_question.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_question.Name = "toolStripButton_question";
            this.toolStripButton_question.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_question.Text = "toolStripButton9";
            this.toolStripButton_question.ToolTipText = "help";
            this.toolStripButton_question.Click += new System.EventHandler(this.toolStripButton_question_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(0, 22);
            this.toolStripButton11.Text = "toolStripButton11";
            // 
            // toolStrip_userName
            // 
            this.toolStrip_userName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_userName.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_userName.Image")));
            this.toolStrip_userName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_userName.Name = "toolStrip_userName";
            this.toolStrip_userName.Size = new System.Drawing.Size(131, 22);
            this.toolStrip_userName.Text = "User Name: HelloWorld";
            this.toolStrip_userName.ToolTipText = "User Name";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_cut,
            this.toolStripButton_copy,
            this.toolStripButton_paste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 539);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip_leftside";
            // 
            // toolStripButton_cut
            // 
            this.toolStripButton_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_cut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_cut.Image")));
            this.toolStripButton_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_cut.Name = "toolStripButton_cut";
            this.toolStripButton_cut.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton_cut.Text = "toolStripButton3";
            this.toolStripButton_cut.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_copy.Image")));
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton_copy.Text = "toolStripButton5";
            this.toolStripButton_copy.Click += new System.EventHandler(this.toolStripButton_copy_Click);
            // 
            // toolStripButton_paste
            // 
            this.toolStripButton_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_paste.Image")));
            this.toolStripButton_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_paste.Name = "toolStripButton_paste";
            this.toolStripButton_paste.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton_paste.Text = "toolStripButton6";
            this.toolStripButton_paste.Click += new System.EventHandler(this.toolStripButton_paste_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(974, 539);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 588);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorForm";
            this.Text = "TextEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEditorForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton_new;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton_saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton_bold;
        private System.Windows.Forms.ToolStripButton toolStripButton_italic;
        private System.Windows.Forms.ToolStripButton toolStripButton_underLine;
        private System.Windows.Forms.ToolStripComboBox toolStrip_font;
        private System.Windows.Forms.ToolStripButton toolStripButton_question;
        private System.Windows.Forms.ToolStripSeparator toolStripButton10;
        private System.Windows.Forms.ToolStripLabel toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStrip_userName;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_cut;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_paste;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
namespace AquamarIDE_Updared
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            fontDialog1 = new FontDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            loadToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            cosmeticToolStripMenuItem = new ToolStripMenuItem();
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            changeFontToolStripMenuItem = new ToolStripMenuItem();
            changeBackgroundColorToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            previewHTMLToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(224, 224, 224);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ShowSelectionMargin = true;
            richTextBox1.Size = new Size(1904, 1041);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 70);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(100, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, cosmeticToolStripMenuItem, debugToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem1, saveToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "File";
            // 
            // loadToolStripMenuItem1
            // 
            loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            loadToolStripMenuItem1.Size = new Size(100, 22);
            loadToolStripMenuItem1.Text = "Load";
            loadToolStripMenuItem1.Click += loadToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(100, 22);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // cosmeticToolStripMenuItem
            // 
            cosmeticToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeColorToolStripMenuItem, changeFontToolStripMenuItem, changeBackgroundColorToolStripMenuItem });
            cosmeticToolStripMenuItem.Name = "cosmeticToolStripMenuItem";
            cosmeticToolStripMenuItem.Size = new Size(69, 20);
            cosmeticToolStripMenuItem.Text = "Cosmetic";
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(212, 22);
            changeColorToolStripMenuItem.Text = "Change color";
            changeColorToolStripMenuItem.Click += changeColorToolStripMenuItem_Click;
            // 
            // changeFontToolStripMenuItem
            // 
            changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            changeFontToolStripMenuItem.Size = new Size(212, 22);
            changeFontToolStripMenuItem.Text = "Change font";
            changeFontToolStripMenuItem.Click += changeFontToolStripMenuItem_Click;
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            changeBackgroundColorToolStripMenuItem.Size = new Size(212, 22);
            changeBackgroundColorToolStripMenuItem.Text = "Change background color";
            changeBackgroundColorToolStripMenuItem.Click += changeBackgroundColorToolStripMenuItem_Click;
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { previewHTMLToolStripMenuItem });
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new Size(54, 20);
            debugToolStripMenuItem.Text = "Debug";
            // 
            // previewHTMLToolStripMenuItem
            // 
            previewHTMLToolStripMenuItem.Name = "previewHTMLToolStripMenuItem";
            previewHTMLToolStripMenuItem.Size = new Size(156, 22);
            previewHTMLToolStripMenuItem.Text = "Preview(HTML)";
            previewHTMLToolStripMenuItem.Click += previewHTMLToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1904, 1041);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AquamarIDE";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem cosmeticToolStripMenuItem;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ToolStripMenuItem changeFontToolStripMenuItem;
        private ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem previewHTMLToolStripMenuItem;
    }
}

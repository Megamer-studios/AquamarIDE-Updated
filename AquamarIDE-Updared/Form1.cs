using System.Text;

namespace AquamarIDE_Updared
{

    public partial class Form1 : Form
    {

        public string[] files;
        public bool IsFolder = false;
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void ReadTextFile(string path)
        {
            /*  using (StreamReader reader = new StreamReader(path))
              {
                  {
                      string line;
                      StringBuilder builder = new StringBuilder();
                      while ((line = reader.ReadLine()) != null)
                      {
                          builder.Append(line);
                      }
                      reader.Close();
                      richTextBox1.Text = builder.ToString();

                  }
              }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            richTextBox1.BackColor = colorDialog2.Color;
        }

        private void previewHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, richTextBox1.Text);
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = fileDialog.FileName;
                MessageBox.Show(fileDialog.SafeFileName + " has been loaded");
                string content = File.ReadAllText(fileDialog.FileName);
                richTextBox1.Text = content;

            }
        }

        private void loadFolerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                MessageBox.Show(folderPath + " has been loaded");
                listBox1.Items.Clear();
                files = Directory.GetFiles(folderPath);
                IsFolder = true;
                listBox1.Visible = true;

                foreach (var file in files)
                {
                    var filename = Path.GetFileName(file);
                    listBox1.Items.Add(filename);
                }
            }

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedFile = files.FirstOrDefault(f => Path.GetFileName(f) == listBox1.SelectedItem.ToString());
                if (selectedFile != null)
                {
                    richTextBox1.Text = File.ReadAllText(selectedFile);
                }
            }
        }


        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            richTextBox1.BackColor = colorDialog2.Color;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFile = files.FirstOrDefault(f => Path.GetFileName(f) == listBox1.SelectedItem.ToString());
                if (selectedFile != null)
                {
                    File.WriteAllText(selectedFile, richTextBox1.Text);
                }
            }
            else
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem2_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                previewHTMLToolStripMenuItem_Click(sender, e);
            }
            //else if (e.KeyCode == Keys.Tab)
            //{
            //    richTextBox1.Text = "    ";

            //}
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Tab)
            //{
            //    richTextBox1.Text += "    ";

            //}
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();

        }

        private void contextMenuStrip3_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFile = files.FirstOrDefault(f => Path.GetFileName(f) == listBox1.SelectedItem.ToString());
                if (selectedFile != null)
                {
                    File.Delete(selectedFile);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }
    }

}

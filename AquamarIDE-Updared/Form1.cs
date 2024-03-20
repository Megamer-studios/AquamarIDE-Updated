using System.Text;

namespace AquamarIDE_Updared
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void ReadTextFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
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
            }
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
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = fileDialog.FileName;
                MessageBox.Show(fileDialog.SafeFileName + " has been loaded");
                ReadTextFile(richTextBox1.Text);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
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
    }
}

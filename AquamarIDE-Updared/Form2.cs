using EO.WebBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace AquamarIDE_Updared
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                InitializeWebView();


            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
  
        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate(openFileDialog1.FileName);
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSniffer
{
    public partial class Linker : UserControl
    {
        public Linker()
        {
            InitializeComponent();
        }
        private MyWebBrowser myBrowser;
       
        internal MyWebBrowser MyBrowser
        {
            get => myBrowser;
            set
            {
                myBrowser = value;
                try
                {
                    lbName.Text = "Linker: " + myBrowser.DocumentTitle;
                    tbLink.Text = myBrowser.Url.ToString();
                }
                catch
                {

                }
            }
        }

        private void tbLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myBrowser.Navigate(tbLink.Text);
                this.Hide();
            }
        }
        public void loadHistory(List<string> history)
        {
            tbLink.Properties.Items.Clear();
            foreach (string h in history)
            { 
                tbLink.Properties.Items.Add(h);
            }
        }
    }
}

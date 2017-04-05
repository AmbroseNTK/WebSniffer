using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSniffer
{
    class MyTabPage:DevExpress.XtraTab.XtraTabPage
    {
        private MyWebBrowser webBrowser=new MyWebBrowser();

        internal MyWebBrowser WebBrowser { get => webBrowser; set => webBrowser = value; }

        protected override void OnCreateControl()
        {
            
            WebBrowser.ParentPage = this;
            this.Controls.Add(WebBrowser);
            WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            WebBrowser.Navigate("google.com");
            base.OnCreateControl();
        }
    }
}

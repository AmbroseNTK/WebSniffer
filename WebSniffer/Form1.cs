using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gecko;

namespace WebSniffer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            Xpcom.EnableProfileMonitoring = false;
            Xpcom.Initialize("Firefox");

            InitializeComponent();
        }
        private MyWebBrowser mainWebBrowser;
        private Linker linker;
        private void Form1_Load(object sender, EventArgs e)
        {
            progressPanel1.Hide();
            btCloseTab.Visible = false;
            mainWebBrowser = createNewTab("google.com");
            linker = new Linker();
            Controls.Add(linker);
            linker.BringToFront();
            linker.Hide();
        }
        private MyWebBrowser createNewTab(string url)
        {
            MyWebBrowser browser = new MyWebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.Navigating += onDocumentLoading;
            browser.DocumentCompleted += onDocumentLoaded;
            browser.NavigationError += onDocumentLoadError;
            browser.Navigate(url);

            DevExpress.XtraBars.Navigation.TabNavigationPage page = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            page.Caption = "Untitle";
            page.Controls.Add(browser);
            browser.MyPage = page;

            tabPane1.Pages.Add(page);
            tabPane1.SelectedPage = page;

            return browser;
        }
        private MyWebBrowser CloseTab()
        {

            int index = tabPane1.SelectedPageIndex;
            tabPane1.Pages.Remove(tabPane1.SelectedPage);
            if (tabPane1.Pages.Count == 1)
            {
                btCloseTab.Visible = false;
            }
            return (MyWebBrowser)tabPane1.SelectedPage.Controls["browser"];
            
        }
        private void onDocumentLoading(object sender, EventArgs e)
        {
            progressPanel1.Show();
        }
        private void onDocumentLoaded(object sender, EventArgs e)
        {
            progressPanel1.Hide();
            MyWebBrowser browser = (MyWebBrowser)sender;
            btNewTab.Visible = true;
        }
        private void onDocumentLoadError(object sender, EventArgs e)
        {
            progressPanel1.Hide();
        }
        private void toolboxControl1_ItemClick(object sender, DevExpress.XtraToolbox.ToolboxItemClickEventArgs e)
        {
            if (e.Item == btNewTab)
            {
                btNewTab.Visible = false;
                mainWebBrowser = createNewTab("google.com");
                btCloseTab.Visible = true;
            }
            if (e.Item == btCloseTab)
            {
                if (tabPane1.Pages.Count > 1)
                {
                    mainWebBrowser = CloseTab();
                }
            }
            if(e.Item == btBack)
            {
                mainWebBrowser.GoBack();
            }
            if (e.Item == btNext)
            {
                mainWebBrowser.GoForward();
            }
            if (e.Item == btRefresh)
            {
                mainWebBrowser.Refresh();
            }
            if (e.Item == btLink)
            {
                linker.MyBrowser = mainWebBrowser;
                linker.Location = new Point(Cursor.Position.X-linker.Width, Cursor.Position.Y-linker.Height);
                toggleLinker();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            progressPanel1.Location = new Point(Width / 2 - progressPanel1.Width / 2, Height / 2 - progressPanel1.Height / 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            tabPane1.Dispose();
            Xpcom.Shutdown();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            try
            {
                mainWebBrowser = (MyWebBrowser)(tabPane1.SelectedPage.Controls["browser"]);
            }
            catch { }
        }
        private void toggleLinker()
        {
            if (linker.Visible == true)
            {
                linker.Hide();
            }
            else
            {
                linker.Show();
            }
        }
    }
}

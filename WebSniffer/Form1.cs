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
        MyTabPane tabPane;
        Linker linker;
        private void Form1_Load(object sender, EventArgs e)
        {
            linker = new Linker();
            Controls.Add(linker);
            linker.Hide();
            tabPane = new MyTabPane();
            tabPane.Dock = DockStyle.Fill;
            Controls.Add(tabPane);

            MyTabPage page = new MyTabPage();
            tabPane.AddMyTabPage(page);
           
        }
    
        private void toolboxControl1_ItemClick(object sender, DevExpress.XtraToolbox.ToolboxItemClickEventArgs e)
        {
            if (e.Item == btNewTab)
            {
                MyTabPage page = new MyTabPage();
                tabPane.AddMyTabPage(page);
                tabPane.SelectedTabPageIndex = tabPane.TabPages.Count - 1;
                page.Appearance.Header.BeginUpdate();

                page.Appearance.Header.BackColor = getRandomColor();
                page.Appearance.Header.EndUpdate();

            }
            if (e.Item == btCloseTab)
            {
                tabPane.RemoveThisPage();
            }
            if(e.Item == btBack)
            {
                tabPane.GetThisWebBrowser().GoBack();
            }
            if (e.Item == btNext)
            {
                tabPane.GetThisWebBrowser().GoForward();
            }
            if (e.Item == btRefresh)
            {
                tabPane.GetThisWebBrowser().Refresh();
            }
            if (e.Item == btLink)
            {
                if (linker.Visible)
                {
                    linker.Hide();
                }
                else
                {
                    linker.Location = new Point(Cursor.Position.X - linker.Width, Cursor.Position.Y - linker.Height);
                    linker.Show();
                    linker.MyBrowser = tabPane.GetThisWebBrowser();
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //progressPanel1.Location = new Point(Width / 2 - progressPanel1.Width / 2, Height / 2 - progressPanel1.Height / 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //tabPane.Dispose();
            //Xpcom.Shutdown();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
           
        }
        private void toggleLinker()
        {
           
        }
        int colored = 0;
        public Color getRandomColor()
        {
           
            Random rand = new Random();
            int current = rand.Next(0, 10);
            while (current == colored)
            {
                current = rand.Next(0, 10);
            }
            switch (current)
            {
                case 0:
                    return Color.Chocolate;
                case 1:
                    return Color.BurlyWood;
                case 2:
                    return Color.BlueViolet;
                case 3:
                    return Color.DodgerBlue;
                case 4:
                    return Color.OrangeRed;
                case 5:
                    return Color.PaleGreen;
                case 6:
                    return Color.PapayaWhip;
                case 7:
                    return Color.LightPink;
                case 8:
                    return Color.LightSeaGreen;
                case 9:
                    return Color.Maroon;
            }
            return Color.Black;
        }
        private void onDocumentLoading(object sender, EventArgs e)
        {
            tabPane.SelectedTabPage.Text = "Loading...";
        }
        private void onDocumentLoaded(object sender,EventArgs e)
        {
            tabPane.SelectedTabPage.Text= tabPane.GetThisWebBrowser().DocumentTitle; ;
        }
    }
}

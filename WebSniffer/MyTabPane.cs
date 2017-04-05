using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;

namespace WebSniffer
{
    class MyTabPane: DevExpress.XtraTab.XtraTabControl
    {
        List<MyTabPage> myTabPageList;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            myTabPageList = new List<MyTabPage>();

        }
        protected override void OnTabPageAdded(XtraTabPage page)
        {
            base.OnTabPageAdded(page);
           
        }
        public void AddMyTabPage(MyTabPage page)
        {
            TabPages.Add(page);
            myTabPageList.Add(page);
        }
        public void RemoveThisPage()
        {
            myTabPageList.RemoveAt(SelectedTabPageIndex);
            TabPages.Remove(SelectedTabPage);
        }
        public MyWebBrowser GetThisWebBrowser()
        {
            return myTabPageList[SelectedTabPageIndex].WebBrowser;
        }

    }
}

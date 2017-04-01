using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Navigation;
using Gecko.Events;

namespace WebSniffer
{
    class MyWebBrowser:Gecko.GeckoWebBrowser
    {
        private DevExpress.XtraBars.Navigation.TabNavigationPage myPage;

        public TabNavigationPage MyPage { get => myPage; set => myPage = value; }
        protected override void OnDocumentCompleted(GeckoDocumentCompletedEventArgs e)
        {
            myPage.Caption = this.DocumentTitle;
            base.OnDocumentCompleted(e);
        }
        protected override void OnNavigating(GeckoNavigatingEventArgs e)
        {
            myPage.Caption = "Loading...";
            base.OnNavigating(e);
        }

    }
}

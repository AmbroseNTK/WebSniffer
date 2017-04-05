using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using Gecko.Events;

namespace WebSniffer
{
    class MyWebBrowser:Gecko.GeckoWebBrowser
    {
        MyTabPage parentPage;

        internal MyTabPage ParentPage { get => parentPage; set => parentPage = value; }

        protected override void OnNavigating(GeckoNavigatingEventArgs e)
        {
            base.OnNavigating(e);
            parentPage.Text = "Loading...";
        }
        protected override void OnNavigationError(GeckoNavigationErrorEventArgs e)
        {
            base.OnNavigationError(e);
            parentPage.Text = "Cannot reach this page";
        }
        protected override void OnDocumentCompleted(GeckoDocumentCompletedEventArgs e)
        {
            base.OnDocumentCompleted(e);
            parentPage.Text = DocumentTitle;
        }
    }
}

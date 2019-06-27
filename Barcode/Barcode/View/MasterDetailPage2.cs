using Barcode.TabPage;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Barcode.View
{
    public class MasterDetailPage2:MasterDetailPage
    {
        public MasterDetailPage2()
        {
            Master = new Tab1();
            Detail = new TabPage2();
        }
    }
}

using Barcode.TabPage;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Barcode.View
{
    public class TabPage2: TabbedPage
    {
        public TabPage2()
        {

            Children.Add(new Tab1());
            Children.Add(new Tab2());
        }
    }
}

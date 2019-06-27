using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barcode.TabPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tab1 : ContentPage
	{
		public Tab1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            Stack2.BackgroundColor = Color.Aqua;
        }
       
    }
}
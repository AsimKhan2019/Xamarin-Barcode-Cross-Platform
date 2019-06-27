using Barcode.TabPage;
using Barcode.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinReader;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Barcode
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new MasterDetailPage2();
                //NavigationPage(new Reader());
        }

  

    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

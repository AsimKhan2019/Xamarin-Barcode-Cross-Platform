using System.Collections.Generic;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace XamarinReader
{
    public class Reader : ContentPage
    {
        ZXingScannerPage sPage;
        public Reader()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Title = "PilavScan";
            });
            BackgroundColor = Color.FromHex("#3498db");
            sPage = new ZXingScannerPage(new MobileBarcodeScanningOptions
            { 
                AutoRotate = true,
                PossibleFormats = new List<BarcodeFormat>
                {
                    BarcodeFormat.QR_CODE,
                    BarcodeFormat.AZTEC
                },
                UseFrontCameraIfAvailable = false,
                UseNativeScanning = true
            });

            sPage.ToggleTorch();
            sPage.OnScanResult += SPage_OnScanResult;

            Button scanButton = new Button
            {
                Text = "Tara",
                TextColor =  Color.FromHex("#bdc3c7"),
                AutomationId = "scanContinuously",
                BackgroundColor = Color.FromHex("#2c3e50")
            };
            Button generateButton = new Button
            {
                Text = "Oluştur",
                TextColor =  Color.FromHex("#bdc3c7"),
                AutomationId = "barcodeGenerator",
                BackgroundColor = Color.FromHex("#2c3e50")

            };
            Label bilgi = new Label
            { Text = "Özhan YILDIZ",
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                FontSize = 25,
                TextColor= Color.FromHex("#bdc3c7")

        };
            
        

            generateButton.Clicked += GenerateButton_Clicked;

            scanButton.Clicked += ScanButton_Clicked;

            var stack = new StackLayout();
            stack.Children.Add(scanButton);
            stack.Children.Add(generateButton);
            stack.Children.Add(bilgi);
            stack.BackgroundColor = Color.FromHex("#34495e");

            Content = stack;
        }

        private async void GenerateButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Barcode.GeneratePage());
        }

        private void SPage_OnScanResult(ZXing.Result result)
        {
            sPage.IsScanning = false;
            Device.BeginInvokeOnMainThread(() =>
            {
                Navigation.PopAsync();
                DisplayAlert("Scan", result.Text, "Ok");
            });
        }

        private async void ScanButton_Clicked(object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(sPage);
        }
    }
}
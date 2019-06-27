using Xamarin.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Net.Mobile.Forms;

namespace Barcode
{
    public class GeneratePage:ContentPage
    {
        public GeneratePage()
        {
            ZXingBarcodeImageView barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView"
            };

            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;

            barcode.BarcodeValue = "ÖzhanYILDIZ";
            barcode.BarcodeOptions = new EncodingOptions() { Height = 100, Width = 100, PureBarcode = true };

            Content = barcode;
        }
    }

}


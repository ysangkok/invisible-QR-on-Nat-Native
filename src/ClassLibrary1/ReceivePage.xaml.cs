using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;
using ZXing.Common;

namespace ClassLibrary1
{
    public partial class ReceivePage : ContentPage
    {
        public ReceivePage()
        {
            Extensions.LoadFromXaml(this, typeof(ReceivePage));
        }

        override protected void OnAppearing()
        {
            var mainLayout = (StackLayout) base.FindByName("mainLayout");
            var size = 200;
            var encodingOptions = new EncodingOptions();
            encodingOptions.Height = size;
            encodingOptions.Width = size;
            var barCode = new ZXingBarcodeImageView();
            barCode.HorizontalOptions = LayoutOptions.Center;
            barCode.VerticalOptions = LayoutOptions.Center;
            barCode.BarcodeFormat = BarcodeFormat.QR_CODE;
            barCode.BarcodeValue = "abc";
            barCode.HeightRequest = (float)size;
            barCode.WidthRequest = (float)size;
            barCode.BarcodeOptions = encodingOptions;
            mainLayout.Children.Add(barCode);
        }
    }
}
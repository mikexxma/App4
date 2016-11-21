using System;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;

using System.Diagnostics;
using Windows.UI.Xaml.Controls;


#if __IOS__
using Xamarin.Forms.Platform.iOS;
using UIKit;
#elif __ANDROID__
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Android.Widget;
#elif WINDOWS_UWP
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

#elif WINDOWS_PHONE_APP
using System;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.WinRT;

#endif





namespace App4
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            View view = null;
           
#if __IOS__
      UILabel label = new UILabel
      {
        Text = "Hello iOS Native!",
        Font = UIFont.FromName("Papyrus", 32f),
      };
      view = label.ToView();
#elif __ANDROID__
      TextView textView = new TextView(Forms.Context)
      {
        Text = "Hello Android Native!",
        Typeface = Typeface.Create("cursive", TypefaceStyle.Normal),
        TextSize = 32f
      };
      view = textView.ToView();
#elif WINDOWS_UWP
      TextBlock textBlock = new TextBlock
      {
        Text = "Hello Windows Native!",
        FontFamily = new FontFamily("Georgia"),
        FontStyle = FontStyle.Italic,
        FontSize = 32
      };
      view = textBlock.ToView();

#elif WINDOWS_PHONE_APP
       TextBlock textBlock = new TextBlock
      {
        Text = "Hello Windows Native!",
        FontFamily = new FontFamily("Georgia"),
        FontStyle = FontStyle.Italic,
        FontSize = 32
      };
      view = textBlock.ToView();
#endif


            try {
                view.HorizontalOptions = LayoutOptions.Center;
                view.VerticalOptions = LayoutOptions.Center;
                Content = view;
            } catch (Exception e)
            {

            }
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new Page2());
        }
    }
}

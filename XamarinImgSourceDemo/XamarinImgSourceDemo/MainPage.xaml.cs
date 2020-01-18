using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinImgSourceDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var fontName = "gestures.ttf";
            switch(Device.RuntimePlatform)
            {
                case Device.Android:
                    fontName = "gestures.ttf#gestures";
                    break;
                case Device.iOS:
                    fontName = "gestures";
                    break;
                case Device.UWP:
                    fontName = "Assets/Fonts/gestures.ttf#gestures";
                    break;
            }

            imgDemoIconFont.Source =
                new FontImageSource
                {
                    Glyph = "\uE700",
                    FontFamily = fontName,
                    Size = 80
                };
        }
    }
}

using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp
{
    public partial class App : Application
    {
        public static float screenWidth { get; set; }
        public static float screenHeight { get; set; }
        public static float appScale { get; set; }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    public class IsOwnerConverter : IValueConverter
    {
        DataClass dataClass = DataClass.GetInstance;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool retVal = false;
            string[] players = value as string[];

            if (players[0].Equals(dataClass.loggedInUser.uid))
                retVal = true;

            return retVal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


using System.Windows;

namespace Mvsevm
{
    public class DynamicSplashScreen : Window
    {
        public DynamicSplashScreen()
        {
            //Defaults for splash screen
            ShowInTaskbar = false;
            WindowStartupLocation = WindowStartupLocation.Manual;
            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.None;
            Topmost = true;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //calculate it manually since CenterScreen substracts  
            //taskbar's height from available area
            Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
            Top = (SystemParameters.PrimaryScreenHeight - Height) / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mvsevm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Splash splashScreen = new Splash();
            splashScreen.Show();
            MainWindow mainWindow = new MainWindow();
            //when main windows is loaded close splash screen
            mainWindow.Loaded += (send, args) => splashScreen.Close();
            //set application main window;
            this.MainWindow = mainWindow;
            //and finally show it
            mainWindow.Show();
        }
    }
}

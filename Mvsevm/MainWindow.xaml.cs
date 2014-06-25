using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;

namespace Mvsevm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private UIElement _actualMainContent;
        public MainWindow()
        {
            InitializeComponent();
            var contentToAdd = new Button() {Name = "Próba",Content = "csak hogy látszódjon"};
            MainContent.Children.Add(contentToAdd);
            _actualMainContent = contentToAdd;
        }

        private void OnCreateUser(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New command triggered by " + e.Source.ToString());
        }

        private bool onEditRun = false;

        private void OnEditDmSuperType(object sender, ExecutedRoutedEventArgs e)
        {
            if (!onEditRun)
            {
                onEditRun = true;
                var contentToAdd = new DmSuperTypeEditor();
                MainContent.Children.Remove(_actualMainContent);
                MainContent.Children.Add(new DmSuperTypeEditor());
                _actualMainContent = contentToAdd;
                onEditRun = false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvsevm
{
    public static class MvsevmCommands
    {
        private static RoutedUICommand createUser;
        public static ICommand CreateUser
        {
            get
            {
                return createUser ?? (createUser = new RoutedUICommand("Create user", "CreateUser", typeof(MvsevmCommands)));
            }
        }

        private static RoutedUICommand editDmSuperType;
        public static ICommand EditDmSuperType
        {
            get
            {
                return editDmSuperType ?? (editDmSuperType = new RoutedUICommand("Típus karbantartás", "EditDmSuperType", typeof(MvsevmCommands)));
            }
        }

        /*
        private static RoutedUICommand showBooksList;
        public static ICommand ShowBooksList
        {
            get
            {
                if (showBooksList == null)
                {
                    showBooksList = new RoutedUICommand("Show Books", "ShowBooks",
                    typeof(BooksCommands));
                    showBook.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Alt)); 
                }
                return showBooksList;
            }
        } 
        */
    }
}

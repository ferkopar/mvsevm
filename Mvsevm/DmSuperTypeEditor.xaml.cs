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
using MvseumDal;
using MvsevmGlobal;

namespace Mvsevm
{
    /// <summary>
    /// Interaction logic for DmSuperTypeEditor.xaml
    /// </summary>
    public partial class DmSuperTypeEditor : UserControl
    {

        private List<dm_super_type> superTypes;
        
        public DmSuperTypeEditor()
        {

            InitializeComponent();
            DataContext = this;
            using (var context = new MvsevmMySqlEntities(Settings.ConnectionString))
            {
                superTypes = context.dm_super_type.Where(s => s.GROUP_ID == s.SUPER_TYPE_ID).ToList();
                foreach (var superType in superTypes)
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Tag = superType;
                    item.Header = superType.SUPER_TYPE_NAME;
                    MainTreeView.Items.Add(item);
                }
                
            }
        }


        private void item_Expanded(object sender, RoutedEventArgs e)
        {

            TreeViewItem itemOrigin = (TreeViewItem)e.OriginalSource;
            itemOrigin.Items.Clear();
            var superTypeNode = (dm_super_type)itemOrigin.Tag;        
            using (var context = new MvsevmMySqlEntities(Settings.ConnectionString))
            {
                superTypes = context.dm_super_type.Where(s => s.GROUP_ID == superTypeNode.SUPER_TYPE_ID
                                                           && s.GROUP_ID != s.SUPER_TYPE_ID).ToList();
                foreach (var superType in superTypes)
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Tag = superType;
                    item.Header = superType.SUPER_TYPE_NAME;
                    itemOrigin.Items.Add(item);
                }

            }
            
        }

       
        private void MainTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            
            var currentSuperType = (dm_super_type)((TreeViewItem) MainTreeView.SelectedItem).Tag;
            Editorpanel.DmSuperType = currentSuperType;
        }
    }
}

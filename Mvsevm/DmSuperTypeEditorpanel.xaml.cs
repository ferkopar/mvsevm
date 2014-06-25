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
    /// Interaction logic for DmSuperTypeEditorpanel.xaml
    /// </summary>
    public partial class DmSuperTypeEditorpanel : UserControl
    {
        private v_dm_super_type _vDmSuperType = new v_dm_super_type();
        public dm_super_type DmSuperType
        {
            get { return (dm_super_type)GetValue(DmSuperTypeProperty); }
            set
            {
                SetValue(DmSuperTypeProperty, value);
                using (var context = new MvsevmMySqlEntities(Settings.ConnectionString))
                {
                    _vDmSuperType = context.v_dm_super_type.Single(s => s.SUPER_TYPE_ID == value.SUPER_TYPE_ID);
                    DataContext = _vDmSuperType;
                }
            }
        }

        // Using a DependencyProperty as the backing store for DmSuperType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DmSuperTypeProperty =
            DependencyProperty.Register("DmSuperType", typeof(dm_super_type), typeof(DmSuperTypeEditorpanel));

        public DmSuperTypeEditorpanel()
        {
            InitializeComponent();
            DataContext = _vDmSuperType;

        }
    }
}

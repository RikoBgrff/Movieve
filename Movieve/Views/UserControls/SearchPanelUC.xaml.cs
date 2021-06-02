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
using Movieve.ViewModels;

namespace Movieve.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SearchPanelUC.xaml
    /// </summary>
    public partial class SearchPanelUC : UserControl
    {
        public SearchPanelUC()
        {
            this.DataContext = new SearchPanelUCViewModel();
            InitializeComponent();
        }

    }
}

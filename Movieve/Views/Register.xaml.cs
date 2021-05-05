using Movieve.ViewModels;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Filmagine
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public Register()
        {
            InitializeComponent();
            this.DataContext = new RegisterViewModel(); 
        }
        private void RegisterLbl_MouseEnter(object sender, MouseEventArgs e)
        {
            RegisterLbl.FontSize = 21;
        }

        private void RegisterLbl_MouseLeave(object sender, MouseEventArgs e)
        {
            RegisterLbl.FontSize = 18;
        }
    }
}

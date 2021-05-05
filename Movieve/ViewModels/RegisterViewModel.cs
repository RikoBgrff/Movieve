using Movieve.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Movieve.ViewModels
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private User _user { get; set; }
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand LoginCommand { get; set; }
        public RegisterViewModel()
        {
            User = new User
            {
                Name = "riko",
                Password = "rikobgrff"
            };
            LoginCommand = new RelayCommand((e) =>
            {
                MessageBox.Show("Logged In Sucsessfully");
            }, (c) =>
            {
                if (User.Name.Length < 10)
                {
                    return true;
                }
                return false;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

}

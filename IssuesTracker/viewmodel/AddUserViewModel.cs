using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IssuesTracker.model;
using IssuesTracker.services;

namespace IssuesTracker.viewmodel
{
    public class AddUserViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> projectnames { get; set; }
        public SimpleCommand RegisterUserCmd { get; set; }


        private User _user;
        public User user
        {
            get { return _user; }
            set
            {
                if (_user != value)
                    _user = value;
                onpropertychanged();
            }
        }
        public AddUserViewModel()
        {
            user = new User();
            RegisterUserCmd = new SimpleCommand(RegisterUser);
            projectnames = UsersDbMethods.GetProjectNamesDb();
        }

        void RegisterUser()
        {
            if (UsersViewModel.users.Contains(user))
            {
                MessageBox.Show("this element already exist in the database");
            }

            else if (!string.IsNullOrEmpty(this.user.Name))
            {

                User user = new User()
                {
                    Name = this.user.Name,
                    AssignedProjectName = this.user.AssignedProjectName,
                    PersonPhoto = this.user.PersonPhoto,
                    RegisteredDate = this.user.RegisteredDate,
                    RegisteredPersonName = this.user.RegisteredPersonName,
                    UserEmail = this.user.UserEmail,
                    UserName = this.user.UserName,
                    UserRole = this.user.UserRole
                };


                user.UserId = UsersDbMethods.RegisterUserDb(user);
                // user.AssignedProjectName = this.user.AssignedProjectName;
                UsersViewModel.users.Add(user);
            }
            else { MessageBox.Show("choose an appropriate name for the user"); }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onpropertychanged([CallerMemberName] string propertyname = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}

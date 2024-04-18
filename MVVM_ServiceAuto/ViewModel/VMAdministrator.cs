using MVVM_ServiceAuto.ViewModel.CommandsAdministrator;
using MVVM_ServiceAuto.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_ServiceAuto.View;
using System.ComponentModel;
using MVVM_ServiceAuto.Model.Repository;

namespace MVVM_ServiceAuto.ViewModel
{
    public class VMAdministrator : INotifyPropertyChanged
    {

        private uint userID;
        private string username;
        private string password;
        private string role;
        public DataTable Users;
        private VAdministrator vAdministrator;
        private Repository repository;
        public ICommands AddUser;
        public ICommands UpdateUser;
        public ICommands DeleteUser;
        public ICommands ListUsers;
        public ICommands SearchByRole;

        public event PropertyChangedEventHandler? PropertyChanged;

        public VMAdministrator(VAdministrator vAdministrator) 
        {
            this.userID = 1;
            this.username = string.Empty;
            this.password = string.Empty;
            this.role = string.Empty;
            this.repository = new Repository();
            this.Users = repository.GetTable("SELECT * FROM [User]");
            this.vAdministrator = vAdministrator;
            this.AddUser = new AddUserCommand(this);
            this.UpdateUser = new UpdateUserCommand(this);
            //this.DeleteUser = new DeleteUserCommand(this);
            //this.ListUsers = new ListAllUsersCommand(this);
            //this.SearchByRole = new FilterByRoleCommand(this);
        }

        public uint UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

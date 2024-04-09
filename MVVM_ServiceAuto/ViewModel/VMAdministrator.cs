using MVVM_ServiceAuto.ViewModel.CommandsAdministrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel
{
    public class VMAdministrator
    {

        private uint userID;
        private string username;
        private string password;
        private string role;
        public DataTable Users;
        public ICommands AddUser;
        public ICommands UpdateUser;
        public ICommands DeleteUser;
        public ICommands ListUsers;
        public ICommands SearchByRole;

        public VMAdministrator() 
        {
            this.userID = 1;
            this.username = "mike";
            this.password = "session";
            this.role = "Administrator";
            this.Users = new DataTable();
            this.AddUser = new AddUserCommand(this);
            //this.UpdateUser = new UpdateUserCommand(this);
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
    }
}

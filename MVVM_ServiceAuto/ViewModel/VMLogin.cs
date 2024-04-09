using MVVM_ServiceAuto.ViewModel.CommandsLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel
{
    public class VMLogin
    {
        private string username;
        private string password;
        public ICommands LoginUser;

        public VMLogin()
        {
            this.username = "";
            this.password = "";
            this.LoginUser = new LoginCommand(this);
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
    }
}

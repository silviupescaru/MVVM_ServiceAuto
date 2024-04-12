using MVVM_ServiceAuto.ViewModel.CommandsLogin;
using MVVM_ServiceAuto.View;
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
        private VLogin _vLogin;
        public ICommands LoginUser;

        public VMLogin(VLogin vLogin)
        {
            this.username = "";
            this.password = "";
            _vLogin = vLogin;
            this.LoginUser = new LoginCommand(this, _vLogin);
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

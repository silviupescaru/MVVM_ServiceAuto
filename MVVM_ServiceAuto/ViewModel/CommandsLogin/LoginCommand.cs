using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.View;
using MVVM_ServiceAuto.ViewModel;
using MVVM_ServiceAuto.ViewModel.CommandsLogin;

namespace MVVM_ServiceAuto.ViewModel.CommandsLogin
{


    public class LoginCommand : Form, ICommands
    {

        private VMLogin vmLogin;
        private VLogin _vLogin;
        public LoginCommand(VMLogin vm, VLogin vLogin) 
        {
            this.vmLogin = vm;
            _vLogin = vLogin;
        }

        public void Execute(int dontCare) { }

        public void Execute()
        {
            UserRepository userRepository = new UserRepository();
            try
            {
                string username = vmLogin.Username;
                string password = vmLogin.Password;

                if (username.Length != 0 && password.Length != 0)
                {
                    bool successfulLogin = userRepository.LoginUser(username, password);
                    if (successfulLogin)
                    {
                        string role = userRepository.GetRole(username, password);
                        if (role.Equals("Employee"))
                        {
                            _vLogin.Hide();

                            VEmployee vEmployee = new VEmployee();
                            vEmployee.Show();
                        }
                        else if (role.Equals("Manager"))
                        {
                            _vLogin.Hide();

                            VManager vManager = new VManager();
                            vManager.Show();
                        }
                        else if (role.Equals("Administrator"))
                        {
                            _vLogin.Hide();

                            VAdministrator vAdministrator = new VAdministrator();
                            vAdministrator.Show();
                        }
                        //MessageBox.Show("Logged in successfully");
                    } else MessageBox.Show("Login failed!");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}

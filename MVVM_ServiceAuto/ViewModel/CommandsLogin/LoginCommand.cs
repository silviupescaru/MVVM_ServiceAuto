using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.ViewModel;
using MVVM_ServiceAuto.ViewModel.CommandsLogin;

namespace MVVM_ServiceAuto.ViewModel.CommandsLogin
{


    public class LoginCommand : ICommands
    {

        private VMLogin vmLogin;
        public LoginCommand(VMLogin vm) 
        {
            this.vmLogin = vm;
        }

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
                        //string role = userRepository.GetRole(username, password);
                        //if (role.Equals("Employee"))
                        //{
                        //    showEmployeeGUI();
                        //}
                        //else if (role.Equals("Manager"))
                        //{
                        //    showManagerGUI();
                        //}
                        //else if (role.Equals("Administrator"))
                        //{
                        //    showAdministratorGUI();
                        //}
                        MessageBox.Show("Logged in successfully");
                    } else MessageBox.Show("Login failed!");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}

using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsAdministrator
{
    public class AddUserCommand : ICommands
    {
        private VMAdministrator vmAdministrator;
        UserRepository userRepository = new UserRepository();
        Repository repository = new Repository();

        public AddUserCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                User user = this.validInformation();

                if (user != null)
                {
                    bool result = this.userRepository.AddUser(user);
                    if (result == true)
                    {
                        MessageBox.Show("Adding was successful!");
                        vmAdministrator.UserID = 1;
                        vmAdministrator.Username = string.Empty;
                        vmAdministrator.Password = string.Empty;
                        vmAdministrator.Role = string.Empty;
                        vmAdministrator.Users.Rows.Clear();
                        vmAdministrator.Users = repository.GetTable("SELECT * FROM [User]");

                        if (vmAdministrator.Users == null)
                            MessageBox.Show("There is no user in your table!");

                    }
                    else MessageBox.Show("Adding ended with failure!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private User validInformation()
        {
            Debug.Print("User ID: " + vmAdministrator.UserID);
            if (vmAdministrator.UserID == 0)
            {
                MessageBox.Show("User ID must be non-zero natural number!");
                return null;
            }
            Debug.Print("Username: " + vmAdministrator.Username);
            if (vmAdministrator.Username == null || vmAdministrator.Username.Length == 0)
            {
                MessageBox.Show("Username is empty!");
                return null;
            }
            Debug.Print("Password: " + vmAdministrator.Password);
            if (vmAdministrator.Password == null || vmAdministrator.Password.Length == 0)
            {
                MessageBox.Show("Password is empty!");
                return null;
            }
            Debug.Print("Role: " + vmAdministrator.Role);
            if (vmAdministrator.Role == null || vmAdministrator.Role.Length == 0)
            {
                MessageBox.Show("Role is empty");
                return null;
            }
            return new User(vmAdministrator.UserID, vmAdministrator.Username, vmAdministrator.Password, vmAdministrator.Role);
        }
    }
}

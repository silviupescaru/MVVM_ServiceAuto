using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.Model;   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MVVM_ServiceAuto.ViewModel.CommandsAdministrator
{
    public class FilterByRoleCommand : ICommands
    {
        private VMAdministrator vmAdministrator;
        UserRepository userRepository = new UserRepository();
        Repository repository = new Repository();

        public FilterByRoleCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string searchedRole)
        {
            try
            {
                if (vmAdministrator.Users != null)
                    vmAdministrator.Users.Rows.Clear();
                if (searchedRole != null && searchedRole.Length > 0)
                {
                    //vmAdministrator.Users = repository.GetTable("SELECT * FROM [User] where role = '" + searchedRole + "'");
                    List<User> list = this.userRepository.SearchUserByRole(searchedRole);
                    foreach (User users in list)
                    {
                        DataRow row = vmAdministrator.Users.NewRow();

                        row["userID"] = users.UserID;
                        row["username"] = users.Username;
                        row["password"] = users.Password;
                        row["role"] = users.Role;

                        vmAdministrator.Users.Rows.Add(row);
                    }
                } else MessageBox.Show("No role inserted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

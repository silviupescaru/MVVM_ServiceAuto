using MVVM_ServiceAuto.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsAdministrator
{
    public class AddUserCommand : ICommands
    {
        private VMAdministrator vmAdministrator;

        public AddUserCommand(VMAdministrator vmAdministrator)
        {
            this.vmAdministrator = vmAdministrator;
        }

        public void Execute(int dontCare) { }

        public void Execute()
        {
            UserRepository userRepository = new UserRepository();

        }
    }
}

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


    public class LogoutAdministratorCommand : ICommands
    {

        private VLogin _vLogin;
        private VAdministrator _vAdministrator;
        public LogoutAdministratorCommand(VLogin _vLogin, VAdministrator _vAdministrator)
        {
            this._vLogin = _vLogin;
            this._vAdministrator = _vAdministrator;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                _vLogin.Show();
                _vAdministrator.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

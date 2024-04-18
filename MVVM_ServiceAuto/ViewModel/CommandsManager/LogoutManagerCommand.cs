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


    public class LogoutManagerCommand : ICommands
    {

        private VLogin _vLogin;
        private VManager _vManager;
        public LogoutManagerCommand(VLogin _vLogin, VManager _vManager)
        {
            this._vLogin = _vLogin;
            this._vManager = _vManager;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                _vLogin.Show();
                _vManager.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

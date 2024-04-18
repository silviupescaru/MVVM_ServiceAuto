using MVVM_ServiceAuto.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class ListAllCarCommand : ICommands
    {
        private VMManager vmManager;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public ListAllCarCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute()
        {
            try
            {
                if (vmManager.Car != null)
                {
                    vmManager.Car.Rows.Clear();
                    vmManager.Car = this.repository.GetTable("SELECT * FROM [Car]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Execute(int dontCare) { }

        public void Execute(string dontCare) { }

    }
}

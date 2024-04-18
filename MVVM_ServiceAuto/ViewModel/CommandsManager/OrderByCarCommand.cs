using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_ServiceAuto.Model;
using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.View;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class OrderByCarCommand : ICommands
    {

        private VMManager vmManager;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public OrderByCarCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string selectedOption)
        {

            try
            {
                if (vmManager.Car != null)
                    vmManager.Car.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        //this.allCars();
                        vmManager.Car = repository.GetTable("SELECT * FROM [Car]");
                    }
                    else if (selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        //this.CarFilterByBrandFuel();
                        vmManager.Car = repository.GetTable("SELECT * FROM [Car] ORDER BY [brand], [fuel];");
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }
    }
}

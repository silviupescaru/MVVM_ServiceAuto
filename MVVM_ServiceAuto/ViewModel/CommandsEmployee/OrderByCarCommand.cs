using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_ServiceAuto.Model;
using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.View;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class OrderByCarCommand : ICommands
    {

        private VMEmployee vmEmployee;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public OrderByCarCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string selectedOption)
        {

            try
            {
                if(vmEmployee.Car != null)
                    vmEmployee.Car.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        //this.allCars();
                        vmEmployee.Car = repository.GetTable("SELECT * FROM [Car]");
                    }
                    else if (selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        //this.CarFilterByBrandFuel();
                        vmEmployee.Car = repository.GetTable("SELECT * FROM [Car] ORDER BY [brand], [fuel];");
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

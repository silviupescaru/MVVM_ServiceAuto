using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class SearchByOwnerCommand : ICommands
    {
        private VMManager vmManager;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public SearchByOwnerCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string searchedOwner)
        {
            try
            {
                vmManager.Car.Rows.Clear();
                if (searchedOwner != null && searchedOwner.Length > 0)
                {
                    List<Car> list = this.carRepository.SearchCarByOwner(searchedOwner);
                    if (list != null && list.Count > 0)
                    {
                        foreach (Car cars in list)
                        {
                            DataRow row = vmManager.Car.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            vmManager.Car.Rows.Add(row);
                        }
                    }
                    else MessageBox.Show("There is no car with desired owner!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}

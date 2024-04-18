using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using MVVM_ServiceAuto.Model;
using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.View;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class FilterByCarCommand : ICommands
    {

        private VMManager vmManager;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public FilterByCarCommand(VMManager vmManager)
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
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        vmManager.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Owner(vmManager.Owner);
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
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        vmManager.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Brand(vmManager.Brand);
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
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        vmManager.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Color(vmManager.Color);
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
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        vmManager.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Fuel(vmManager.Fuel);
                        if (list == null)
                            Debug.WriteLine("Lista nula");
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
                    else MessageBox.Show("The cars from desired filter is empty!");

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }
    }
}

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

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class FilterByCarCommand : ICommands
    {

        private VMEmployee vmEmployee;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public FilterByCarCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string selectedOption)
        {

            try
            {
                if (vmEmployee.Car != null)
                    vmEmployee.Car.Rows.Clear();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        vmEmployee.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Owner(vmEmployee.Owner);
                        foreach(Car cars in list)
                        {
                            DataRow row = vmEmployee.Car.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            vmEmployee.Car.Rows.Add(row);
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        vmEmployee.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Brand(vmEmployee.Brand);
                        foreach (Car cars in list)
                        {
                            DataRow row = vmEmployee.Car.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            vmEmployee.Car.Rows.Add(row);
                        }
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        vmEmployee.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Color(vmEmployee.Color);
                        foreach (Car cars in list)
                        {
                            DataRow row = vmEmployee.Car.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            vmEmployee.Car.Rows.Add(row);
                        }
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        vmEmployee.Car.Rows.Clear();
                        List<Car> list = this.carRepository.CarList_Fuel(vmEmployee.Fuel);
                        if (list == null)
                            Debug.WriteLine("Lista nula");
                        foreach (Car cars in list)
                        {
                            DataRow row = vmEmployee.Car.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            vmEmployee.Car.Rows.Add(row);
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

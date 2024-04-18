﻿using MVVM_ServiceAuto.Model.Repository;
using MVVM_ServiceAuto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class SearchByOwnerCommand : ICommands
    {
        private VMEmployee vmEmployee;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public SearchByOwnerCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute() { }
        public void Execute(int dontCare) { }

        public void Execute(string searchedOwner)
        {
            try
            {
                vmEmployee.Car.Rows.Clear();
                if (searchedOwner != null && searchedOwner.Length > 0)
                {
                    List<Car> list = this.carRepository.SearchCarByOwner(searchedOwner);
                    if (list != null && list.Count > 0)
                    {
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
                    } else MessageBox.Show("There is no car with desired owner!");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}

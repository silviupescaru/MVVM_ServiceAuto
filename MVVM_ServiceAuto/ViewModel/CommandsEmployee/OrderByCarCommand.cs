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

        public void Execute(int selectedCar)
        {

            try
            {
                vmEmployee.Car.Rows.Clear();
                string selectedOption = this.iEmployeeGUI.GetSelectedCriterion();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "ALL")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        this.allCars();
                    }
                    else if (selectedOption.ToUpper() == "FILTER BY BRAND AND FUEL")
                    {
                        this.iEmployeeGUI.SetVisibility(true);
                        this.CarFilterByBrandFuel();
                    }

                }
                else
                    this.iEmployeeGUI.SetVisibility(true);
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Cars - Exception", exception.ToString());
            }

        }

        private Car validInformation()
        {
            uint id = vmEmployee.CarID;
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                MessageBox.Show("Car ID must be non-zero natural number!");
                return null;
            }
            string owner = vmEmployee.Owner;
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                MessageBox.Show("Car Owner is empty!");
                return null;
            }
            string brand = vmEmployee.Brand;
            Debug.Print("Car Brand: " + brand);
            if (brand == null || brand.Length == 0)
            {
                MessageBox.Show("Car Brand is empty!");
                return null;
            }
            string color = vmEmployee.Color;
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                MessageBox.Show("Car Color is empty");
                return null;
            }
            string fuel = vmEmployee.Fuel;
            Debug.Print("Car Fuel: " + fuel);
            if (fuel == null || fuel.Length == 0)
            {
                MessageBox.Show("Car Fuel is empty");
                return null;
            }
            return new Car(id, owner, brand, color, fuel);
        }
    }
}

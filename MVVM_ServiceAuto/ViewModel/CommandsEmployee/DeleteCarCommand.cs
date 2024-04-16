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
    public class DeleteCarCommand : ICommands
    {

        private VMEmployee vmEmployee;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public DeleteCarCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute() { }
        public void Execute(string dontCare) { }

        public void Execute(int selectedCar)
        {

            try
            {
                if (Convert.ToBoolean(selectedCar))
                {
                    uint selectedID = Convert.ToUInt32(vmEmployee.CarID);
                    bool result = this.carRepository.DeleteCar(selectedID);
                    if (result)
                    {
                        MessageBox.Show("Deleting was successfull!");
                        vmEmployee.CarID = 1;
                        vmEmployee.Owner = string.Empty;
                        vmEmployee.Brand = string.Empty;
                        vmEmployee.Color = string.Empty;
                        vmEmployee.Fuel = string.Empty;
                        vmEmployee.Car.Rows.Clear();
                        vmEmployee.Car = repository.GetTable("SELECT * FROM [Car]");

                    }
                    else
                        MessageBox.Show("Deletion was ended with failure!");
                }
                else
                    MessageBox.Show("No car has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
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

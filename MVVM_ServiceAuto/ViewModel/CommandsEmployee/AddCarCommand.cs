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
    public class AddCarCommand : Form, ICommands
    {

        private VMEmployee vmEmployee;
        private VEmployee _vEmployee;

        public AddCarCommand(VMEmployee vmEmployee, VEmployee vEmployee)
        {
            this.vmEmployee = vmEmployee;
            _vEmployee = vEmployee;
        }

        public void Execute()
        {
            CarRepository carRepository = new CarRepository();

            try
            {
                Car car = this.validInformation();
                if (car != null)
                {
                    bool result = this.carRepository.AddCar(car);
                    if (result)
                    {
                        this.iEmployeeGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.resetDoctorControls();
                        this.iEmployeeGUI.ResetDgvCarTable();
                        this.LoadCarTable();
                    }
                    else
                        this.iEmployeeGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Add - Exception", exception.ToString());
            }

        }

        private Car validInformation()
        {
            uint id = this.iEmployeeGUI.GetCarID();
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car ID must be non-zero natural number!");
                return null;
            }
            string owner = this.iEmployeeGUI.GetOwner();
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Owner is empty!");
                return null;
            }
            string brand = this.iEmployeeGUI.GetBrand();
            Debug.Print("Car Brand: " + brand);
            if (brand == null || brand.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Brand is empty!");
                return null;
            }
            string color = this.iEmployeeGUI.GetColor();
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Color is empty");
                return null;
            }
            string fuel = this.iEmployeeGUI.GetFuel();
            Debug.Print("Car Fuel: " + fuel);
            if (fuel == null || fuel.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Car Fuel is empty");
                return null;
            }
            return new Car(id, owner, brand, color, fuel);
        }
    }
}

using MVVM_ServiceAuto.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class ListAllCarCommand : ICommands
    {
        private VMEmployee vmEmployee;
        CarRepository carRepository = new CarRepository();
        Repository repository = new Repository();

        public ListAllCarCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute() 
        {
            try
            {
                if (vmEmployee.Car != null)
                {
                    vmEmployee.Car.Rows.Clear();
                    vmEmployee.Car = this.repository.GetTable("SELECT * FROM [Car]");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Execute(int dontCare) { }

        public void Execute(string dontCare) { }

    }
}

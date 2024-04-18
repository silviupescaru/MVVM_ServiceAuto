using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class SaveXMLCommand : ICommands
    {
        private VMEmployee vmEmployee;

        public SaveXMLCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }
        public void Execute()
        {
            try
            {
                if (vmEmployee != null)
                {
                    vmEmployee.Car.TableName = "Cars";
                    vmEmployee.Car.WriteXml("E:\\Facultate\\III\\PS\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.xml");
                    MessageBox.Show("File saved successfully!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

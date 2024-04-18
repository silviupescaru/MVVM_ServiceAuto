using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class SaveXMLCommand : ICommands
    {
        private VMManager vmManager;

        public SaveXMLCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }
        public void Execute()
        {
            try
            {
                if (vmManager != null)
                {
                    vmManager.Car.TableName = "Cars";
                    vmManager.Car.WriteXml("D:\\Facultate\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.xml");
                    MessageBox.Show("File saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

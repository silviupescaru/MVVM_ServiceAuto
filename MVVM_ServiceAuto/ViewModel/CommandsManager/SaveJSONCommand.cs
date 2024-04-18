using MVVM_ServiceAuto.Model.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class SaveJSONCommand : ICommands
    {
        private VMManager vmManager;

        public SaveJSONCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                if (vmManager.Car != null)
                {

                    JsonSerializer serializer = new JsonSerializer
                    {
                        Formatting = Formatting.Indented
                    };

                    using (StreamWriter sw = new StreamWriter("D:\\Facultate\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.json"))
                    using (JsonTextWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, vmManager.Car);
                    }
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

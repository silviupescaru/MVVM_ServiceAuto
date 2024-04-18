using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class SaveCSVCommand : ICommands
    {
        private VMManager vmManager;

        public SaveCSVCommand(VMManager vmManager)
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
                    StringBuilder sb = new StringBuilder();

                    IEnumerable<string> columnNames = vmManager.Car.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in vmManager.Car.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText("E:\\Facultate\\III\\PS\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.csv", sb.ToString());
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

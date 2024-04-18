using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class SaveCSVCommand : ICommands
    {
        private VMEmployee vmEmployee;

        public SaveCSVCommand(VMEmployee vmEmployee)
        {
            this.vmEmployee = vmEmployee;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                if(vmEmployee.Car != null)
                {
                    StringBuilder sb = new StringBuilder();

                    IEnumerable<string> columnNames = vmEmployee.Car.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in vmEmployee.Car.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText("E:\\Facultate\\III\\PS\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.csv", sb.ToString());
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

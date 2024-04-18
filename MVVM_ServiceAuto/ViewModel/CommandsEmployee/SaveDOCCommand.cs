using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MVVM_ServiceAuto.ViewModel.CommandsEmployee
{
    public class SaveDOCCommand : ICommands
    {
        private VMEmployee vmEmployee;

        public SaveDOCCommand(VMEmployee vmEmployee)
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
                    using (DocX document = DocX.Create("D:\\Facultate\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.docx"))
                    {
                        Table t = document.AddTable(vmEmployee.Car.Rows.Count, vmEmployee.Car.Columns.Count);

                        for (int i = 0; i < vmEmployee.Car.Rows.Count; i++)
                        {
                            for (int j = 0; j < vmEmployee.Car.Columns.Count; j++)
                            {
                                t.Rows[i].Cells[j].Paragraphs.First().Append(vmEmployee.Car.Rows[i][j].ToString());
                            }
                        }

                        document.InsertTable(t);
                        document.Save();




                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

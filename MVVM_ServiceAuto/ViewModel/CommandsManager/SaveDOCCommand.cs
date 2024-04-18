using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MVVM_ServiceAuto.ViewModel.CommandsManager
{
    public class SaveDOCCommand : ICommands
    {
        private VMManager vmManager;

        public SaveDOCCommand(VMManager vmManager)
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
                    using (DocX document = DocX.Create("E:\\Facultate\\III\\PS\\MVVM_ServiceAuto\\MVVM_ServiceAuto\\exports\\cars.docx"))
                    {
                        Table t = document.AddTable(vmManager.Car.Rows.Count, vmManager.Car.Columns.Count);

                        for (int i = 0; i < vmManager.Car.Rows.Count; i++)
                        {
                            for (int j = 0; j < vmManager.Car.Columns.Count; j++)
                            {
                                t.Rows[i].Cells[j].Paragraphs.First().Append(vmManager.Car.Rows[i][j].ToString());
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

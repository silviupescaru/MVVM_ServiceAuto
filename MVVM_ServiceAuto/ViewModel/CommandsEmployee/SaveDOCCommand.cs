using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Diagnostics;

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
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                    saveFileDialog.DefaultExt = "docx";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Create(saveFileDialog.FileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = document.AddMainDocumentPart();
                            mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                            DocumentFormat.OpenXml.Wordprocessing.Body body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                            Table t = new Table();
                            Debug.WriteLine("Save DOC Flowers Rows Number: " + vmEmployee.Car.Rows.Count + '\n');

                            for (int i = 0; i < vmEmployee.Car.Rows.Count; i++)
                            {
                                TableRow row = new TableRow();

                                for (int j = 0; j < vmEmployee.Car.Columns.Count; j++)
                                {
                                    TableCell cell = new TableCell();
                                    Debug.WriteLine("Cells: " + vmEmployee.Car.Rows[i][j].ToString() + '\n');
                                    cell.Append(new Paragraph(new Run(new Text(vmEmployee.Car.Rows[i][j].ToString()))));
                                    row.Append(cell);
                                }

                                t.Append(row);
                            }

                            body.Append(t);
                            document.Save();
                            MessageBox.Show("File saved successfully!");
                        }
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

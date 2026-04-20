using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
namespace ExecutiveSceinceAccadmy.classes
{
    public  static  class ExcelFileEngine
    {
        public static void ExportExpenseToExcel(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.Title = "Save Expense Report";
            sfd.FileName = "ExpenseReport.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Expense Report");

                    // Headers
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        ws.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                        ws.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // Data
                    int rowIndex = 2;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            ws.Cell(rowIndex, col + 1).Value =
                                row.Cells[col].Value?.ToString();
                        }

                        rowIndex++;
                    }

                    ws.Columns().AdjustToContents();

                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Excel Exported Successfully!");
            }
        }
    }
    
    
}

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

                    // ── HEADER ROW ──────────────────────────────────────────────
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        var headerCell = ws.Cell(1, col + 1);
                        headerCell.Value = dgv.Columns[col].HeaderText;
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Font.FontColor = XLColor.White;
                        headerCell.Style.Fill.BackgroundColor = XLColor.RoyalBlue;
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }

                    // ── DATA ROWS ────────────────────────────────────────────────
                    // Find expenseAmount and expenseMonth column indexes
                    int amountColIndex = -1;
                    int monthColIndex = -1;
                    for (int c = 0; c < dgv.Columns.Count; c++)
                    {
                        string name = dgv.Columns[c].Name.ToLower();
                        if (name.Contains("amount")) amountColIndex = c;
                        if (name.Contains("month")) monthColIndex = c;
                    }

                    // Build month → total dictionary while writing rows
                    var monthTotals = new Dictionary<string, decimal>();
                    int rowIndex = 2;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            var cell = ws.Cell(rowIndex, col + 1);
                            cell.Value = row.Cells[col].Value?.ToString();
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            // Alternating row color
                            if (rowIndex % 2 == 0)
                                cell.Style.Fill.BackgroundColor = XLColor.FromArgb(240, 245, 255);
                        }

                        // Accumulate month totals
                        if (amountColIndex >= 0 && monthColIndex >= 0)
                        {
                            string month = row.Cells[monthColIndex].Value?.ToString() ?? "Unknown";
                            decimal amount = 0;
                            decimal.TryParse(row.Cells[amountColIndex].Value?.ToString(), out amount);

                            if (!monthTotals.ContainsKey(month))
                                monthTotals[month] = 0;
                            monthTotals[month] += amount;
                        }

                        rowIndex++;
                    }

                    ws.Columns().AdjustToContents();

                    // ── SUMMARY TABLE ────────────────────────────────────────────
                    if (monthTotals.Count > 0)
                    {
                        int summaryStartRow = rowIndex + 2; // leave one blank row gap
                        int summaryStartCol = 1;

                        // Summary title
                        var titleCell = ws.Cell(summaryStartRow, summaryStartCol);
                        titleCell.Value = "Monthly Expense Summary";
                        titleCell.Style.Font.Bold = true;
                        titleCell.Style.Font.FontSize = 13;
                        titleCell.Style.Font.FontColor = XLColor.White;
                        titleCell.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                        titleCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Range(summaryStartRow, summaryStartCol, summaryStartRow, summaryStartCol + 1).Merge();

                        summaryStartRow++;

                        // Summary column headers
                        var mHeader = ws.Cell(summaryStartRow, summaryStartCol);
                        mHeader.Value = "Month";
                        mHeader.Style.Font.Bold = true;
                        mHeader.Style.Font.FontColor = XLColor.White;
                        mHeader.Style.Fill.BackgroundColor = XLColor.RoyalBlue;
                        mHeader.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        var aHeader = ws.Cell(summaryStartRow, summaryStartCol + 1);
                        aHeader.Value = "Total Amount";
                        aHeader.Style.Font.Bold = true;
                        aHeader.Style.Font.FontColor = XLColor.White;
                        aHeader.Style.Fill.BackgroundColor = XLColor.RoyalBlue;
                        aHeader.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        summaryStartRow++;

                        // Month rows
                        decimal grandTotal = 0;
                        int summaryDataStartRow = summaryStartRow;
                        int colorToggle = 0;

                        foreach (var kvp in monthTotals.OrderBy(k => k.Key))
                        {
                            var monthCell = ws.Cell(summaryStartRow, summaryStartCol);
                            monthCell.Value = kvp.Key;
                            monthCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            var amtCell = ws.Cell(summaryStartRow, summaryStartCol + 1);
                            amtCell.Value = kvp.Value;
                            amtCell.Style.NumberFormat.Format = "#,##0.00";
                            amtCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            // Alternating colors
                            XLColor rowColor = colorToggle % 2 == 0
                                ? XLColor.FromArgb(240, 245, 255)
                                : XLColor.White;
                            monthCell.Style.Fill.BackgroundColor = rowColor;
                            amtCell.Style.Fill.BackgroundColor = rowColor;

                            grandTotal += kvp.Value;
                            summaryStartRow++;
                            colorToggle++;
                        }

                        // Grand total row
                        var totalLabelCell = ws.Cell(summaryStartRow, summaryStartCol);
                        totalLabelCell.Value = "GRAND TOTAL";
                        totalLabelCell.Style.Font.Bold = true;
                        totalLabelCell.Style.Font.FontColor = XLColor.White;
                        totalLabelCell.Style.Fill.BackgroundColor = XLColor.DarkGreen;
                        totalLabelCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        var totalAmtCell = ws.Cell(summaryStartRow, summaryStartCol + 1);
                        totalAmtCell.Value = grandTotal;
                        totalAmtCell.Style.Font.Bold = true;
                        totalAmtCell.Style.Font.FontColor = XLColor.White;
                        totalAmtCell.Style.Fill.BackgroundColor = XLColor.DarkGreen;
                        totalAmtCell.Style.NumberFormat.Format = "#,##0.00";
                        totalAmtCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Border around entire summary table
                        var summaryRange = ws.Range(
                            summaryStartRow - monthTotals.Count - 2,  // title row
                            summaryStartCol,
                            summaryStartRow,
                            summaryStartCol + 1
                        );
                        summaryRange.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                        summaryRange.Style.Border.OutsideBorderColor = XLColor.RoyalBlue;
                        summaryRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        summaryRange.Style.Border.InsideBorderColor = XLColor.FromArgb(200, 200, 200);

                        // Auto fit summary columns
                        ws.Column(summaryStartCol).AdjustToContents();
                        ws.Column(summaryStartCol + 1).AdjustToContents();
                    }

                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("✓ Excel Exported Successfully!", "Export Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
    
}

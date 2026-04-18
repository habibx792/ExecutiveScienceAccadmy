using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    public abstract  class ExcelFileEngine
    {
        public  virtual void generateExcelReport() { }
    }
    public  class expenseExfileProcessor: ExcelFileEngine
    {

    }
    public class feeReportExcelFillProcessor: ExcelFileEngine
    {
        public override void generateExcelReport() { }
    }
    public class salaryExcelFileProcessor:ExcelFileEngine
    {
        public override void generateExcelReport() { }
    }
}

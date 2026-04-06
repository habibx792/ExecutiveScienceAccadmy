using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    public abstract  class excelFileProcessor
    {
        public  virtual void generateExcelReport() { }
    }
    public  class expenseExfileProcessor: excelFileProcessor
    {

    }
    public class feeReportExcelFillProcessor:excelFileProcessor
    {
        public override void generateExcelReport() { }
    }
    public class salaryExcelFileProcessor:excelFileProcessor
    {
        public override void generateExcelReport() { }
    }
}

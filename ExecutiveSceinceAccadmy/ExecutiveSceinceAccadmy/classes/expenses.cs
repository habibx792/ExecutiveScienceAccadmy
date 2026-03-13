using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class expenses
    {
        private string expenseId;
        private string expenseType;
        private double expenseAmount;
        private string expenseDate;
        private string expenseMonth;
        public expenses(string expenseId, string expenseType, double expenseAmount, string expenseDate, string expenseMonth)
        {
            this.expenseId = expenseId;
            this.expenseType = expenseType;
            this.expenseAmount = expenseAmount;
            this.expenseDate = expenseDate;
            this.expenseMonth = expenseMonth;
        }
        public string ExpenseId { get => expenseId; set => expenseId = value; }
        public string ExpenseType { get => expenseType; set => expenseType = value; }
        public double ExpenseAmount { get => expenseAmount; set => expenseAmount = value; }
        public string ExpenseDate { get => expenseDate; set => expenseDate = value; }
        public string ExpenseMonth { get => expenseMonth; set => expenseMonth = value; }
        

    }
}

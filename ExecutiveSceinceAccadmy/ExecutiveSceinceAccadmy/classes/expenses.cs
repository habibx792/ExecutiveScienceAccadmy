using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    public class expenses
    {
        private string expenseId;
        private string expenseType;
        private double expenseAmount;
        private DateTime expenseDate;
        private string description;
        private string expenseMonth;
        public expenses(string expenseId, string expenseType, double expenseAmount, DateTime expenseDate, string description, string expenseMonth)
        {
            this.expenseId = expenseId;
            this.expenseType = expenseType;
            this.expenseAmount = expenseAmount;
            this.expenseDate = expenseDate;
            this.description = description;
            this.expenseMonth = expenseMonth;
        }
        public string ExpenseId { get => expenseId; set => expenseId = value; }
        public string ExpenseType { get => expenseType; set => expenseType = value; }
        public double ExpenseAmount { get => expenseAmount; set => expenseAmount = value; }
        public DateTime ExpenseDate { get => expenseDate; set => expenseDate = value; }
        public string Description { get => description; set => description = value; }
        public string ExpenseMonth { get => expenseMonth; set => expenseMonth = value; }
        

    }
}

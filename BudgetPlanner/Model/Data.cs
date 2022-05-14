using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner.Model
{
    class Data
    {
        public ushort Id { get; set; }
        public string ElementIncome { get; set; }
        public string ElementExpenses { get; set; }
        public int InCash { get; set; }
        public int OutCash { get; set; }
        public DateTime DateAddCash { get; set; }
        public DateTime DateRemoveCash { get; set; }
        public int ResultIncome { get; set; }
        public int ResultExpenses { get; set; }
    }
}

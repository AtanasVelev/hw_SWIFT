using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Example
{
    class BankAccounts
    {
        public int Id{ get; set; }
        public string AccountName { get; set; }
        public int Sum { get; set; }
        public int UserId { get; set; }

        public bool IsCurrent { get; set; }

    }
}

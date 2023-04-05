using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Code
{
    public class HistoryColumn
    {

        [ExcelColumn("NAME")]
        public string Name { get; set; }
        [ExcelColumn("SCORE")]
        public string Score { get; set; }
        [ExcelColumn("DATE")]
        public string Date { get; set; }
   
    }
}

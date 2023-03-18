using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.View;
using LinqToExcel;
using LinqToExcel.Attributes;

namespace test.Code
{
    public class TestColumns
    {
        [ExcelColumn("ID")] 
        public int ID { get; set; }
        [ExcelColumn("CONTENT")]
        public string Content { get; set; }
        [ExcelColumn("ANSWER1")]
        public string Answer1 { get; set; }
        [ExcelColumn("ANSWER2")]
        public string Answer2 { get; set; }
        [ExcelColumn("ANSWER3")]
        public string Answer3 { get; set; }
        [ExcelColumn("ANSWER3")]
        public string Answer4 { get; set; }
        [ExcelColumn("CORRECT_ANSWER")]
        public string CorrectAnswer { get;set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Code
{
    public class TestModel
    {
        private int id;
        private string content;
        private string ansOne;
        private string ansTwo;
        private string ansThree;
        private string ansFour;
        private string ansCorrect;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string AnsOne
        {
            get { return ansOne; }
            set { ansOne = value; }
        }
        public string AnsTwo
        {
            get { return ansTwo; }
            set { ansTwo = value; }
        }
        public string AnsThree
        {
            get { return ansThree; }
            set { ansThree = value; }
        }

        public string AnsFour
        {
            get { return ansFour; }
            set { ansFour = value; }
        }
        public string AnsCorrect
        {
            get { return ansCorrect; }
            set { ansCorrect = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public TestModel(int id,string content,string ansOne,string ansTwo,string ansThree,string ansFour,string ansCorrect) 
        { 
            this.id = id;
            this.content = content;
            this.ansOne = ansOne;
            this.ansTwo = ansTwo;
            this.ansThree = ansThree;
            this.ansFour = ansFour;
            this.ansCorrect = ansCorrect;
        }
    }
}

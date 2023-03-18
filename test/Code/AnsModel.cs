using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Code
{
    public class AnsModel
    {
        private int ansId;
        private string userAns;
        private string ansCorrect;
        private string rBSelected;
        public string UserAns
        {
            get { return userAns; }
            set { userAns = value; }
        }
        public string AnsCorrect
        {
            get { return ansCorrect; }
            set { ansCorrect = value; }
        }
        public string RBSelected
        {
            get { return rBSelected; }
            set { rBSelected = value; }
        }
        public int AnsId
        {
            get { return ansId; }
            set { ansId = value; }
        }
        public AnsModel(int ansId, string userAns, string ansCorrect, string rBSelected)
        {
            this.ansId = ansId;
            this.userAns = userAns;
            this.ansCorrect = ansCorrect;
            this.rBSelected = rBSelected;
        }
    }
}

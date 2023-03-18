using Guna.UI2.WinForms;
using LinqToExcel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Code;
using static Guna.UI2.Native.WinApi;
using static OfficeOpenXml.ExcelErrorValue;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test.View
{
    public partial class Exam : Form
    {
        //Utility
        private AnsModel mapAnswerItem;
        MessageBoxCus messageBoxCus = new MessageBoxCus();

        //Property
        private int indexPageCurrent = 0;
        private int ansNumber = 0;//các giá trị arrContol bắt đầu từ 0, nên ansNumber cũng vậy
        private string selectedAns;
        private bool isGoBack = false;
        private int point = 0;
        private int totalPoint = 0;
        private int minutes = 0; //= int.Parse(lbCountdown.Text.Substring(0, 2));
        private int seconds = 60;// = int.Parse(lbCountdown.Text.Substring(5, 7));

        //Manager Model
        private List<TestModel> tests = new List<TestModel>();//list ques
        private List<AnsModel> answers = new List<AnsModel>();//listAns

        //List Manager Control
        private List<Guna2PictureBox> arrPictureBoxTick= new List<Guna2PictureBox>();
        private List<System.Windows.Forms.Label> arrLabel= new List<System.Windows.Forms.Label>();
        private List<Guna2GradientPanel> arrGradientPanel= new List<Guna2GradientPanel>();
        private List<Guna2CustomRadioButton> arrRadioButton = new List<Guna2CustomRadioButton>();

        public List<TestModel> Tests
        {
            set { tests = value; }
        }
        public Exam()
        {
            InitializeComponent();

        }



        public bool WarningMessage(string mess= "Are you sure you want to exit now?")
        {
            messageBoxCus.InitModeWarning();
            messageBoxCus.Content = mess;
            messageBoxCus.ShowDialog();

            return messageBoxCus.OK ? true : false;
        }
        public void InitDataTests()
        {
            btQuestion.Text = btQuestion.Text.Substring(0, 9) + tests[indexPageCurrent].Id;
            content.Text = tests[indexPageCurrent].Content;
            ans1.Text = tests[indexPageCurrent].AnsOne;
            ans2.Text = tests[indexPageCurrent].AnsTwo;
            ans3.Text = tests[indexPageCurrent].AnsThree;
            ans4.Text = tests[indexPageCurrent].AnsFour;
        }
        public bool CheckChecked()
        {
             //xử lý các controls
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2CustomRadioButton radioButton && radioButton.Checked  )
                {
                    return true;
                }
            }
            return false;
        }
        public void AddAns()
        {
            //xử lý các controls
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2CustomRadioButton radioButton && radioButton.Checked )
                {
                    mapAnswerItem = new AnsModel(ansNumber, selectedAns, tests[indexPageCurrent].AnsCorrect, radioButton.Name);
                    answers.Add(mapAnswerItem);
                }
            }
        }
        public AnsModel GetCheckedAnswer()
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2CustomRadioButton radioButton && radioButton.Checked)
                {
                    mapAnswerItem = new AnsModel(ansNumber, selectedAns, tests[indexPageCurrent].AnsCorrect, radioButton.Name);
                }
            }
            return mapAnswerItem;
        }
        //dùng ở hàm Changechecked nếu change thì radioButton đó ẩn đi, còn dùng ở hàm Next thì reset controls
        public void ResetControl(bool next = false)
        {
            //xử lý các controls
            foreach (Control control in panel.Controls)
            {
                //ẩn tất cả tick, trừ clock
                if (control is Guna2PictureBox pictureBox)
                {
                    if (pictureBox.Name != "ptCountdown")
                        pictureBox.Visible = false;
                }

                if (control is Guna2CustomRadioButton radioButton)
                {
                    if (next)
                    {
                        radioButton.Checked = false;
                        radioButton.Visible = true;
                    }
                    radioButton.Visible = radioButton.Checked ? false : true;
                }

                if (control is Guna2GradientPanel childPanel)//childPanel là biến đại diện cho một control của kiểu Panel trong danh sách các controls con của parentPanel.
                {
                    //bỏ qua border question
                    if (childPanel.Name != "pnQues")
                        //đưa về màu border mặc định
                        childPanel.BorderColor = ColorTranslator.FromHtml("#3A98B9");
                }

                if (control is System.Windows.Forms.Label label)
                {
                    label.ForeColor = ColorTranslator.FromHtml("#0E8388");
                }
            }
        }

        public void RestoreChecked()
        {
            ResetControl();
            int useCheckedCurrent= answers[indexPageCurrent].AnsId;

            arrLabel[useCheckedCurrent].ForeColor = ColorTranslator.FromHtml("#62CDFF");
            arrPictureBoxTick[useCheckedCurrent].Visible = true;
            arrRadioButton[useCheckedCurrent].Visible = false;
            arrRadioButton[useCheckedCurrent].Checked = true;
            arrGradientPanel[useCheckedCurrent].BorderColor = ColorTranslator.FromHtml("#62CDFF");

            //MessageBox.Show("Restore");
        }
       





        ///                            EVENT                //


        private void Exam_Load(object sender, EventArgs e)
        {
            minutes = tests.Count-1;//ví dụ 25 câu thì minute bắt đầu là 24 giây là 60=> 24:60
            string timeText = (minutes+1).ToString("00") + " : 00" ;
            lbCountdown.Text = timeText;

            btPrevious.Visible = false;
            btSubmit.Visible = false;

            //getControls into List
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2PictureBox pictureBox)
                {
                    if (pictureBox.Name != "ptCountdown")
                        arrPictureBoxTick.Add(pictureBox);
                }

                if (control is Guna2CustomRadioButton radioButton)
                    arrRadioButton.Add(radioButton);

                if (control is Guna2GradientPanel panel)//childPanel là biến đại diện cho một control của kiểu Panel trong danh sách các controls con của parentPanel.
                {
                    if (panel.Name != "pnQues")
                        arrGradientPanel.Add(panel);
                }

                if (control is System.Windows.Forms.Label label)
                {
                    if(label.Name!= "lbCountdown")
                        arrLabel.Add(label);
                }
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            if (WarningMessage()==false)
                return;

            timer1.Enabled=false;
            this.Close();

            Main main = new Main();
            main.ShowDialog();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (WarningMessage())
                Application.Exit();
        }
       
        //Chú ý CheckedChange gọi khi radioButton được checked và unchecked
        private void radioBt_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomRadioButton radioButton = ((Guna2CustomRadioButton)sender);
            string nameRadioBt = radioButton.Name;
            ResetControl();

            //Nếu Nó Checked thì mới xử lý, nếu không thì không checked nó cũng xử lý sự kiện styles
            if (radioButton.Checked)
            {

                switch (nameRadioBt)
                {
                    case "radioBt1":
                        {
                            tick1.Visible = true;
                            panelAns1.BorderColor = ColorTranslator.FromHtml("#62CDFF");
                            lbA.ForeColor = ColorTranslator.FromHtml("#62CDFF");

                            ansNumber=0;
                            selectedAns = "A";
                        }
                        break;
                    case "radioBt2":
                        {
                            tick2.Visible = true;
                            panelAns2.BorderColor = ColorTranslator.FromHtml("#62CDFF");
                            lbB.ForeColor = ColorTranslator.FromHtml("#62CDFF");

                            ansNumber = 1;
                            selectedAns = "B";
                        }
                        break;
                    case "radioBt3":
                        {
                            tick3.Visible = true;
                            panelAns3.BorderColor = ColorTranslator.FromHtml("#62CDFF");
                            lbC.ForeColor = ColorTranslator.FromHtml("#62CDFF");

                            ansNumber = 2;
                            selectedAns = "C";
                        }
                        break;
                    case "radioBt4":
                        {
                            tick4.Visible = true;
                            panelAns4.BorderColor = ColorTranslator.FromHtml("#62CDFF");
                            lbD.ForeColor = ColorTranslator.FromHtml("#62CDFF");

                            ansNumber = 3;
                            selectedAns = "D";
                        }
                        break;
                    default:
                        break;
                }
            }
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;

            if (seconds == 0 && minutes == 0)
            {
                ptCountdown.Visible = false;
                ptTimeout.Visible = true;
                lbCountdown.Visible = false;
                timer1.Enabled = false;

                messageBoxCus.InitModeTimeOut();
                messageBoxCus.ShowDialog();

                btBack.Enabled = false;
                btNext.Enabled = false;
                btSubmit.Enabled = false;
            }
            if (seconds == 0)
            {
                seconds = 59;
                minutes--;
            }

            // "00" EX:minutes là 5, thì kết quả sau khi định dạng sẽ là chuỗi "05"
            string timeText = minutes.ToString("00") + " : " + seconds.ToString("00");
            lbCountdown.Text = timeText;
        }
        private void btPrevious_Click(object sender, EventArgs e)
        {
            //trường hợp ở page mới nhất và đã checked
            if(indexPageCurrent==answers.Count && CheckChecked())
                AddAns();


            //sữa giá trị in isGoBack
            if(isGoBack)
                answers[indexPageCurrent] = GetCheckedAnswer();

            this.indexPageCurrent--;

            isGoBack = true;

                            label4.Text = (answers.Count).ToString();
                            label5.Text = indexPageCurrent.ToString();

                            string s = "";
                            foreach (AnsModel ans in answers)
                            {
                                s+= $" {ans.AnsId} {ans.UserAns} {ans.AnsCorrect} {ans.RBSelected} |";
                            }
                            lbAns.Text = s;

            //khôi phục các checked
            RestoreChecked();

            //kiểm tra chuyển trang
            //case chỉ còn 1 item
            if (indexPageCurrent == 0)
            {
                btPrevious.Visible = false;
                btNext.Visible = true;
            }
            //case có 2 giá item
            else if (indexPageCurrent == 1)
            {
                btPrevious.Visible = true;
            }
            //trường hợp nhiều indexPageCurrent nhỏ hơn số lượng Tests
            else if (indexPageCurrent <tests.Count-1)
            {
                btNext.Visible = true;
            }
            
                            lbGoBack.Text = isGoBack.ToString();

            //khởi tạo dữ liệu
            InitDataTests();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            //sữa giá trị in isGoBack
            if(isGoBack)
                answers[indexPageCurrent] = GetCheckedAnswer();
            
            //nếu isGoBack thì không thêm Checked
            if (!isGoBack )
                AddAns();

            this.indexPageCurrent++;

            if (isGoBack && indexPageCurrent != answers.Count)
                    RestoreChecked();

            if (CheckChecked() == false || !isGoBack && (answers.Count) == (indexPageCurrent+1))//trong truường hợp Previous rồi Next thì bỏ qua những RBSelected
            {
                messageBoxCus.Content = "You haven't selected any option";
                messageBoxCus.ShowDialog();
                this.indexPageCurrent--;
                return;
            }

            label4.Text = (answers.Count).ToString();
                            label5.Text = indexPageCurrent.ToString();

                            string s = "";
                            foreach (AnsModel ans in answers)
                            {
                                s += $"{ans.AnsId} {ans.UserAns} {ans.AnsCorrect} {ans.RBSelected} |";
                            }
                            lbAns.Text = s;

            //kiểm tra chuyển trang
            //trường hợp = max amount tests
            if (indexPageCurrent == (tests.Count - 1))
            {
                btNext.Visible = false;
            }
            //trường hợp có 2 item trong tests
            else if (indexPageCurrent == 1)
            {
                btPrevious.Visible = true;
            }
                
            //nếu đang ở page mới nhất và chưa checked
            //( dành cho trường hợp isGoBack, Next đến Page mới nhất thì gán thành false)
            if(isGoBack && indexPageCurrent == answers.Count)
                isGoBack = false;

                            lbGoBack.Text = isGoBack.ToString();

            //nếu isGoBack thì chạy hàm ResetChecked ở trên
            //và bỏ qua hàm làm mới Control(ResetControl)
            if (!isGoBack)
                ResetControl(true);
            
            InitDataTests();
            if(tests.Count-1==answers.Count)
                btSubmit.Visible = true;
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {

            //trường hợp ở page mới nhất và đã checked
            if (indexPageCurrent == answers.Count && CheckChecked())
                AddAns();

            //kiểm tra xem điền hết đáp án chưa
            if(tests.Count> answers.Count)
            {
                WarningMessage("You haven't finished the test yet");
                return;
            }

            //sữa giá trị in isGoBack
            if (isGoBack)
                answers[indexPageCurrent] = GetCheckedAnswer();

                            label4.Text = (answers.Count).ToString();
                            label5.Text = indexPageCurrent.ToString();

                            string s = "";
                            foreach (AnsModel ans in answers)
                            {
                                s += $"{ans.AnsId} {ans.UserAns} {ans.AnsCorrect} {ans.RBSelected} |";
                            }
                            lbAns.Text = s;

            answers.ForEach(ans =>
            {
                if (ans.UserAns == ans.AnsCorrect)
                {
                    point += 150;
                }
                totalPoint += 150;
            });
            messageBoxCus.Content=$"{point}/{totalPoint}";
            messageBoxCus.InitModeFinish();
            messageBoxCus.ShowDialog();

            this.Close();

            timer1.Enabled=false;
            Main main= new Main();
            main.ShowDialog();
        }
        





























        //////CLASS 
    }
}

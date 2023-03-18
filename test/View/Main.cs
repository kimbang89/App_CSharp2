using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test.View
{
    public partial class Main : Form
    {
        private ImageList img;
        private static string[] files;

        MessageBoxCus messageBoxCus = new MessageBoxCus();
        private List<TestModel> tests= new List<TestModel>();

        public List<TestModel> Tests
        {
            get { return tests; }
        }

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadImageList();

            listTests.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            Color customColor = Color.FromArgb(44, 125, 160);
            listTests.ForeColor = customColor;

            //duyệt show các file
            for (int i = 0; i < files.Length; i++)
            {
                ListViewItem parentItem = new ListViewItem(Path.GetFileNameWithoutExtension(files[i]), i);
                listTests.Items.Add(parentItem);
            }
            //phân quuyền admin user
            //Login login = new Login();
            //if (login.Role != "admin")
            //{
            //    btCreateTest.Visible = false;
            //    btEditTest.Visible = false;
            //    btDelete.Visible = false;
            //}
        }
        public void LoadImageList()
        {
            // Lấy danh sách các file Excel trong thư mục
            files = Directory.GetFiles(Environment.GetEnvironmentVariable("test_DIRECTORY") + @"\\Resources\\", "*.xlsx");
            //thêm vào List để quản lý

            img = new ImageList() { ImageSize = new Size(140, 152) };

            for(int i=0;i<files.Length; i++)
            {
                img.Images.Add(new Bitmap(Environment.GetEnvironmentVariable("test_DIRECTORY") + "\\image\\test.jpg"));
            }
            listTests.LargeImageList = img;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            messageBoxCus.InitModeWarning();
            messageBoxCus.Content = "Are you sure you want to exit now?";
            messageBoxCus.ShowDialog();

            if(messageBoxCus.OK)
                Application.Exit();
        }
        private void listTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTests.SelectedItems.Count == 0) 
            {
                btStartTest.FillColor = ColorTranslator.FromHtml("#10A19D");
                btStartTest.FillColor2 = ColorTranslator.FromHtml("#22A39F");

                btEditTest.FillColor2 = ColorTranslator.FromHtml("#10A19D");
                btEditTest.FillColor = ColorTranslator.FromHtml("#22A39F");

                btDelete.FillColor2 = ColorTranslator.FromHtml("#10A19D");
                btDelete.FillColor = ColorTranslator.FromHtml("#22A39F");

                return;
            }
            btStartTest.FillColor = ColorTranslator.FromHtml("#B721FF");
            btStartTest.FillColor2 = ColorTranslator.FromHtml("#21D4FD");

            btEditTest.FillColor2 = ColorTranslator.FromHtml("#FFCC70");
            btEditTest.FillColor = ColorTranslator.FromHtml("#C850C0");

            btDelete.FillColor2 = ColorTranslator.FromHtml("#FF2525");
            btDelete.FillColor = ColorTranslator.FromHtml("#FFE53B"); 

        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listTests.SelectedItems.Count == 0)
            {
                messageBoxCus.Content = "Please select the file you want to delete!";
                messageBoxCus.ShowDialog();
                return;
            }
            ListViewItem itemSelected = listTests.SelectedItems[0];
            if (itemSelected.Text == "")
            {
                messageBoxCus.Content = "Please select the file you want to delete!";
                messageBoxCus.ShowDialog();
                return;
            }
            string filePath = Environment.GetEnvironmentVariable("test_DIRECTORY") + @"\\Resources\\" + itemSelected.Text+".xlsx";
            if (File.Exists(filePath))
            {
                messageBoxCus.InitModeWarning();
                messageBoxCus.Content = "Are you sure to delete this file?";
                messageBoxCus.ShowDialog();

                if (messageBoxCus.OK)
                {
                    File.Delete(filePath);
                    listTests.Items.Remove(itemSelected);
                }
            }
            else
            {
                messageBoxCus.Content = "The selected file does not exist!";
                messageBoxCus.ShowDialog();
            }
        }
        private void btEditTest_Click(object sender, EventArgs e)
        {
            //nếu chưa select file thì validate
            if (listTests.SelectedItems.Count < 1)
            {
                messageBoxCus.Content = "Please select the file you want to Edit !";
                messageBoxCus.ShowDialog();
                return;
            }
            this.Hide();//vì không cần dữ liệu form nên dùng Close
            string nameFile= listTests.SelectedItems[0].Text;

            formCreate formCreate = new formCreate();
            formCreate.LinkFile=nameFile;
            formCreate.ShowDialog();
        }
        private void btCreateTest_Click(object sender, EventArgs e)
        {
            messageBoxCus.InitModeCreate();
            messageBoxCus.ShowDialog();

            if (messageBoxCus.OK)
            {
                //modeCreate
                formCreate formCreate = new formCreate();
                formCreate.ModeCreate= true;
                formCreate.ShowDialog();
            }
        }
        private void btStartTest_Click(object sender, EventArgs e)
        {
            //check
            if(listTests.SelectedItems.Count == 0) 
            {
                messageBoxCus.Content = "You haven't selected any test yet!!!";
                messageBoxCus.ShowDialog();
                return;
            }
            string nameFile = listTests.SelectedItems[0].Text;  
            // Lấy dữ liệu từ file Excel
            string linkFile = Environment.GetEnvironmentVariable("test_DIRECTORY") + @"\\Resources\\" + nameFile + ".xlsx";

            string etx = Path.GetExtension(linkFile);//lấy kiểu file xls là định dạng cũ, xlsx là mới
            if (etx.ToLower().Equals(".xlsx"))//etx có thể là hoa hoặc thường=>thường
            {
                var excel = new ExcelQueryFactory(linkFile);// Tạo một đối tượng workBook, chứa các trang tính (workshet)

                //lấy từng row trong sheet1 trả về một mảng chứa các row kiểu Test(..,..,..)
                var arrTest = from ts in excel.Worksheet<TestColumns>("Sheet1") select ts;//truy vấn dữ liệu từ Sheet1 trong excel

                //arrTest là mảng từng row trong workSheet
                foreach (var item in arrTest)
                {
                    TestModel test= new TestModel(item.ID, item.Content, item.Answer1, item.Answer2, item.Answer3, item.Answer4, item.CorrectAnswer);
                    tests.Add(test);
                }
            }
            ////mở form xác nhận
            messageBoxCus.InitModeConfirm();
            messageBoxCus.Content = "Are you sure to take the test now?";
            messageBoxCus.ShowDialog();
            if (messageBoxCus.OK)
            {
                Exam exam = new Exam();
                exam.Tests= tests;
                exam.InitDataTests();
                exam.ShowDialog();
            }
        }

       




























    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Code;
using test.View;

namespace test
{
    public partial class Login : Form
    {
        //dùng biến tĩnh để sữ dụng ở những form khác
        private static string role;
        MessageBoxCus messageBoxCus= new MessageBoxCus();
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public Login()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSingIn_Click(object sender, EventArgs e)
        {
            //validate
            //if(tbUserName.Text=="" || tbPassWord.Text == "")
            //{
            //    messageBoxCus.Content = "Please enter your account information";
            //    messageBoxCus.ShowDialog();
            //    return;
            //}

            //role = tbUserName.Text;

            // Thực hiện ẩn form hiện tại
            this.Hide();//Ẩn form nếu Close sẽ tắt cả CT
            Main main = new Main();
            main.ShowDialog();
    
        }

        
    }
}

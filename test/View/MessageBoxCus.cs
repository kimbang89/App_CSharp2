using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace test.View
{
   
    public partial class MessageBoxCus : Form
    {
        private bool ok;
        private bool modeCreate;
        private string content;


        public MessageBoxCus()
        {
            InitializeComponent();
        }
        public bool OK
        {
            get { return ok; }
            set { ok = value; }
        }
        public string Content
        {
            set { lbContent.Text = value; 
                  content=value;}
        }
        public void InitModeFinish()
        {
            ptFinish.Visible = true;
            lbTitle.Text = "FINISH";
            lbPoint.Visible = true;

            lbTitle.ForeColor = ColorTranslator.FromHtml("#03C988");
            lbPoint.Text = content;

            ptError.Visible = false;
        }
        public void InitModeTimeOut()
        {
            ptError.Visible = true;
            lbTimeOut.Visible = true;

            lbContent.Visible = false;
            lbTitle.Visible = false;

            ptWarning.Visible = false;
            ptConfirm.Visible = false;
            ptExport.Visible = false;
        }
        public void InitModeCreate()
        {
            modeCreate = true;

            ptExport.Visible = true;
            lbTitle.Text = "CREATE";
            lbTitle.ForeColor = ColorTranslator.FromHtml("#00ABB3");
            tbnameFile.Focus();
            tbnameFile.Visible= true;
            lbContent.Visible= false;
            ptError.Visible = false;
            ptWarning.Visible = false;
            ptConfirm.Visible = false;
        }
        public void InitModeConfirm()
        {
            ptConfirm.Visible = true;

            lbTitle.Text = "CONFIRM";
            lbTitle.ForeColor = ColorTranslator.FromHtml("#03C988");
            lbContent.ForeColor = ColorTranslator.FromHtml("#00dfc2");

            ptError.Visible = false;
            ptWarning.Visible = false;
        }
        public void InitModeWarning()
        {
            ptWarning.Visible = true;
            lbTitle.Text = "WARNING";
            lbTitle.ForeColor = ColorTranslator.FromHtml("#FF3CAC");
            lbContent.ForeColor= ColorTranslator.FromHtml("#F16767");
            ptError.Visible = false;
        }
      
        private void btOk_Click(object sender, EventArgs e)
        {
            OK = true;
            if (modeCreate)
            {
                Main main= new Main();
                main.Hide();
                formCreate fC = new formCreate();   
                //xử lý tạo mới excel
                if (fC.LinkFile == "")
                {
                    this.Close();//ẩn form tạo file
                        
                    //new formCreate("create");
                    //tạo file excel
                    fC.CreateDataToExcel(tbnameFile.Text);

                    fC.LinkFile = tbnameFile.Text;
                    fC.ShowDialog();
                }
                //xử lý export excel
                else
                {
                    fC.CreateDataToExcel(tbnameFile.Text);
                }
                tbnameFile.Visible = false;
            }
            this.Close();

            lbContent.Visible = true;
            lbTitle.Visible = true;
            lbTimeOut.Visible = false;
            lbTitle.Text = "ERROR";
            lbTitle.ForeColor = ColorTranslator.FromHtml("#DF2E38");
            lbContent.ForeColor = ColorTranslator.FromHtml("#DF2E38");
            lbPoint.Visible = false;

            ptError.Visible = true;
            ptWarning.Visible = false;
            ptConfirm.Visible = false;
            ptExport.Visible = false;
            ptFinish.Visible = false;
            modeCreate = false;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            OK = false;

            this.Close();
            
            lbTitle.ForeColor = ColorTranslator.FromHtml("#DF2E38");
            lbContent.ForeColor = ColorTranslator.FromHtml("#DF2E38");
            lbTitle.Text = "ERROR";
            lbTimeOut.Visible = false;
            lbPoint.Visible = false;

            ptExport.Visible = false;
            ptError.Visible = true;
            ptWarning.Visible = false;
            ptConfirm.Visible = false;
            ptExport.Visible = false;
            tbnameFile.Visible = false;
            ptFinish.Visible = false;
            ptError.Visible = true;
            modeCreate = false;
        }
    }
}

namespace test.View
{
    partial class MessageBoxCus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCus));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbPoint = new System.Windows.Forms.Label();
            this.lbTimeOut = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ptFinish = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptExport = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptConfirm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ptWarning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptError = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbnameFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptError)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.lbPoint);
            this.guna2Panel1.Controls.Add(this.lbTimeOut);
            this.guna2Panel1.Controls.Add(this.lbTitle);
            this.guna2Panel1.Controls.Add(this.ptFinish);
            this.guna2Panel1.Controls.Add(this.ptExport);
            this.guna2Panel1.Controls.Add(this.ptConfirm);
            this.guna2Panel1.Controls.Add(this.btCancel);
            this.guna2Panel1.Controls.Add(this.btOk);
            this.guna2Panel1.Controls.Add(this.ptWarning);
            this.guna2Panel1.Controls.Add(this.ptError);
            this.guna2Panel1.Controls.Add(this.tbnameFile);
            this.guna2Panel1.Controls.Add(this.lbContent);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(779, 209);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lbPoint
            // 
            this.lbPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPoint.Font = new System.Drawing.Font("Showcard Gothic", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(209)))));
            this.lbPoint.Location = new System.Drawing.Point(292, 64);
            this.lbPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(410, 83);
            this.lbPoint.TabIndex = 96;
            this.lbPoint.Text = "100/";
            this.lbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPoint.Visible = false;
            // 
            // lbTimeOut
            // 
            this.lbTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimeOut.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.lbTimeOut.Location = new System.Drawing.Point(334, 45);
            this.lbTimeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeOut.Name = "lbTimeOut";
            this.lbTimeOut.Size = new System.Drawing.Size(397, 64);
            this.lbTimeOut.TabIndex = 94;
            this.lbTimeOut.Text = "TIME OUT !!!";
            this.lbTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTimeOut.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.lbTitle.Location = new System.Drawing.Point(312, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(397, 64);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "ERROR";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptFinish
            // 
            this.ptFinish.Image = ((System.Drawing.Image)(resources.GetObject("ptFinish.Image")));
            this.ptFinish.ImageRotate = 0F;
            this.ptFinish.Location = new System.Drawing.Point(12, 3);
            this.ptFinish.Name = "ptFinish";
            this.ptFinish.Size = new System.Drawing.Size(273, 207);
            this.ptFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptFinish.TabIndex = 95;
            this.ptFinish.TabStop = false;
            this.ptFinish.Visible = false;
            // 
            // ptExport
            // 
            this.ptExport.Image = ((System.Drawing.Image)(resources.GetObject("ptExport.Image")));
            this.ptExport.ImageRotate = 0F;
            this.ptExport.Location = new System.Drawing.Point(12, -6);
            this.ptExport.Name = "ptExport";
            this.ptExport.Size = new System.Drawing.Size(282, 216);
            this.ptExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptExport.TabIndex = 91;
            this.ptExport.TabStop = false;
            this.ptExport.Visible = false;
            // 
            // ptConfirm
            // 
            this.ptConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptConfirm.Image")));
            this.ptConfirm.ImageRotate = 0F;
            this.ptConfirm.Location = new System.Drawing.Point(22, 0);
            this.ptConfirm.Name = "ptConfirm";
            this.ptConfirm.Size = new System.Drawing.Size(253, 210);
            this.ptConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptConfirm.TabIndex = 90;
            this.ptConfirm.TabStop = false;
            this.ptConfirm.Visible = false;
            // 
            // btCancel
            // 
            this.btCancel.BorderRadius = 10;
            this.btCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
            this.btCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(107)))), ((int)(((byte)(28)))));
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.ImageSize = new System.Drawing.Size(35, 35);
            this.btCancel.Location = new System.Drawing.Point(556, 158);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(141, 39);
            this.btCancel.TabIndex = 87;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.BorderRadius = 10;
            this.btOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.btOk.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.ImageSize = new System.Drawing.Size(35, 35);
            this.btOk.Location = new System.Drawing.Point(321, 158);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(141, 39);
            this.btOk.TabIndex = 87;
            this.btOk.Text = "OK";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // ptWarning
            // 
            this.ptWarning.Image = ((System.Drawing.Image)(resources.GetObject("ptWarning.Image")));
            this.ptWarning.ImageRotate = 0F;
            this.ptWarning.Location = new System.Drawing.Point(12, 0);
            this.ptWarning.Name = "ptWarning";
            this.ptWarning.Size = new System.Drawing.Size(253, 210);
            this.ptWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptWarning.TabIndex = 89;
            this.ptWarning.TabStop = false;
            this.ptWarning.Visible = false;
            // 
            // ptError
            // 
            this.ptError.Image = ((System.Drawing.Image)(resources.GetObject("ptError.Image")));
            this.ptError.ImageRotate = 0F;
            this.ptError.Location = new System.Drawing.Point(3, 3);
            this.ptError.Name = "ptError";
            this.ptError.Size = new System.Drawing.Size(300, 203);
            this.ptError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptError.TabIndex = 0;
            this.ptError.TabStop = false;
            // 
            // tbnameFile
            // 
            this.tbnameFile.BorderThickness = 0;
            this.tbnameFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnameFile.DefaultText = "";
            this.tbnameFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbnameFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbnameFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnameFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnameFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.tbnameFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnameFile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnameFile.ForeColor = System.Drawing.Color.Black;
            this.tbnameFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnameFile.Location = new System.Drawing.Point(321, 77);
            this.tbnameFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnameFile.Name = "tbnameFile";
            this.tbnameFile.PasswordChar = '\0';
            this.tbnameFile.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(252)))));
            this.tbnameFile.PlaceholderText = "NameFile";
            this.tbnameFile.SelectedText = "";
            this.tbnameFile.Size = new System.Drawing.Size(376, 55);
            this.tbnameFile.TabIndex = 93;
            this.tbnameFile.Visible = false;
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(44)))), ((int)(((byte)(109)))));
            this.lbContent.Location = new System.Drawing.Point(263, 92);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(504, 33);
            this.lbContent.TabIndex = 88;
            this.lbContent.Text = "label1";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.tbnameFile;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // MessageBoxCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 209);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btOk;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2PictureBox ptError;
        private System.Windows.Forms.Label lbContent;
        private Guna.UI2.WinForms.Guna2PictureBox ptWarning;
        private Guna.UI2.WinForms.Guna2PictureBox ptConfirm;
        private Guna.UI2.WinForms.Guna2PictureBox ptExport;
        private Guna.UI2.WinForms.Guna2TextBox tbnameFile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox ptFinish;
        private System.Windows.Forms.Label lbPoint;
    }
}
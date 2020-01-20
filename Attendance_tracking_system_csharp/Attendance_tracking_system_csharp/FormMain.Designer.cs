namespace Attendance_tracking_system_csharp
{
    partial class FormMain
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
            this.labelForFormMainLoginUserOrAdmin = new System.Windows.Forms.Label();
            this.textBoxForFormMainLoginUserOrAdminLogin = new System.Windows.Forms.TextBox();
            this.textBoxForFormMainLoginUserOrAdminPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForFormMainLoginUserOrAdminLOGIN = new System.Windows.Forms.Button();
            this.buttonForFormMainLoginUserOrAdminLOGINCARD = new System.Windows.Forms.Button();
            this.buttonForFormMainLoginUserOrAdminExit = new System.Windows.Forms.Button();
            this.labelForFormMainLoginUserOrAdminSTATUS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForFormMainLoginUserOrAdmin
            // 
            this.labelForFormMainLoginUserOrAdmin.AutoSize = true;
            this.labelForFormMainLoginUserOrAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForFormMainLoginUserOrAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelForFormMainLoginUserOrAdmin.Location = new System.Drawing.Point(110, 15);
            this.labelForFormMainLoginUserOrAdmin.Name = "labelForFormMainLoginUserOrAdmin";
            this.labelForFormMainLoginUserOrAdmin.Size = new System.Drawing.Size(157, 20);
            this.labelForFormMainLoginUserOrAdmin.TabIndex = 0;
            this.labelForFormMainLoginUserOrAdmin.Text = "Aвторизируйтесь";
            // 
            // textBoxForFormMainLoginUserOrAdminLogin
            // 
            this.textBoxForFormMainLoginUserOrAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxForFormMainLoginUserOrAdminLogin.Location = new System.Drawing.Point(178, 51);
            this.textBoxForFormMainLoginUserOrAdminLogin.Name = "textBoxForFormMainLoginUserOrAdminLogin";
            this.textBoxForFormMainLoginUserOrAdminLogin.Size = new System.Drawing.Size(194, 24);
            this.textBoxForFormMainLoginUserOrAdminLogin.TabIndex = 1;
            // 
            // textBoxForFormMainLoginUserOrAdminPassword
            // 
            this.textBoxForFormMainLoginUserOrAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxForFormMainLoginUserOrAdminPassword.Location = new System.Drawing.Point(178, 91);
            this.textBoxForFormMainLoginUserOrAdminPassword.Name = "textBoxForFormMainLoginUserOrAdminPassword";
            this.textBoxForFormMainLoginUserOrAdminPassword.PasswordChar = '•';
            this.textBoxForFormMainLoginUserOrAdminPassword.Size = new System.Drawing.Size(194, 24);
            this.textBoxForFormMainLoginUserOrAdminPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Персональный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(111, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // buttonForFormMainLoginUserOrAdminLOGIN
            // 
            this.buttonForFormMainLoginUserOrAdminLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForFormMainLoginUserOrAdminLOGIN.Location = new System.Drawing.Point(12, 137);
            this.buttonForFormMainLoginUserOrAdminLOGIN.Name = "buttonForFormMainLoginUserOrAdminLOGIN";
            this.buttonForFormMainLoginUserOrAdminLOGIN.Size = new System.Drawing.Size(150, 30);
            this.buttonForFormMainLoginUserOrAdminLOGIN.TabIndex = 6;
            this.buttonForFormMainLoginUserOrAdminLOGIN.Text = "Авторизоваться";
            this.buttonForFormMainLoginUserOrAdminLOGIN.UseVisualStyleBackColor = true;
            this.buttonForFormMainLoginUserOrAdminLOGIN.Click += new System.EventHandler(this.buttonForFormMainLoginUserOrAdminLOGIN_Click);
            // 
            // buttonForFormMainLoginUserOrAdminLOGINCARD
            // 
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.Location = new System.Drawing.Point(12, 183);
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.Name = "buttonForFormMainLoginUserOrAdminLOGINCARD";
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.Size = new System.Drawing.Size(150, 50);
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.TabIndex = 7;
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.Text = "Авторизоваться \n по карте";
            this.buttonForFormMainLoginUserOrAdminLOGINCARD.UseVisualStyleBackColor = true;
            // 
            // buttonForFormMainLoginUserOrAdminExit
            // 
            this.buttonForFormMainLoginUserOrAdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForFormMainLoginUserOrAdminExit.Location = new System.Drawing.Point(222, 183);
            this.buttonForFormMainLoginUserOrAdminExit.Name = "buttonForFormMainLoginUserOrAdminExit";
            this.buttonForFormMainLoginUserOrAdminExit.Size = new System.Drawing.Size(150, 50);
            this.buttonForFormMainLoginUserOrAdminExit.TabIndex = 8;
            this.buttonForFormMainLoginUserOrAdminExit.Text = "Выход из программы";
            this.buttonForFormMainLoginUserOrAdminExit.UseVisualStyleBackColor = true;
            this.buttonForFormMainLoginUserOrAdminExit.Click += new System.EventHandler(this.buttonForFormMainLoginUserOrAdminExit_Click);
            // 
            // labelForFormMainLoginUserOrAdminSTATUS
            // 
            this.labelForFormMainLoginUserOrAdminSTATUS.AutoSize = true;
            this.labelForFormMainLoginUserOrAdminSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelForFormMainLoginUserOrAdminSTATUS.Location = new System.Drawing.Point(168, 137);
            this.labelForFormMainLoginUserOrAdminSTATUS.Name = "labelForFormMainLoginUserOrAdminSTATUS";
            this.labelForFormMainLoginUserOrAdminSTATUS.Size = new System.Drawing.Size(214, 18);
            this.labelForFormMainLoginUserOrAdminSTATUS.TabIndex = 9;
            this.labelForFormMainLoginUserOrAdminSTATUS.Text = "//неверный номер или пароль";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelForFormMainLoginUserOrAdminSTATUS);
            this.Controls.Add(this.buttonForFormMainLoginUserOrAdminExit);
            this.Controls.Add(this.buttonForFormMainLoginUserOrAdminLOGINCARD);
            this.Controls.Add(this.buttonForFormMainLoginUserOrAdminLOGIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFormMainLoginUserOrAdminPassword);
            this.Controls.Add(this.textBoxForFormMainLoginUserOrAdminLogin);
            this.Controls.Add(this.labelForFormMainLoginUserOrAdmin);
            this.Name = "FormMain";
            this.Text = "Attendance tracking system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForFormMainLoginUserOrAdmin;
        private System.Windows.Forms.TextBox textBoxForFormMainLoginUserOrAdminLogin;
        private System.Windows.Forms.TextBox textBoxForFormMainLoginUserOrAdminPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonForFormMainLoginUserOrAdminLOGIN;
        private System.Windows.Forms.Button buttonForFormMainLoginUserOrAdminLOGINCARD;
        private System.Windows.Forms.Button buttonForFormMainLoginUserOrAdminExit;
        private System.Windows.Forms.Label labelForFormMainLoginUserOrAdminSTATUS;
    }
}


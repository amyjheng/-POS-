namespace _0807POS機系統
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtxuser = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(23, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtxuser
            // 
            this.txtxuser.Location = new System.Drawing.Point(307, 92);
            this.txtxuser.Name = "txtxuser";
            this.txtxuser.Size = new System.Drawing.Size(222, 22);
            this.txtxuser.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(307, 139);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '6';
            this.txtpwd.Size = new System.Drawing.Size(222, 22);
            this.txtpwd.TabIndex = 4;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(218, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "使用者帳號 :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(257, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "密碼 :";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbtn.Location = new System.Drawing.Point(307, 191);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(222, 42);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "登入 Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.Location = new System.Drawing.Point(307, 242);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(222, 42);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "離開 Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 361);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtxuser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtxuser;
        private System.Windows.Forms.TextBox txtpwd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}
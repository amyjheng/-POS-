namespace _0807POS機系統
{
    partial class FrmCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCal));
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_mid = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_answer = new System.Windows.Forms.Label();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.Yellow;
            this.btn_div.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_div.Location = new System.Drawing.Point(271, 244);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(51, 35);
            this.btn_div.TabIndex = 29;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click_1);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.Yellow;
            this.btn_mul.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_mul.Location = new System.Drawing.Point(205, 244);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(51, 35);
            this.btn_mul.TabIndex = 28;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click_1);
            // 
            // btn_mid
            // 
            this.btn_mid.BackColor = System.Drawing.Color.Yellow;
            this.btn_mid.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_mid.Location = new System.Drawing.Point(130, 244);
            this.btn_mid.Name = "btn_mid";
            this.btn_mid.Size = new System.Drawing.Size(51, 35);
            this.btn_mid.TabIndex = 27;
            this.btn_mid.Text = "-";
            this.btn_mid.UseVisualStyleBackColor = false;
            this.btn_mid.Click += new System.EventHandler(this.btn_mid_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Yellow;
            this.btn_add.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(64, 244);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(51, 35);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // txt_answer
            // 
            this.txt_answer.BackColor = System.Drawing.Color.Transparent;
            this.txt_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_answer.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_answer.Location = new System.Drawing.Point(216, 56);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(195, 71);
            this.txt_answer.TabIndex = 25;
            this.txt_answer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_number2
            // 
            this.txt_number2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_number2.Location = new System.Drawing.Point(142, 302);
            this.txt_number2.Multiline = true;
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(162, 56);
            this.txt_number2.TabIndex = 24;
            this.txt_number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_number1
            // 
            this.txt_number1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_number1.Location = new System.Drawing.Point(142, 175);
            this.txt_number1.Multiline = true;
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(162, 51);
            this.txt_number1.TabIndex = 23;
            this.txt_number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(160, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "計算結果  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(161, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "欲相加的數字";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(351, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 147);
            this.button1.TabIndex = 30;
            this.button1.Text = "C\r\n清\r\n除";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_mid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_number2);
            this.Controls.Add(this.txt_number1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCal";
            this.Text = "FrmCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_mid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label txt_answer;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
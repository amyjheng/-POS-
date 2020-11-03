namespace _0807POS機系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labmenu = new System.Windows.Forms.Label();
            this.beer = new System.Windows.Forms.Button();
            this.teqi = new System.Windows.Forms.Button();
            this.whis = new System.Windows.Forms.Button();
            this.wine = new System.Windows.Forms.Button();
            this.lablist1 = new System.Windows.Forms.Label();
            this.labTotalprice = new System.Windows.Forms.Label();
            this.labPayment = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lablist = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnaddvip = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labmenu
            // 
            this.labmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labmenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmenu.Location = new System.Drawing.Point(20, 44);
            this.labmenu.Name = "labmenu";
            this.labmenu.Size = new System.Drawing.Size(280, 306);
            this.labmenu.TabIndex = 0;
            this.labmenu.Text = "菜單Menu";
            // 
            // beer
            // 
            this.beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beer.BackgroundImage")));
            this.beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beer.Location = new System.Drawing.Point(32, 77);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(114, 112);
            this.beer.TabIndex = 1;
            this.beer.Text = "啤酒\r\nBEER\r\nNT$120";
            this.beer.UseVisualStyleBackColor = true;
            this.beer.Click += new System.EventHandler(this.beer_Click);
            // 
            // teqi
            // 
            this.teqi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teqi.BackgroundImage")));
            this.teqi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teqi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.teqi.Location = new System.Drawing.Point(173, 77);
            this.teqi.Name = "teqi";
            this.teqi.Size = new System.Drawing.Size(114, 112);
            this.teqi.TabIndex = 2;
            this.teqi.Text = "龍舌蘭\r\nTequila\r\nNT$180\r\n";
            this.teqi.UseVisualStyleBackColor = true;
            this.teqi.Click += new System.EventHandler(this.teqi_Click);
            // 
            // whis
            // 
            this.whis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whis.BackgroundImage")));
            this.whis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.whis.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.whis.Location = new System.Drawing.Point(32, 205);
            this.whis.Name = "whis";
            this.whis.Size = new System.Drawing.Size(114, 112);
            this.whis.TabIndex = 3;
            this.whis.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.whis.UseVisualStyleBackColor = true;
            this.whis.Click += new System.EventHandler(this.whis_Click);
            // 
            // wine
            // 
            this.wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wine.BackgroundImage")));
            this.wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wine.Location = new System.Drawing.Point(173, 205);
            this.wine.Name = "wine";
            this.wine.Size = new System.Drawing.Size(114, 112);
            this.wine.TabIndex = 4;
            this.wine.Text = "紅酒\r\nWine\r\nNT$320";
            this.wine.UseVisualStyleBackColor = true;
            this.wine.Click += new System.EventHandler(this.wine_Click);
            // 
            // lablist1
            // 
            this.lablist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lablist1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist1.Location = new System.Drawing.Point(20, 367);
            this.lablist1.Name = "lablist1";
            this.lablist1.Size = new System.Drawing.Size(567, 306);
            this.lablist1.TabIndex = 5;
            this.lablist1.Text = "購物清單List";
            // 
            // labTotalprice
            // 
            this.labTotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labTotalprice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalprice.Location = new System.Drawing.Point(304, 44);
            this.labTotalprice.Name = "labTotalprice";
            this.labTotalprice.Size = new System.Drawing.Size(280, 98);
            this.labTotalprice.TabIndex = 6;
            this.labTotalprice.Text = "總金額Total Price";
            // 
            // labPayment
            // 
            this.labPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPayment.Location = new System.Drawing.Point(307, 156);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(280, 194);
            this.labPayment.TabIndex = 7;
            this.labPayment.Text = "付款方式 Payment";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Black;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(319, 68);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(254, 65);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Transparent;
            this.btnCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash.BackgroundImage")));
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCash.Location = new System.Drawing.Point(344, 195);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(89, 88);
            this.btnCash.TabIndex = 9;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.Transparent;
            this.btnCredit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCredit.BackgroundImage")));
            this.btnCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCredit.FlatAppearance.BorderSize = 0;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCredit.Location = new System.Drawing.Point(465, 195);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(88, 88);
            this.btnCredit.TabIndex = 10;
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(464, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "信用卡享9折!";
            // 
            // lablist
            // 
            this.lablist.BackColor = System.Drawing.Color.White;
            this.lablist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist.Location = new System.Drawing.Point(23, 391);
            this.lablist.Name = "lablist";
            this.lablist.Size = new System.Drawing.Size(318, 233);
            this.lablist.TabIndex = 12;
            this.lablist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(33, 627);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(119, 36);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "清除全部";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(604, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 306);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnaddvip
            // 
            this.btnaddvip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaddvip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddvip.BackgroundImage")));
            this.btnaddvip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnaddvip.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnaddvip.FlatAppearance.BorderSize = 0;
            this.btnaddvip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnaddvip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnaddvip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddvip.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnaddvip.Location = new System.Drawing.Point(361, 406);
            this.btnaddvip.Name = "btnaddvip";
            this.btnaddvip.Size = new System.Drawing.Size(86, 92);
            this.btnaddvip.TabIndex = 15;
            this.btnaddvip.UseVisualStyleBackColor = false;
            this.btnaddvip.Click += new System.EventHandler(this.btnaddvip_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.Location = new System.Drawing.Point(398, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 63);
            this.button4.TabIndex = 19;
            this.button4.Text = "當月壽星 * 優待啤酒一瓶";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(222, 627);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = "小算盤";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndel.BackgroundImage")));
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndel.Location = new System.Drawing.Point(361, 552);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(86, 89);
            this.btndel.TabIndex = 21;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(482, 406);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(82, 92);
            this.btnedit.TabIndex = 22;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsearch.Location = new System.Drawing.Point(482, 552);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(82, 89);
            this.btnsearch.TabIndex = 23;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(347, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "單筆消費滿3,000$ 即可加入VIP!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(604, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 305);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(732, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 61);
            this.label3.TabIndex = 26;
            this.label3.Text = "新官網開發中!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(442, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1177, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnaddvip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lablist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labPayment);
            this.Controls.Add(this.labTotalprice);
            this.Controls.Add(this.lablist1);
            this.Controls.Add(this.wine);
            this.Controls.Add(this.whis);
            this.Controls.Add(this.teqi);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.labmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labmenu;
        private System.Windows.Forms.Button beer;
        private System.Windows.Forms.Button teqi;
        private System.Windows.Forms.Button whis;
        private System.Windows.Forms.Button wine;
        private System.Windows.Forms.Label lablist1;
        private System.Windows.Forms.Label labTotalprice;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lablist;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaddvip;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}


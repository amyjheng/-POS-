namespace _0807POS機系統
{
    partial class FrmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreate));
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.btnAddTodb = new System.Windows.Forms.Button();
            this.gridpanel = new System.Windows.Forms.Panel();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.labname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.pOSsystemDataSet = new _0807POS機系統.POSsystemDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new _0807POS機系統.POSsystemDataSetTableAdapters.CustomerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.gridpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblbirthday.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(288, 30);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(86, 24);
            this.lblbirthday.TabIndex = 10;
            this.lblbirthday.Text = "會員生日";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.BackColor = System.Drawing.Color.Transparent;
            this.lbllastname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(10, 11);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(98, 24);
            this.lbllastname.TabIndex = 11;
            this.lbllastname.Text = "VIP會員姓";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(125, 107);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(146, 26);
            this.txtphone.TabIndex = 9;
            // 
            // datagridview1
            // 
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview1.Location = new System.Drawing.Point(0, 0);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.Size = new System.Drawing.Size(782, 295);
            this.datagridview1.TabIndex = 3;
            // 
            // btnAddTodb
            // 
            this.btnAddTodb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnAddTodb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTodb.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddTodb.FlatAppearance.BorderSize = 0;
            this.btnAddTodb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddTodb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTodb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTodb.ForeColor = System.Drawing.Color.White;
            this.btnAddTodb.Location = new System.Drawing.Point(292, 89);
            this.btnAddTodb.Name = "btnAddTodb";
            this.btnAddTodb.Size = new System.Drawing.Size(139, 44);
            this.btnAddTodb.TabIndex = 12;
            this.btnAddTodb.Text = "確定新增";
            this.btnAddTodb.UseVisualStyleBackColor = false;
            this.btnAddTodb.Click += new System.EventHandler(this.btnAddTodb_Click);
            // 
            // gridpanel
            // 
            this.gridpanel.Controls.Add(this.datagridview1);
            this.gridpanel.Location = new System.Drawing.Point(6, 143);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(782, 295);
            this.gridpanel.TabIndex = 13;
            this.gridpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridpanel_Paint);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(146, 38);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(130, 26);
            this.txtfirstname.TabIndex = 17;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labname.Location = new System.Drawing.Point(142, 11);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(29, 24);
            this.labname.TabIndex = 18;
            this.labname.Text = "名";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(9, 38);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(119, 26);
            this.txtlastname.TabIndex = 19;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.metroDateTime1.Location = new System.Drawing.Point(398, 25);
            this.metroDateTime1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 20;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.ItemHeight = 12;
            this.CmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CmbGender.Location = new System.Drawing.Point(16, 108);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(82, 20);
            this.CmbGender.TabIndex = 21;
            // 
            // pOSsystemDataSet
            // 
            this.pOSsystemDataSet.DataSetName = "POSsystemDataSet";
            this.pOSsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.pOSsystemDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "性別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "會員電話";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Magenta;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(630, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "★刪除★";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(630, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "清除\r\n全部 輸入";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblbirthday);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.btnAddTodb);
            this.Controls.Add(this.gridpanel);
            this.Name = "FrmCreate";
            this.Text = "FrmCreate";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.gridpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOSsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.Button btnAddTodb;
        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox txtlastname;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.ComboBox CmbGender;
        private POSsystemDataSet pOSsystemDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private POSsystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
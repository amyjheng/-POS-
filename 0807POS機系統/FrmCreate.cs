using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0807POS機系統
{
    public partial class FrmCreate : Form
    {
        public int row;
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void gridpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pOSsystemDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.pOSsystemDataSet.Customer);
            this.datagridview1.DataSource = dbContext.Customers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Control c in Controls)
            //{
            //    if (c is TextBox)
            //        c.Text = "";

            //}

            this.datagridview1.DataSource = dbContext.Customers.ToList();
        }
        _0807POS機系統.POSsystemEntities dbContext = new POSsystemEntities();
        private void btnAddTodb_Click(object sender, EventArgs e)
        {
            Customer prod = new Customer { FirstName = txtfirstname.Text, BirthDate = metroDateTime1.Value, LastName = txtlastname.Text, Gender = CmbGender.SelectedItem.ToString(), PhoneNumber = txtphone.Text };
            this.dbContext.Customers.Add(prod);

            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }

        void Read_RefreshDataGridView()
        {
            this.datagridview1.DataSource = null;
            this.datagridview1.DataSource = this.dbContext.Customers.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Vipmember = (from p in this.dbContext.Customers
                             select p).FirstOrDefault();

            if (Vipmember == null) return;

            this.dbContext.Customers.Remove(Vipmember);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUpdate aaa = new FrmUpdate();
            aaa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
    }
}

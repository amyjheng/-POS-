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
    public partial class Form1 : Form
    {
        int count = 0;
        double total;
        string a;
        string b;
        string c;
        string d;
        string ee;
        int beer_count=0;
        int teqi_count = 0;
        int whis_count = 0;
        int wine_count= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void beer_Click(object sender, EventArgs e)
        {
            beer_count++;
            a = "\n啤酒Beer"+"x"+beer_count +"共NT$"+ (120 * beer_count);
            total += 120;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;
            
            
        }

        private void teqi_Click(object sender, EventArgs e)
        {
            teqi_count++;
            b = "\n龍舌蘭Tequila" + "x" + teqi_count + "共NT$" + (180 * teqi_count);
            total += 180;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;

        }

        private void whis_Click(object sender, EventArgs e)
        {
            whis_count++;
            c = "\n威士忌Whisky" + "x" + whis_count + "共NT$" + (350 * whis_count);
            total += 350;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;

        }

        private void wine_Click(object sender, EventArgs e)
        {
            wine_count++;
            d = "\n紅酒Wine" + "x" + wine_count + "共NT$" + (320 * wine_count);
            total += 320;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;
        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (var i in Controls)
            {
                TextBox tb = i as TextBox;
                if (tb != null) tb.Text = "NT$0";
            }
            
           int count = 0;
           lablist.Text = ("尚未點餐");
          beer_count = 0;
          teqi_count = 0;
          whis_count = 0;
          wine_count = 0;
          total = 0;
          a = "";
          b = "";
          c = "";
          d = "";
                      
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("您尚未點餐!", 
                    "提示訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額為:NT$"+ txtPrice.Text + "元","確認付款", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                txtPrice.Text = "";
                lablist.Text = "";
                
            }

        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("您尚未點餐!",
                    "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double c = total * 0.9;
                MessageBox.Show("總金額為:NT$"+ txtPrice.Text + "元"+"\n 折扣後金額:NT$" + c , "確認付款",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                txtPrice.Text = "";
                lablist.Text = "";
                
            } 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            beer_count--;
            a = "\n啤酒Beer" + "x" + beer_count + "共NT$" + (-120 * beer_count);
            total -= 120;
            txtPrice.Text = total.ToString();
            ee = a + b + c + d;
            lablist.Text = ee;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCal aaa = new FrmCal();
            aaa.Show();
        }
        _0807POS機系統.POSsystemEntities dbContext = new POSsystemEntities();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            //var q = (from p in dbContext.Customers
            //         select p).Take(5);
            this.dataGridView1.DataSource = null;
            this.Read_RefreshDataGridView();
            this.dataGridView1.DataSource = dbContext.Customers.ToList();
        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.Customers.ToList();

        }

        private void btnaddvip_Click(object sender, EventArgs e)
        {
            FrmCreate aaa = new FrmCreate();
            aaa.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            FrmUpdate aaa = new FrmUpdate();
            aaa.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            FrmCreate aaa = new FrmCreate();
            aaa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.Read_RefreshDataGridView();
            this.dataGridView1.DataSource = dbContext.Customers.ToList();
        }
    }
}

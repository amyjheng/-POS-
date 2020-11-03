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
    public partial class FrmUpdate : Form
    {
        
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string h = "M";
            int s = int.Parse(txtxid.Text);
            POSsystemEntities abc = new POSsystemEntities();
            var q = (from p in abc.Customers
                    where p.CustormerID == s
                    select p).FirstOrDefault();
            q.FirstName = txtfirstname.Text;
            q.LastName = txtlastname.Text;
            q.BirthDate = metroDateTime1.Value;
            q.PhoneNumber = txtphone.Text;
            if(CmbGender.SelectedItem==null)
            {
                q.Gender = h;
            }
            else
            {
                q.Gender = CmbGender.SelectedItem.ToString();
            }
           
            //if (q == null) return;
            abc.SaveChanges();
            MessageBox.Show("儲存成功!");
            this.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }


        //public void loadData(ClsMember item)
        //{
        //    txtlastname.Text = item.txtlastname;
        //    txtfirstname.Text = item.txtfirstname;
        //    txtphone.Text = item.txtphone;
        //    btnSave.Text = "Update";
        //}
    }
}

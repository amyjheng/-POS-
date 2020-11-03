using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0807POS機系統
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        POSsystemEntities dbcontext = new POSsystemEntities();
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            IsValid();
           
        }
        
        private void IsValid()
        {
            var q = from u in this.dbcontext.LoginUsers
                    select u;

            
            if (txtxuser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("必須輸入帳號!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (txtpwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("必須輸入密碼!","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                foreach (var items in q)
                {
                    if(items.Username == txtxuser.Text && items.Password == txtpwd.Text)
                    {
                        MessageBox.Show("登入成功!");
                        Form1 aaa = new Form1();
                        aaa.Show();
                    }
                    else
                    {
                        MessageBox.Show("輸入不正確,請重新輸入","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    }
                }
                
            }
            
        }
    }
}

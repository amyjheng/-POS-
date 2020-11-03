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
    public partial class FrmCal : Form
    {
        public FrmCal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_answer.Text = "";
            txt_number1.Text = "";
            txt_number2.Text = "";
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_number2.Text) || String.IsNullOrEmpty(txt_number1.Text))
            {

                MessageBox.Show("請輸入數字");

            }
            else
            {
                int number1 = int.Parse(txt_number1.Text);
                int number2 = int.Parse(txt_number2.Text);
                int number3 = number1 + number2;
                //MessageBox.Show(number3.ToString());
                txt_answer.Text = number3.ToString();

            }
        }

        private void btn_mid_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_number2.Text) || String.IsNullOrEmpty(txt_number1.Text))
            {

                MessageBox.Show("請輸入數字");

            }
            else
            {
                int number1 = int.Parse(txt_number1.Text);
                int number2 = int.Parse(txt_number2.Text);
                int number3 = number1 - number2;
                //MessageBox.Show(number3.ToString());
                txt_answer.Text = number3.ToString();

            }
        }

        private void btn_mul_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_number2.Text) || String.IsNullOrEmpty(txt_number1.Text))
            {

                MessageBox.Show("請輸入數字");

            }
            else
            {
                int number1 = int.Parse(txt_number1.Text);
                int number2 = int.Parse(txt_number2.Text);
                int number3 = number1 * number2;
                //MessageBox.Show(number3.ToString());
                txt_answer.Text = number3.ToString();

            }
        }

        private void btn_div_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_number2.Text) || String.IsNullOrEmpty(txt_number1.Text))
            {

                MessageBox.Show("請輸入數字");

            }
            else
            {
                int number1 = int.Parse(txt_number1.Text);
                int number2 = int.Parse(txt_number2.Text);
                int number3 = number1 / number2;
                //MessageBox.Show(number3.ToString());
                txt_answer.Text = number3.ToString();

            }
        }
    }
}

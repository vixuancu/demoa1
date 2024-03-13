using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoa1
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider=new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.TextLength>0)
            {
                btn1.Enabled = true;
            }
            CheckButtonEnable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Enabled=false;
            btn1.Focus();
        }
        private void xuLySuKien (object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckButtonEnable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox2, "họ tên ko trống");
            }else
            {
                e.Cancel=false;
                errorProvider.SetError(textBox2, null);
            }
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox1, "họ tên ko trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox1, null);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckButtonEnable();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, không cho phép nhập
                e.Handled = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }
        private void CheckButtonEnable()
        {
            // Kiểm tra xem tất cả các điều kiện hợp lệ có được đáp ứng không
            bool isValid = ValidateTextBox(textBox1) && ValidateTextBox(textBox2) && ValidateTextBox(textBox3);

            // Kích hoạt hoặc vô hiệu hóa nút thêm mới tùy thuộc vào isValid
            btn1.Enabled = isValid;
        }
        private bool ValidateTextBox(TextBox textBox)
        {
            // Kiểm tra xem có lỗi nào không
            string errorMessage = errorProvider.GetError(textBox);

            // Nếu có lỗi, trả về false, ngược lại trả về true
            return string.IsNullOrEmpty(errorMessage);
        }
    }
}

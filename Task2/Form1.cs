using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الطالب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(studentID.Text))
            {
                MessageBox.Show("يرجى إدخال رقم الطالب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone.Text) || phone.Text.Length != 9)
            {
                MessageBox.Show("رقم الهاتف يجب أن يكون 9 أرقام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Specialization.Text))
            {
                MessageBox.Show("يرجى إدخال التخصص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("تم تسجيل الطالب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}

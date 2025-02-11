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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
        

            if(user == "assem" && password.Text == "1234")
             {
                this.Hide();
                Form1 mainForm = new Form1(); 
                mainForm.ShowDialog();
               
                this.Close();
            }
            else
            {
             
                MessageBox.Show("فشل تسجيل الدخول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

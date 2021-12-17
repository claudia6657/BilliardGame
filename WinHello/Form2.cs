using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinHello
{
    public partial class Form2 : Form
    {
        public string account = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(account);
            Form3 f = new Form3(account); //new form
            this.Visible = false;
            f.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); //new form
            this.Visible = false;
            f.Visible = true;
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            account = this.textBoxAccount.Text.ToString();
        }
    }
}

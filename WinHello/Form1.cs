using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHello
{
    public partial class Form1 : Form
    {
        //TIMER
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Start();
            button1.MouseEnter += OnMouseEnterButton1;
            button1.MouseLeave += OnMouseLeaveButton1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); //new form
            this.Visible = false;
            f.Visible = true;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            timer.Stop();
            // or Color.Red or whatever you want
            button1.ForeColor = Color.OliveDrab;
            button1.Font = new Font("Georgia", 22, FontStyle.Bold);
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            timer.Start();
            button1.Font = new Font("Georgia", 18, FontStyle.Bold);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.timer.Interval %2 == 0)
            {
                button1.ForeColor = Color.OliveDrab;
            }
            else
            {
                button1.ForeColor = Color.Black;
            }

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void labelTopic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinHello
{
    public partial class Form3 : Form
    {
        // Avoid the flick by page switching
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        BufferedGraphicsContext currentContext;
        BufferedGraphics gBuffer;
        static int table_width = 0, table_height = 0;
        public string username;
        static Graphics g; //繪圖裝置
        static int radius = 13, diam = 26;
        static double fr = 0; //摩擦力

        int[] DefPosX = {600, 620, 620, 640, 640, 640, 660, 660, 680};
        int[] DefPosY = {260, 240, 280, 220, 260, 300, 240, 280, 260};


        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string account) {
            InitializeComponent();

            //迫使該畫面被啟用時重繪畫面控制項
            this.Activated += (sender, e) => { Invalidate(); };
           

            table_width = (panel1.Width)-50;
            table_height = (panel1.Height)-50;
            
            /*
            //buffer
            currentContext = BufferedGraphicsManager.Current;
            gBuffer = currentContext.Allocate(
                this.panel1.CreateGraphics(),
                new Rectangle(0, 0, table_width+50, table_height+50)
             );
            g = gBuffer.Graphics;
            */

            //繪圖裝置 初始化
            g = panel1.CreateGraphics();     
            for (int i = 1; i < 10; i++)            //new 每個球 ball
                balls[i] = new ball(DefPosX[i-1], DefPosY[i-1], Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);
            balls[0] = new ball(200, 260, Color.FromArgb(255, 255, 255, 255), 0);

            username = account;
            labelname.Text = "Welcome " + username;
            panelStop.Visible = false;

            foreach (Control ctrl in panelStop.Controls)
            {
                if(ctrl is Button)
                {
                    ctrl.MouseEnter += new EventHandler(OnMouseEnterButton);
                    ctrl.MouseLeave += new EventHandler(OnMouseLeaveButton);
                }
            }
        }

        //球 class(類別)
        class ball
        {
            int ball_Id;                                      //球編號
            public double PosX = 0, PosY = 0;    //球心 坐標
            Color c;                                   //球顏色
            SolidBrush br;                        //刷子（畫球用）
            private double ang = 0;       //ex4：球 行進角度&速度
            public double speed = 0;
            public double cosA, sinA, DownX, DownY;   //ex4：coSine 行進角度, Sine 行進角度

            public ball(int bx, int by, Color cc, int i)
            {  //建構者
                PosX = bx;                                 //球心 x 坐標
                PosY = by;                                 //球心 y 坐標
                c = cc;                                  //球顏色    
                br = new SolidBrush(cc);     //球顏色的刷子
                ball_Id = i;                                   //球編號
            }
            public void draw(Graphics g)
            {      //畫 球物件 自己
                g.FillEllipse(br, (int)(PosX - radius), (int)(PosY - radius), diam, diam);          //畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
            }
            public void setAng(double _ang)
            {    //ex4：角度 改變
                ang = _ang;                       // 存 新角度
                cosA = Math.Cos(ang);     //  重算 coSine
                sinA = Math.Sin(ang);       //  重算 Sine
            }
            public void posMouse(double x, double y)
            {
                DownX = x;
                DownY = y;
            }
            public void drawStick(Graphics g)
            {
                double rlong = radius * 20;
                double rball = radius * 1.5;
                double raimlong = radius * 30;
                double raimball = radius * 1;
                Pen CuePen = new Pen(Brushes.Beige);    // 宣告 + new 畫筆
                CuePen.Width = 4.5F;   // 改變 畫筆 寬度
                g.DrawLine(CuePen,
                     (float)(PosX - rlong * cosA), (float)(PosY - rlong * sinA),    // 同心圓周上的點
                     (float)(PosX - rball * cosA), (float)(PosY - rball * sinA)          // - r12   -r , 使球杆 畫在滑鼠點的另一邊   
                );

                Pen AimLine = new Pen(Color.White, 2);
                AimLine.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(AimLine,
                    (float)(DownX), (float)(DownY),
                    (float)(PosX - raimball * cosA), (float)(PosY - raimball * sinA)
                );

            }
            public void drawRectangle(Graphics g)
            {
                g.DrawRectangle(Pens.HotPink, (float)(DownX - 2), (float)(DownY - 2), 8, 8); // 點擊點 畫小方塊
            }
            public void move()
            {  //  移動 球
                if (speed > 0)
                {  //  速度 >0 才移動
                    PosX += speed * cosA;   //  x 方向分量
                    PosY += speed * sinA;    //  y 方向分量
                    speed -= fr;              //  速度 依摩擦力大小 遞減
                }
                else speed = 0;  //  避免 <0 而反向移動
            }

            public void rebound()
            {  //球碰邊反彈，或進洞
                if (PosX < (radius + 50) || PosX > table_width - radius)
                {  //出左右邊
                    setAng(Math.PI - ang);
                    if (PosX < (radius + 50))
                        PosX = radius + 50;    // 拉回桌 內
                    else
                        PosX = table_width - radius;
                }
                else if (PosY < (radius + 50) || PosY > table_height - radius)
                { //出上下邊
                    setAng(-ang);
                    if (PosY < (radius + 50))
                        PosY = radius +50;    //拉回桌 內
                    else
                        PosY = table_height - radius;
                }
            }
        }

        ball[] balls = new ball[10]; // 10 顆球的陣列

        private void hit(ball b0, ball b1)
        {
            if (b0.speed < b1.speed)
            {   // b1 hit  b0  速度快的 撞 慢的
                ball t = b0;     //  交換球，讓速度快的球 成為 b0
                b0 = b1;
                b1 = t;
            }
            double dx = b1.PosX - b0.PosX, dy = b1.PosY - b0.PosY;
            if (Math.Abs(dx) <= diam && Math.Abs(dy) <= diam)
            { //  x坐標間差距 < 球直徑
              // 而且　　y坐標間差距 < 球直徑
                double ang = Math.Atan2(dy, dx);   //  球b0 中心 到 球b1 中心 連線方向
                b1.setAng(ang);     //  球b1 被撞后方向
                b0.setAng(ang + Math.PI / 2.0);   //  球b0  碰撞 b1 后 和 b1 的夾角 90° 

                double spd_average = (b0.speed + b1.speed) / 2.0;
                b0.speed = b1.speed = spd_average;    //  碰撞 後 先大略平均分配 兩球的速度
                                                  // 白球速度 == 紅球速度 == 兩球的速度 和 /2
            }

            if (checkBox1.Checked){   //  有打鉤，暫停來拉回看看
                timer1.Stop();                
                panel1.Refresh();  // 顯示 球 碰撞後 重疊的情形
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            //g.Clear(panel1.BackColor);
            //用g來繪圖  寫進 gbuffer 記憶體
            for (int i = 0; i < 10; i++)
                balls[i].draw(e.Graphics);
            if (balls[0].speed < 0.0001)
            {
                balls[0].drawStick(e.Graphics);
                balls[0].drawRectangle(e.Graphics);
            }
             //gBuffer.Render(e.Graphics);
       }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 4, 4); // 點擊點 畫小方塊
            //gBuffer.Render();
            double a = Math.Atan2(e.Y - balls[0].PosY, e.X - balls[0].PosX); // e:滑鼠 點擊處坐標
            balls[0].setAng(a); // 角度
            balls[0].posMouse(e.X, e.Y);
            panel1.Refresh(); // 重新繪畫球桿
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            double sum_spd = 0;  // 球速度 加總
            panel1.Refresh();  //呼叫panel1_Paint 事件處理副程式
            for (int i = 0; i < 10; i++)
            {
                if(balls[i].speed > 0)
                {
                    balls[i].move(); 
                    sum_spd += balls[i].speed;
                    balls[i].rebound();
                    for (int j = i + 1; j < 10; j++)  // j > i 兩球間不重複 碰撞偵測
                        hit(balls[i], balls[j]);
                }
                  // 移動 球
            }
            if (sum_spd <= 0.001)
            {  //  所有球 都停了
                timer1.Stop();		//  停止 計時器
                panel1.Refresh();
            }
        }

        private void Panel1_DoubleClick(object sender, EventArgs e)
        {
            // 每次擊球，重新初始化打擊力，摩擦力
            balls[0].speed = vScrollBar1.Maximum - vScrollBar1.Value; // 母球 加 速度
            fr = (vScrollBar2.Maximum - vScrollBar2.Value) / 50.0;  // 摩擦力
            timer1.Enabled = true;  // 開始定時 呼叫timer1_Tick
        }
        private void labelname_load(object sender, EventArgs e)
        {
            this.labelname.Text = username;
        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font("Georgia", 14, FontStyle.Bold);
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font("Georgia", 12, FontStyle.Bold);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelStop.Visible = true;
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            panelStop.Visible = false;
        }

        private void checkBox1_CheckedChange(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                timer1.Start();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {

        }
        private void buttonBtoM_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); //new form
            this.Visible = false;
            f.Visible = true;
        }

    }
}


namespace WinHello
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelStop = new System.Windows.Forms.Panel();
            this.buttonBtoM = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelflag = new System.Windows.Forms.Panel();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelStop.SuspendLayout();
            this.panelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(41, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 527);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.Panel1_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(841, 12);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(39, 180);
            this.vScrollBar2.TabIndex = 9;
            this.vScrollBar2.Visible = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(19, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(39, 180);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.Visible = false;
            // 
            // panelStop
            // 
            this.panelStop.Controls.Add(this.buttonBtoM);
            this.panelStop.Controls.Add(this.buttonNewGame);
            this.panelStop.Controls.Add(this.buttonContinue);
            this.panelStop.Controls.Add(this.labelOption);
            this.panelStop.Controls.Add(this.labelLine1);
            this.panelStop.Location = new System.Drawing.Point(3, 276);
            this.panelStop.Name = "panelStop";
            this.panelStop.Size = new System.Drawing.Size(980, 628);
            this.panelStop.TabIndex = 0;
            // 
            // buttonBtoM
            // 
            this.buttonBtoM.BackColor = System.Drawing.Color.LightGray;
            this.buttonBtoM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBtoM.BackgroundImage")));
            this.buttonBtoM.FlatAppearance.BorderSize = 0;
            this.buttonBtoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBtoM.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBtoM.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBtoM.Location = new System.Drawing.Point(385, 347);
            this.buttonBtoM.Name = "buttonBtoM";
            this.buttonBtoM.Size = new System.Drawing.Size(238, 34);
            this.buttonBtoM.TabIndex = 7;
            this.buttonBtoM.Text = "Back to Menu";
            this.buttonBtoM.UseVisualStyleBackColor = false;
            this.buttonBtoM.Click += new System.EventHandler(this.buttonBtoM_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.LightGray;
            this.buttonNewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewGame.BackgroundImage")));
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNewGame.Location = new System.Drawing.Point(385, 280);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(238, 34);
            this.buttonNewGame.TabIndex = 6;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.LightGray;
            this.buttonContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonContinue.BackgroundImage")));
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonContinue.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonContinue.Location = new System.Drawing.Point(385, 213);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(238, 34);
            this.buttonContinue.TabIndex = 5;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.BackColor = System.Drawing.Color.Transparent;
            this.labelOption.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOption.ForeColor = System.Drawing.Color.LightGray;
            this.labelOption.Location = new System.Drawing.Point(425, 153);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(135, 32);
            this.labelOption.TabIndex = 0;
            this.labelOption.Text = "OPTION";
            // 
            // labelLine1
            // 
            this.labelLine1.BackColor = System.Drawing.Color.LightGray;
            this.labelLine1.Location = new System.Drawing.Point(372, 197);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(260, 1);
            this.labelLine1.TabIndex = 3;
            this.labelLine1.Text = "label1";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelname.Location = new System.Drawing.Point(198, 32);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(97, 23);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Welcome ";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBack.Location = new System.Drawing.Point(3, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 65);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelflag
            // 
            this.panelflag.BackColor = System.Drawing.Color.Transparent;
            this.panelflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelflag.BackgroundImage")));
            this.panelflag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelflag.Location = new System.Drawing.Point(115, 12);
            this.panelflag.Name = "panelflag";
            this.panelflag.Size = new System.Drawing.Size(67, 59);
            this.panelflag.TabIndex = 9;
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBoard.Controls.Add(this.panelflag);
            this.panelBoard.Controls.Add(this.buttonBack);
            this.panelBoard.Controls.Add(this.labelname);
            this.panelBoard.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panelBoard.Location = new System.Drawing.Point(60, 23);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(861, 74);
            this.panelBoard.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.panelStop);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panelStop.ResumeLayout(false);
            this.panelStop.PerformLayout();
            this.panelBoard.ResumeLayout(false);
            this.panelBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelflag;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Panel panelStop;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonBtoM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}
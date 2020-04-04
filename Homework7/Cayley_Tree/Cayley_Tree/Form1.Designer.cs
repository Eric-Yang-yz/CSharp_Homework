namespace Cayley_Tree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.trbDepth = new System.Windows.Forms.TrackBar();
            this.trbLeng = new System.Windows.Forms.TrackBar();
            this.trbPer1 = new System.Windows.Forms.TrackBar();
            this.trbPer2 = new System.Windows.Forms.TrackBar();
            this.trbTh1 = new System.Windows.Forms.TrackBar();
            this.trbTh2 = new System.Windows.Forms.TrackBar();
            this.lblDepthShow = new System.Windows.Forms.Label();
            this.lblLengShow = new System.Windows.Forms.Label();
            this.lblPer1Show = new System.Windows.Forms.Label();
            this.lblPer2Show = new System.Windows.Forms.Label();
            this.lblTh1Show = new System.Windows.Forms.Label();
            this.lblTh2Show = new System.Windows.Forms.Label();
            this.icon1 = new System.Windows.Forms.Label();
            this.icon2 = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(3, 374);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(258, 71);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.icon2);
            this.pnlControl.Controls.Add(this.icon1);
            this.pnlControl.Controls.Add(this.lblTh2Show);
            this.pnlControl.Controls.Add(this.lblTh1Show);
            this.pnlControl.Controls.Add(this.lblPer2Show);
            this.pnlControl.Controls.Add(this.lblPer1Show);
            this.pnlControl.Controls.Add(this.lblLengShow);
            this.pnlControl.Controls.Add(this.lblDepthShow);
            this.pnlControl.Controls.Add(this.trbTh2);
            this.pnlControl.Controls.Add(this.trbTh1);
            this.pnlControl.Controls.Add(this.trbPer2);
            this.pnlControl.Controls.Add(this.trbPer1);
            this.pnlControl.Controls.Add(this.trbLeng);
            this.pnlControl.Controls.Add(this.trbDepth);
            this.pnlControl.Controls.Add(this.cmbColour);
            this.pnlControl.Controls.Add(this.lblColour);
            this.pnlControl.Controls.Add(this.lblTh2);
            this.pnlControl.Controls.Add(this.lblTh1);
            this.pnlControl.Controls.Add(this.lblPer2);
            this.pnlControl.Controls.Add(this.lblPer1);
            this.pnlControl.Controls.Add(this.lblLeng);
            this.pnlControl.Controls.Add(this.lblDepth);
            this.pnlControl.Controls.Add(this.btnDraw);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(534, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(266, 450);
            this.pnlControl.TabIndex = 1;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(0, 24);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(67, 15);
            this.lblDepth.TabIndex = 2;
            this.lblDepth.Text = "递归深度";
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(0, 65);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(67, 15);
            this.lblLeng.TabIndex = 3;
            this.lblLeng.Text = "主干长度";
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Location = new System.Drawing.Point(0, 106);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(97, 15);
            this.lblPer1.TabIndex = 4;
            this.lblPer1.Text = "右分支长度比";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Location = new System.Drawing.Point(0, 147);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(97, 15);
            this.lblPer2.TabIndex = 5;
            this.lblPer2.Text = "左分支长度比";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Location = new System.Drawing.Point(0, 188);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(82, 15);
            this.lblTh1.TabIndex = 6;
            this.lblTh1.Text = "右分支角度";
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Location = new System.Drawing.Point(0, 229);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(82, 15);
            this.lblTh2.TabIndex = 7;
            this.lblTh2.Text = "左分支角度";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(0, 291);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(67, 15);
            this.lblColour.TabIndex = 8;
            this.lblColour.Text = "画笔颜色";
            // 
            // cmbColour
            // 
            this.cmbColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Items.AddRange(new object[] {
            "红色",
            "橙色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色"});
            this.cmbColour.Location = new System.Drawing.Point(121, 291);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(121, 23);
            this.cmbColour.TabIndex = 9;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(534, 450);
            this.pnlDraw.TabIndex = 2;
            // 
            // trbDepth
            // 
            this.trbDepth.Location = new System.Drawing.Point(108, 24);
            this.trbDepth.Maximum = 20;
            this.trbDepth.Minimum = 1;
            this.trbDepth.Name = "trbDepth";
            this.trbDepth.Size = new System.Drawing.Size(153, 56);
            this.trbDepth.TabIndex = 10;
            this.trbDepth.Value = 10;
            this.trbDepth.Scroll += new System.EventHandler(this.trbDepth_Scroll);
            // 
            // trbLeng
            // 
            this.trbLeng.Location = new System.Drawing.Point(108, 65);
            this.trbLeng.Maximum = 150;
            this.trbLeng.Minimum = 50;
            this.trbLeng.Name = "trbLeng";
            this.trbLeng.Size = new System.Drawing.Size(153, 56);
            this.trbLeng.TabIndex = 11;
            this.trbLeng.Value = 100;
            this.trbLeng.Scroll += new System.EventHandler(this.trbLeng_Scroll);
            // 
            // trbPer1
            // 
            this.trbPer1.Location = new System.Drawing.Point(108, 106);
            this.trbPer1.Maximum = 100;
            this.trbPer1.Name = "trbPer1";
            this.trbPer1.Size = new System.Drawing.Size(153, 56);
            this.trbPer1.TabIndex = 12;
            this.trbPer1.Value = 60;
            this.trbPer1.Scroll += new System.EventHandler(this.trbPer1_Scroll);
            // 
            // trbPer2
            // 
            this.trbPer2.Location = new System.Drawing.Point(108, 147);
            this.trbPer2.Maximum = 100;
            this.trbPer2.Name = "trbPer2";
            this.trbPer2.Size = new System.Drawing.Size(153, 56);
            this.trbPer2.TabIndex = 13;
            this.trbPer2.Value = 70;
            this.trbPer2.Scroll += new System.EventHandler(this.trbPer2_Scroll);
            // 
            // trbTh1
            // 
            this.trbTh1.Location = new System.Drawing.Point(108, 188);
            this.trbTh1.Maximum = 180;
            this.trbTh1.Name = "trbTh1";
            this.trbTh1.Size = new System.Drawing.Size(153, 56);
            this.trbTh1.TabIndex = 14;
            this.trbTh1.Value = 30;
            this.trbTh1.Scroll += new System.EventHandler(this.trbTh1_Scroll);
            // 
            // trbTh2
            // 
            this.trbTh2.Location = new System.Drawing.Point(108, 229);
            this.trbTh2.Maximum = 180;
            this.trbTh2.Name = "trbTh2";
            this.trbTh2.Size = new System.Drawing.Size(153, 56);
            this.trbTh2.TabIndex = 15;
            this.trbTh2.Value = 20;
            this.trbTh2.Scroll += new System.EventHandler(this.trbTh2_Scroll);
            // 
            // lblDepthShow
            // 
            this.lblDepthShow.AutoSize = true;
            this.lblDepthShow.Location = new System.Drawing.Point(0, 39);
            this.lblDepthShow.Name = "lblDepthShow";
            this.lblDepthShow.Size = new System.Drawing.Size(23, 15);
            this.lblDepthShow.TabIndex = 16;
            this.lblDepthShow.Text = "10";
            // 
            // lblLengShow
            // 
            this.lblLengShow.AutoSize = true;
            this.lblLengShow.Location = new System.Drawing.Point(0, 80);
            this.lblLengShow.Name = "lblLengShow";
            this.lblLengShow.Size = new System.Drawing.Size(31, 15);
            this.lblLengShow.TabIndex = 17;
            this.lblLengShow.Text = "100";
            // 
            // lblPer1Show
            // 
            this.lblPer1Show.AutoSize = true;
            this.lblPer1Show.Location = new System.Drawing.Point(0, 121);
            this.lblPer1Show.Name = "lblPer1Show";
            this.lblPer1Show.Size = new System.Drawing.Size(31, 15);
            this.lblPer1Show.TabIndex = 18;
            this.lblPer1Show.Text = "0.6";
            // 
            // lblPer2Show
            // 
            this.lblPer2Show.AutoSize = true;
            this.lblPer2Show.Location = new System.Drawing.Point(0, 162);
            this.lblPer2Show.Name = "lblPer2Show";
            this.lblPer2Show.Size = new System.Drawing.Size(31, 15);
            this.lblPer2Show.TabIndex = 19;
            this.lblPer2Show.Text = "0.7";
            // 
            // lblTh1Show
            // 
            this.lblTh1Show.AutoSize = true;
            this.lblTh1Show.Location = new System.Drawing.Point(0, 203);
            this.lblTh1Show.Name = "lblTh1Show";
            this.lblTh1Show.Size = new System.Drawing.Size(23, 15);
            this.lblTh1Show.TabIndex = 20;
            this.lblTh1Show.Text = "30";
            // 
            // lblTh2Show
            // 
            this.lblTh2Show.AutoSize = true;
            this.lblTh2Show.Location = new System.Drawing.Point(0, 244);
            this.lblTh2Show.Name = "lblTh2Show";
            this.lblTh2Show.Size = new System.Drawing.Size(23, 15);
            this.lblTh2Show.TabIndex = 21;
            this.lblTh2Show.Text = "20";
            // 
            // icon1
            // 
            this.icon1.AutoSize = true;
            this.icon1.Location = new System.Drawing.Point(29, 203);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(22, 15);
            this.icon1.TabIndex = 22;
            this.icon1.Text = "°";
            // 
            // icon2
            // 
            this.icon2.AutoSize = true;
            this.icon2.Location = new System.Drawing.Point(29, 244);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(22, 15);
            this.icon2.TabIndex = 23;
            this.icon2.Text = "°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lblTh2Show;
        private System.Windows.Forms.Label lblTh1Show;
        private System.Windows.Forms.Label lblPer2Show;
        private System.Windows.Forms.Label lblPer1Show;
        private System.Windows.Forms.Label lblLengShow;
        private System.Windows.Forms.Label lblDepthShow;
        private System.Windows.Forms.TrackBar trbTh2;
        private System.Windows.Forms.TrackBar trbTh1;
        private System.Windows.Forms.TrackBar trbPer2;
        private System.Windows.Forms.TrackBar trbPer1;
        private System.Windows.Forms.TrackBar trbLeng;
        private System.Windows.Forms.TrackBar trbDepth;
        private System.Windows.Forms.Label icon2;
        private System.Windows.Forms.Label icon1;
    }
}


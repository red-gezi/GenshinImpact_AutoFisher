namespace 坎坎瑞亚钓鱼机
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_ShowLine = new System.Windows.Forms.CheckBox();
            this.cb_AutoLoadScreen = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.NumericUpDown();
            this.U1 = new System.Windows.Forms.NumericUpDown();
            this.V0 = new System.Windows.Forms.NumericUpDown();
            this.U0 = new System.Windows.Forms.NumericUpDown();
            this.btn_SetRect = new System.Windows.Forms.Button();
            this.game_height = new System.Windows.Forms.TextBox();
            this.game_width = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_github = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U0)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(298, 346);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 212);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.cb_ShowLine);
            this.tabPage2.Controls.Add(this.cb_AutoLoadScreen);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.V1);
            this.tabPage2.Controls.Add(this.U1);
            this.tabPage2.Controls.Add(this.V0);
            this.tabPage2.Controls.Add(this.U0);
            this.tabPage2.Controls.Add(this.btn_SetRect);
            this.tabPage2.Controls.Add(this.game_height);
            this.tabPage2.Controls.Add(this.game_width);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(290, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "校准";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 24);
            this.button3.TabIndex = 16;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cb_ShowLine
            // 
            this.cb_ShowLine.AutoSize = true;
            this.cb_ShowLine.Location = new System.Drawing.Point(20, 135);
            this.cb_ShowLine.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ShowLine.Name = "cb_ShowLine";
            this.cb_ShowLine.Size = new System.Drawing.Size(94, 17);
            this.cb_ShowLine.TabIndex = 14;
            this.cb_ShowLine.Text = "显示检查框";
            this.cb_ShowLine.UseVisualStyleBackColor = true;
            // 
            // cb_AutoLoadScreen
            // 
            this.cb_AutoLoadScreen.AutoSize = true;
            this.cb_AutoLoadScreen.Checked = true;
            this.cb_AutoLoadScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AutoLoadScreen.Location = new System.Drawing.Point(175, 62);
            this.cb_AutoLoadScreen.Margin = new System.Windows.Forms.Padding(2);
            this.cb_AutoLoadScreen.Name = "cb_AutoLoadScreen";
            this.cb_AutoLoadScreen.Size = new System.Drawing.Size(120, 17);
            this.cb_AutoLoadScreen.TabIndex = 13;
            this.cb_AutoLoadScreen.Text = "自动读取分辨率";
            this.cb_AutoLoadScreen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "偏移";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "缩放";
            // 
            // V1
            // 
            this.V1.Location = new System.Drawing.Point(89, 94);
            this.V1.Margin = new System.Windows.Forms.Padding(2);
            this.V1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.V1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(46, 21);
            this.V1.TabIndex = 10;
            this.V1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // U1
            // 
            this.U1.Location = new System.Drawing.Point(20, 94);
            this.U1.Margin = new System.Windows.Forms.Padding(2);
            this.U1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.U1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(46, 21);
            this.U1.TabIndex = 9;
            this.U1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // V0
            // 
            this.V0.Location = new System.Drawing.Point(89, 40);
            this.V0.Margin = new System.Windows.Forms.Padding(2);
            this.V0.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.V0.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.V0.Name = "V0";
            this.V0.Size = new System.Drawing.Size(46, 21);
            this.V0.TabIndex = 8;
            this.V0.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // U0
            // 
            this.U0.Location = new System.Drawing.Point(20, 40);
            this.U0.Margin = new System.Windows.Forms.Padding(2);
            this.U0.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.U0.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.U0.Name = "U0";
            this.U0.Size = new System.Drawing.Size(46, 21);
            this.U0.TabIndex = 7;
            this.U0.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // btn_SetRect
            // 
            this.btn_SetRect.Location = new System.Drawing.Point(175, 94);
            this.btn_SetRect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SetRect.Name = "btn_SetRect";
            this.btn_SetRect.Size = new System.Drawing.Size(86, 27);
            this.btn_SetRect.TabIndex = 7;
            this.btn_SetRect.Text = "手动提交分辨率";
            this.btn_SetRect.UseVisualStyleBackColor = true;
            this.btn_SetRect.Click += new System.EventHandler(this.btn_SetRect_Click);
            // 
            // game_height
            // 
            this.game_height.Location = new System.Drawing.Point(220, 26);
            this.game_height.Margin = new System.Windows.Forms.Padding(2);
            this.game_height.Name = "game_height";
            this.game_height.Size = new System.Drawing.Size(44, 21);
            this.game_height.TabIndex = 5;
            this.game_height.Text = "1080";
            // 
            // game_width
            // 
            this.game_width.Location = new System.Drawing.Point(175, 26);
            this.game_width.Margin = new System.Windows.Forms.Padding(2);
            this.game_width.Name = "game_width";
            this.game_width.Size = new System.Drawing.Size(42, 21);
            this.game_width.TabIndex = 4;
            this.game_width.Text = "1920";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.btn_github);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(290, 186);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "更新";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "访问原神Bwiki地图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "请我吃雪糕";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_github
            // 
            this.btn_github.Location = new System.Drawing.Point(167, 18);
            this.btn_github.Margin = new System.Windows.Forms.Padding(2);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(123, 42);
            this.btn_github.TabIndex = 0;
            this.btn_github.Text = "访问项目开源页面";
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "钓鱼进度条";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "体力条中心";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(116, 66);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(170, 30);
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Value = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 31);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 346);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "凯瑞亚钓鱼机v1.0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.U1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.U0)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_ShowLine;
        private System.Windows.Forms.CheckBox cb_AutoLoadScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown V1;
        private System.Windows.Forms.NumericUpDown U1;
        private System.Windows.Forms.NumericUpDown V0;
        private System.Windows.Forms.NumericUpDown U0;
        private System.Windows.Forms.Button btn_SetRect;
        private System.Windows.Forms.TextBox game_height;
        private System.Windows.Forms.TextBox game_width;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


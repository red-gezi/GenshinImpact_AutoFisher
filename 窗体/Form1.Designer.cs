namespace 坎瑞亚钓鱼机
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.pict_step = new System.Windows.Forms.PictureBox();
            this.pict_current = new System.Windows.Forms.PictureBox();
            this.pict_range = new System.Windows.Forms.PictureBox();
            this.pict_sign = new System.Windows.Forms.PictureBox();
            this.pict_game = new System.Windows.Forms.PictureBox();
            this.pict_bar = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U0)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 701);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Pause);
            this.tabPage2.Controls.Add(this.pict_step);
            this.tabPage2.Controls.Add(this.pict_current);
            this.tabPage2.Controls.Add(this.pict_range);
            this.tabPage2.Controls.Add(this.pict_sign);
            this.tabPage2.Controls.Add(this.pict_game);
            this.tabPage2.Controls.Add(this.pict_bar);
            this.tabPage2.Controls.Add(this.btn_open);
            this.tabPage2.Controls.Add(this.button3);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(419, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "校准";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(233, 169);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(115, 32);
            this.btn_Pause.TabIndex = 22;
            this.btn_Pause.Text = "暂停（P）";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // pict_step
            // 
            this.pict_step.Location = new System.Drawing.Point(15, 407);
            this.pict_step.Name = "pict_step";
            this.pict_step.Size = new System.Drawing.Size(352, 45);
            this.pict_step.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_step.TabIndex = 21;
            this.pict_step.TabStop = false;
            // 
            // pict_current
            // 
            this.pict_current.Location = new System.Drawing.Point(15, 508);
            this.pict_current.Name = "pict_current";
            this.pict_current.Size = new System.Drawing.Size(352, 41);
            this.pict_current.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_current.TabIndex = 20;
            this.pict_current.TabStop = false;
            // 
            // pict_range
            // 
            this.pict_range.Location = new System.Drawing.Point(15, 458);
            this.pict_range.Name = "pict_range";
            this.pict_range.Size = new System.Drawing.Size(352, 44);
            this.pict_range.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_range.TabIndex = 19;
            this.pict_range.TabStop = false;
            // 
            // pict_sign
            // 
            this.pict_sign.Location = new System.Drawing.Point(15, 356);
            this.pict_sign.Name = "pict_sign";
            this.pict_sign.Size = new System.Drawing.Size(352, 45);
            this.pict_sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_sign.TabIndex = 18;
            this.pict_sign.TabStop = false;
            // 
            // pict_game
            // 
            this.pict_game.Location = new System.Drawing.Point(15, 169);
            this.pict_game.Name = "pict_game";
            this.pict_game.Size = new System.Drawing.Size(165, 93);
            this.pict_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_game.TabIndex = 17;
            this.pict_game.TabStop = false;
            // 
            // pict_bar
            // 
            this.pict_bar.Location = new System.Drawing.Point(15, 305);
            this.pict_bar.Name = "pict_bar";
            this.pict_bar.Size = new System.Drawing.Size(352, 45);
            this.pict_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_bar.TabIndex = 7;
            this.pict_bar.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(199, 218);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 30);
            this.btn_open.TabIndex = 15;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 218);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cb_AutoLoadScreen
            // 
            this.cb_AutoLoadScreen.AutoSize = true;
            this.cb_AutoLoadScreen.Checked = true;
            this.cb_AutoLoadScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AutoLoadScreen.Location = new System.Drawing.Point(233, 78);
            this.cb_AutoLoadScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_AutoLoadScreen.Name = "cb_AutoLoadScreen";
            this.cb_AutoLoadScreen.Size = new System.Drawing.Size(134, 19);
            this.cb_AutoLoadScreen.TabIndex = 13;
            this.cb_AutoLoadScreen.Text = "自动读取分辨率";
            this.cb_AutoLoadScreen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "右下坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "左上坐标";
            // 
            // V1
            // 
            this.V1.Location = new System.Drawing.Point(119, 118);
            this.V1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.V1.Size = new System.Drawing.Size(61, 25);
            this.V1.TabIndex = 10;
            this.V1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // U1
            // 
            this.U1.Location = new System.Drawing.Point(27, 118);
            this.U1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.U1.Size = new System.Drawing.Size(61, 25);
            this.U1.TabIndex = 9;
            this.U1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // V0
            // 
            this.V0.Location = new System.Drawing.Point(119, 50);
            this.V0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.V0.Size = new System.Drawing.Size(61, 25);
            this.V0.TabIndex = 8;
            this.V0.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // U0
            // 
            this.U0.Location = new System.Drawing.Point(27, 50);
            this.U0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.U0.Size = new System.Drawing.Size(61, 25);
            this.U0.TabIndex = 7;
            this.U0.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // btn_SetRect
            // 
            this.btn_SetRect.Location = new System.Drawing.Point(233, 118);
            this.btn_SetRect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SetRect.Name = "btn_SetRect";
            this.btn_SetRect.Size = new System.Drawing.Size(115, 34);
            this.btn_SetRect.TabIndex = 7;
            this.btn_SetRect.Text = "手动提交分辨率";
            this.btn_SetRect.UseVisualStyleBackColor = true;
            this.btn_SetRect.Click += new System.EventHandler(this.btn_SetRect_Click);
            // 
            // game_height
            // 
            this.game_height.Location = new System.Drawing.Point(293, 32);
            this.game_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_height.Name = "game_height";
            this.game_height.Size = new System.Drawing.Size(57, 25);
            this.game_height.TabIndex = 5;
            this.game_height.Text = "1080";
            // 
            // game_width
            // 
            this.game_width.Location = new System.Drawing.Point(233, 32);
            this.game_width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_width.Name = "game_width";
            this.game_width.Size = new System.Drawing.Size(55, 25);
            this.game_width.TabIndex = 4;
            this.game_width.Text = "1920";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.btn_github);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(419, 672);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "更新";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "访问原神Bwiki地图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "请我吃雪糕";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_github
            // 
            this.btn_github.Location = new System.Drawing.Point(223, 22);
            this.btn_github.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(164, 52);
            this.btn_github.TabIndex = 0;
            this.btn_github.Text = "访问项目开源页面";
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 701);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "凯瑞亚钓鱼机v1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_current)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_bar)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.PictureBox pict_game;
        private System.Windows.Forms.PictureBox pict_bar;
        private System.Windows.Forms.PictureBox pict_sign;
        private System.Windows.Forms.PictureBox pict_current;
        private System.Windows.Forms.PictureBox pict_range;
        private System.Windows.Forms.PictureBox pict_step;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Pause;
    }
}


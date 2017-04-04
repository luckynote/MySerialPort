namespace MutilSerialPort
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_start = new System.Windows.Forms.Button();
            this.button2_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_inf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_inf = new System.Windows.Forms.TextBox();
            this.textBox3_inf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_start
            // 
            this.button1_start.Location = new System.Drawing.Point(130, 122);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(100, 39);
            this.button1_start.TabIndex = 0;
            this.button1_start.Text = "启动";
            this.button1_start.UseVisualStyleBackColor = true;
            this.button1_start.Click += new System.EventHandler(this.button1_start_Click);
            // 
            // button2_start
            // 
            this.button2_start.Location = new System.Drawing.Point(370, 122);
            this.button2_start.Name = "button2_start";
            this.button2_start.Size = new System.Drawing.Size(100, 39);
            this.button2_start.TabIndex = 1;
            this.button2_start.Text = "启动";
            this.button2_start.UseVisualStyleBackColor = true;
            this.button2_start.Click += new System.EventHandler(this.button2_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM3";
            // 
            // textBox1_inf
            // 
            this.textBox1_inf.Location = new System.Drawing.Point(130, 80);
            this.textBox1_inf.Name = "textBox1_inf";
            this.textBox1_inf.Size = new System.Drawing.Size(100, 25);
            this.textBox1_inf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "COM5";
            // 
            // textBox2_inf
            // 
            this.textBox2_inf.Location = new System.Drawing.Point(370, 80);
            this.textBox2_inf.Name = "textBox2_inf";
            this.textBox2_inf.Size = new System.Drawing.Size(100, 25);
            this.textBox2_inf.TabIndex = 5;
            // 
            // textBox3_inf
            // 
            this.textBox3_inf.Location = new System.Drawing.Point(599, 80);
            this.textBox3_inf.Name = "textBox3_inf";
            this.textBox3_inf.Size = new System.Drawing.Size(100, 25);
            this.textBox3_inf.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "COM6";
            // 
            // button3_start
            // 
            this.button3_start.Location = new System.Drawing.Point(599, 122);
            this.button3_start.Name = "button3_start";
            this.button3_start.Size = new System.Drawing.Size(100, 39);
            this.button3_start.TabIndex = 6;
            this.button3_start.Text = "启动";
            this.button3_start.UseVisualStyleBackColor = true;
            this.button3_start.Click += new System.EventHandler(this.button3_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 538);
            this.Controls.Add(this.textBox3_inf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3_start);
            this.Controls.Add(this.textBox2_inf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_inf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_start);
            this.Controls.Add(this.button1_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.Button button2_start;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1_inf;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2_inf;
        public System.Windows.Forms.TextBox textBox3_inf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3_start;
    }
}


namespace ButtonDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSayHello = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSayHello.FlatAppearance.BorderSize = 3;
            this.btnSayHello.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSayHello.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.Location = new System.Drawing.Point(280, 326);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(204, 63);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSayHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


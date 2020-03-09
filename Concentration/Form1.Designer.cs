namespace Concentration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timercount = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clubs-2-75.png");
            this.imageList1.Images.SetKeyName(1, "clubs-3-75.png");
            this.imageList1.Images.SetKeyName(2, "clubs-4-75.png");
            this.imageList1.Images.SetKeyName(3, "clubs-5-75.png");
            this.imageList1.Images.SetKeyName(4, "clubs-6-75.png");
            this.imageList1.Images.SetKeyName(5, "clubs-7-75.png");
            this.imageList1.Images.SetKeyName(6, "clubs-8-75.png");
            this.imageList1.Images.SetKeyName(7, "clubs-9-75.png");
            this.imageList1.Images.SetKeyName(8, "clubs-10-75.png");
            this.imageList1.Images.SetKeyName(9, "clubs-j-75.png");
            this.imageList1.Images.SetKeyName(10, "clubs-q-75.png");
            this.imageList1.Images.SetKeyName(11, "clubs-k-75.png");
            this.imageList1.Images.SetKeyName(12, "clubs-a-75.png");
            this.imageList1.Images.SetKeyName(13, "diamonds-2-75.png");
            this.imageList1.Images.SetKeyName(14, "diamonds-3-75.png");
            this.imageList1.Images.SetKeyName(15, "diamonds-4-75.png");
            this.imageList1.Images.SetKeyName(16, "diamonds-5-75.png");
            this.imageList1.Images.SetKeyName(17, "diamonds-6-75.png");
            this.imageList1.Images.SetKeyName(18, "diamonds-7-75.png");
            this.imageList1.Images.SetKeyName(19, "diamonds-8-75.png");
            this.imageList1.Images.SetKeyName(20, "diamonds-9-75.png");
            this.imageList1.Images.SetKeyName(21, "diamonds-10-75.png");
            this.imageList1.Images.SetKeyName(22, "diamonds-j-75.png");
            this.imageList1.Images.SetKeyName(23, "diamonds-q-75.png");
            this.imageList1.Images.SetKeyName(24, "diamonds-k-75.png");
            this.imageList1.Images.SetKeyName(25, "diamonds-a-75.png");
            this.imageList1.Images.SetKeyName(26, "hearts-2-75.png");
            this.imageList1.Images.SetKeyName(27, "hearts-3-75.png");
            this.imageList1.Images.SetKeyName(28, "hearts-4-75.png");
            this.imageList1.Images.SetKeyName(29, "hearts-5-75.png");
            this.imageList1.Images.SetKeyName(30, "hearts-6-75.png");
            this.imageList1.Images.SetKeyName(31, "hearts-7-75.png");
            this.imageList1.Images.SetKeyName(32, "hearts-8-75.png");
            this.imageList1.Images.SetKeyName(33, "hearts-9-75.png");
            this.imageList1.Images.SetKeyName(34, "hearts-10-75.png");
            this.imageList1.Images.SetKeyName(35, "hearts-j-75.png");
            this.imageList1.Images.SetKeyName(36, "hearts-q-75.png");
            this.imageList1.Images.SetKeyName(37, "hearts-k-75.png");
            this.imageList1.Images.SetKeyName(38, "hearts-a-75.png");
            this.imageList1.Images.SetKeyName(39, "spades-2-75.png");
            this.imageList1.Images.SetKeyName(40, "spades-3-75.png");
            this.imageList1.Images.SetKeyName(41, "spades-4-75.png");
            this.imageList1.Images.SetKeyName(42, "spades-5-75.png");
            this.imageList1.Images.SetKeyName(43, "spades-6-75.png");
            this.imageList1.Images.SetKeyName(44, "spades-7-75.png");
            this.imageList1.Images.SetKeyName(45, "spades-8-75.png");
            this.imageList1.Images.SetKeyName(46, "spades-9-75.png");
            this.imageList1.Images.SetKeyName(47, "spades-10-75.png");
            this.imageList1.Images.SetKeyName(48, "spades-j-75.png");
            this.imageList1.Images.SetKeyName(49, "spades-q-75.png");
            this.imageList1.Images.SetKeyName(50, "spades-k-75.png");
            this.imageList1.Images.SetKeyName(51, "spades-a-75.png");
            this.imageList1.Images.SetKeyName(52, "joker-b-75.png");
            this.imageList1.Images.SetKeyName(53, "joker-r-75.png");
            this.imageList1.Images.SetKeyName(54, "back-red-75-3.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timercount
            // 
            this.timercount.Interval = 500;
            this.timercount.Tick += new System.EventHandler(this.timercount_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1687, 621);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1687, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 1783);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Concentration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timercount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}


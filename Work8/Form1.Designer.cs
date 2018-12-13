namespace Work8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNG图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEG图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMP图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIF图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.铅笔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橡皮擦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.椭圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩阵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.saveFiles = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.图形ToolStripMenuItem,
            this.粗细ToolStripMenuItem,
            this.颜色ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1612, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.关于画图ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNG图片ToolStripMenuItem,
            this.jPEG图片ToolStripMenuItem,
            this.bMP图片ToolStripMenuItem,
            this.gIF图片ToolStripMenuItem});
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // pNG图片ToolStripMenuItem
            // 
            this.pNG图片ToolStripMenuItem.Name = "pNG图片ToolStripMenuItem";
            this.pNG图片ToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.pNG图片ToolStripMenuItem.Text = "PNG图片((&P)";
            this.pNG图片ToolStripMenuItem.Click += new System.EventHandler(this.pNG图片ToolStripMenuItem_Click);
            // 
            // jPEG图片ToolStripMenuItem
            // 
            this.jPEG图片ToolStripMenuItem.Name = "jPEG图片ToolStripMenuItem";
            this.jPEG图片ToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.jPEG图片ToolStripMenuItem.Text = "JPEG图片(&J)";
            this.jPEG图片ToolStripMenuItem.Click += new System.EventHandler(this.jPEG图片ToolStripMenuItem_Click);
            // 
            // bMP图片ToolStripMenuItem
            // 
            this.bMP图片ToolStripMenuItem.Name = "bMP图片ToolStripMenuItem";
            this.bMP图片ToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.bMP图片ToolStripMenuItem.Text = "BMP图片(&B)";
            this.bMP图片ToolStripMenuItem.Click += new System.EventHandler(this.bMP图片ToolStripMenuItem_Click);
            // 
            // gIF图片ToolStripMenuItem
            // 
            this.gIF图片ToolStripMenuItem.Name = "gIF图片ToolStripMenuItem";
            this.gIF图片ToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.gIF图片ToolStripMenuItem.Text = "GIF图片(&G)";
            this.gIF图片ToolStripMenuItem.Click += new System.EventHandler(this.gIF图片ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印ToolStripMenuItem1,
            this.页面设置ToolStripMenuItem});
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // 打印ToolStripMenuItem1
            // 
            this.打印ToolStripMenuItem1.Name = "打印ToolStripMenuItem1";
            this.打印ToolStripMenuItem1.Size = new System.Drawing.Size(208, 38);
            this.打印ToolStripMenuItem1.Text = "打印";
            this.打印ToolStripMenuItem1.Click += new System.EventHandler(this.打印ToolStripMenuItem1_Click);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            this.页面设置ToolStripMenuItem.Click += new System.EventHandler(this.页面设置ToolStripMenuItem_Click);
            // 
            // 关于画图ToolStripMenuItem
            // 
            this.关于画图ToolStripMenuItem.Name = "关于画图ToolStripMenuItem";
            this.关于画图ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.关于画图ToolStripMenuItem.Text = "关于画图";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.铅笔ToolStripMenuItem,
            this.橡皮擦ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 铅笔ToolStripMenuItem
            // 
            this.铅笔ToolStripMenuItem.Name = "铅笔ToolStripMenuItem";
            this.铅笔ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.铅笔ToolStripMenuItem.Text = "铅笔";
            this.铅笔ToolStripMenuItem.Click += new System.EventHandler(this.铅笔ToolStripMenuItem_Click);
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            this.橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            this.橡皮擦ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            this.橡皮擦ToolStripMenuItem.Click += new System.EventHandler(this.橡皮擦ToolStripMenuItem_Click);
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直线ToolStripMenuItem,
            this.椭圆ToolStripMenuItem,
            this.矩阵ToolStripMenuItem});
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.图形ToolStripMenuItem.Text = "图形";
            // 
            // 直线ToolStripMenuItem
            // 
            this.直线ToolStripMenuItem.Name = "直线ToolStripMenuItem";
            this.直线ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.直线ToolStripMenuItem.Text = "直线";
            this.直线ToolStripMenuItem.Click += new System.EventHandler(this.直线ToolStripMenuItem_Click);
            // 
            // 椭圆ToolStripMenuItem
            // 
            this.椭圆ToolStripMenuItem.Name = "椭圆ToolStripMenuItem";
            this.椭圆ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.椭圆ToolStripMenuItem.Text = "椭圆";
            this.椭圆ToolStripMenuItem.Click += new System.EventHandler(this.椭圆ToolStripMenuItem_Click);
            // 
            // 矩阵ToolStripMenuItem
            // 
            this.矩阵ToolStripMenuItem.Name = "矩阵ToolStripMenuItem";
            this.矩阵ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.矩阵ToolStripMenuItem.Text = "矩阵";
            this.矩阵ToolStripMenuItem.Click += new System.EventHandler(this.矩阵ToolStripMenuItem_Click);
            // 
            // 粗细ToolStripMenuItem
            // 
            this.粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3});
            this.粗细ToolStripMenuItem.Name = "粗细ToolStripMenuItem";
            this.粗细ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.粗细ToolStripMenuItem.Text = "粗细";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.pxToolStripMenuItem.Text = "1px";
            this.pxToolStripMenuItem.Click += new System.EventHandler(this.pxToolStripMenuItem_Click);
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(324, 38);
            this.pxToolStripMenuItem1.Text = "2px";
            this.pxToolStripMenuItem1.Click += new System.EventHandler(this.pxToolStripMenuItem1_Click);
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(324, 38);
            this.pxToolStripMenuItem2.Text = "3px";
            this.pxToolStripMenuItem2.Click += new System.EventHandler(this.pxToolStripMenuItem2_Click);
            // 
            // pxToolStripMenuItem3
            // 
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Size = new System.Drawing.Size(324, 38);
            this.pxToolStripMenuItem3.Text = "4px";
            this.pxToolStripMenuItem3.Click += new System.EventHandler(this.pxToolStripMenuItem3_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // openFiles
            // 
            this.openFiles.FileName = "openFiles";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1612, 968);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 1003);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Laj\'s Drawing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNG图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEG图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMP图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIF图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 铅笔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 椭圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩阵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFiles;
        private System.Windows.Forms.SaveFileDialog saveFiles;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


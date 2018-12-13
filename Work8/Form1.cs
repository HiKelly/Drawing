using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work8
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false; //是否正在绘图
        private Point startPoint, oldPoint; //绘图时记录鼠标的位置
        private bool flag = false;
        private enum drawTools  //各种绘图工具
        {
            Pen = 0, Line, Ellipse, Rectangle, String, Rubber,None
        };
        private drawTools drawTool = drawTools.None;    //当前使用工具
        private string editFileName;
        private Image theImage;
        private Graphics ig;
        private Color foreColor = Color.Black;
        private Color backColor = Color.White;
        private int i = 0;  //在保存文件时用来标记文件
        private Bitmap myImage; //位图，用来存储画板的基础
        private int PBwidth;    //画板宽度
        private int PBheight;   //画板高度
        private int fontSize;   //笔的粗细

        public Form1()
        {
            InitializeComponent();
            PBheight = pictureBox1.Height;
            PBwidth = pictureBox1.Width;
            myImage = new Bitmap(PBwidth, PBheight);
            Graphics g = Graphics.FromImage(myImage);   //将位图作为画板
            g.Clear(backColor);
            pictureBox1.Image = myImage;
            editFileName = "新建文件";
            this.Text = editFileName;
            ig = Graphics.FromImage(myImage);
            ig.Clear(backColor);
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFiles.Filter = "ImageFiles(*.bmp;*.wmf;*.ico;*.cur;*.jpg)|*.bmp;*.wmf;*.ico;*.cur;*.jpg";
            openFiles.Multiselect = false;
            if(openFiles.ShowDialog() == DialogResult.OK)
            {
                //修改窗口标题
                this.Text = openFiles.FileName;
                editFileName = openFiles.FileName;
                theImage = Image.FromFile(openFiles.FileName);
                Graphics g = this.CreateGraphics();
                g.DrawImage(theImage, this.ClientRectangle);
                pictureBox1.Image = theImage;
                //ig = Graphics.FromImage(theImage);
                //ig.DrawImage(theImage, this.ClientRectangle);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFiles.FileName.Length > 0)
            {
                ImageFormat format = theImage.RawFormat;
                theImage.Save(saveFiles.FileName, format);
                flag = true;
            }
            else
            {
                //新建文件
                bMP图片ToolStripMenuItem_Click(sender, e);
            }
        }

        private void pNG图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileFunction("png", ImageFormat.Png);
        }

        private void saveFileFunction(string s, ImageFormat format)
        {
            saveFiles.Filter = "图像(*." + s + ")|*." + s;
            saveFiles.FileName = editFileName;
            if(saveFiles.ShowDialog() == DialogResult.OK)
            {
                theImage.Save(saveFiles.FileName, format);
                this.Text = saveFiles.FileName;
                editFileName = saveFiles.FileName;
                i++;
            }
            flag = true;
        }

        private void bMP图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileFunction("bmp", ImageFormat.Bmp);
        }

        private void jPEG图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileFunction("jpeg", ImageFormat.Jpeg);
        }

        private void gIF图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileFunction("gif", ImageFormat.Gif);
        }

        private void 打印ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                DialogResult result = MessageBox.Show("是否将更改保存", "舞文 1.0.0", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    保存ToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    //不保存就什么都不用做了
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void 椭圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            铅笔ToolStripMenuItem.Checked = false;
            橡皮擦ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            椭圆ToolStripMenuItem.Checked = true;
            矩阵ToolStripMenuItem.Checked = false;
            if (椭圆ToolStripMenuItem.Checked)
            {
                drawTool = drawTools.Ellipse;
            }
        }

        private void 铅笔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            铅笔ToolStripMenuItem.Checked = true;
            橡皮擦ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            椭圆ToolStripMenuItem.Checked = false;
            矩阵ToolStripMenuItem.Checked = false;
            if (铅笔ToolStripMenuItem.Checked)
            {
                drawTool = drawTools.Pen;
            }
        }

        

        private void 橡皮擦ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            铅笔ToolStripMenuItem.Checked = false;
            橡皮擦ToolStripMenuItem.Checked = true;
            直线ToolStripMenuItem.Checked = false;
            椭圆ToolStripMenuItem.Checked = false;
            矩阵ToolStripMenuItem.Checked = false;
            if (橡皮擦ToolStripMenuItem.Checked)
            {
                drawTool = drawTools.Rubber;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(backColor);

            //创建一个Bitmap
            myImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            editFileName = "新建文件";

            //修改窗口标题
            this.Text = editFileName;
            ig = Graphics.FromImage(myImage);
            ig.Clear(backColor);
            pictureBox1.Image = myImage;
        }

        private void 直线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            铅笔ToolStripMenuItem.Checked = false;
            橡皮擦ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = true;
            椭圆ToolStripMenuItem.Checked = false;
            矩阵ToolStripMenuItem.Checked = false;
            if (直线ToolStripMenuItem.Checked)
            {
                drawTool = drawTools.Line;
            }
        }

        private void 矩阵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            铅笔ToolStripMenuItem.Checked = false;
            橡皮擦ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            椭圆ToolStripMenuItem.Checked = false;
            矩阵ToolStripMenuItem.Checked = true;
            if (矩阵ToolStripMenuItem.Checked)
            {
                drawTool = drawTools.Rectangle;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if(theImage != null)
            {
                g.Clear(Color.White);
                g.DrawImage(theImage, this.ClientRectangle);
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            //将Image中保存的图像，绘制出来
            Graphics g = this.CreateGraphics();
            if (myImage != null)
            {
                g.Clear(Color.White);
                g.DrawImage(myImage, this.ClientRectangle);
            }
            //pictureBox1.Image = myImage;
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //将Image中保存的图像，绘制出来
            Graphics g = this.CreateGraphics();
            if(myImage != null)
            {
                g.Clear(Color.White);
                g.DrawImage(myImage, this.ClientRectangle);
            }
        }

        
        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize = 1;
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            pxToolStripMenuItem.Checked = true;
            pxToolStripMenuItem1.Checked = false;
            pxToolStripMenuItem2.Checked = false;
            pxToolStripMenuItem3.Checked = false;
        }

        private void pxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontSize = 2;
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            pxToolStripMenuItem.Checked = false;
            pxToolStripMenuItem1.Checked = true;
            pxToolStripMenuItem2.Checked = false;
            pxToolStripMenuItem3.Checked = false;
        }

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fontSize = 3;
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            pxToolStripMenuItem.Checked = false;
            pxToolStripMenuItem1.Checked = false;
            pxToolStripMenuItem2.Checked = true;
            pxToolStripMenuItem3.Checked = false;
        }

        private void pxToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fontSize = 4;
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            pxToolStripMenuItem.Checked = false;
            pxToolStripMenuItem1.Checked = false;
            pxToolStripMenuItem2.Checked = false;
            pxToolStripMenuItem3.Checked = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing = !isDrawing)
                {
                    startPoint = new Point(e.X, e.Y);
                    oldPoint = new Point(e.X, e.Y);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myImage);
            ig = Graphics.FromImage(myImage);
            if (isDrawing)
            {
                switch (drawTool)
                {
                    case drawTools.None: break;
                    case drawTools.Pen:
                        //从上一个点到当前点绘制线段
                        g.DrawLine(new Pen(foreColor, fontSize), oldPoint, new Point(e.X, e.Y));
                        //ig.DrawLine(new Pen(foreColor, 1), oldPoint, new Point(e.X, e.Y));
                        oldPoint.X = e.X;
                        oldPoint.Y = e.Y;
                        pictureBox1.Image = myImage;
                        break;
                    case drawTools.Rubber:
                        //用背景色绘制线段
                        g.DrawLine(new Pen(backColor, 20), oldPoint, new Point(e.X, e.Y));
                        oldPoint.X = e.X;
                        oldPoint.Y = e.Y;
                        pictureBox1.Image = myImage;
                        break;
                }
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            switch (drawTool)
            {
                case drawTools.Line:
                    ig.DrawLine(new Pen(foreColor, fontSize), startPoint, new Point(e.X, e.Y));
                    pictureBox1.Image = myImage;
                    break;
                case drawTools.Ellipse:
                    ig.DrawEllipse(new Pen(foreColor, fontSize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                    pictureBox1.Image = myImage;
                    break;
                case drawTools.Rectangle:
                    ig.DrawRectangle(new Pen(foreColor, fontSize), startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                    pictureBox1.Image = myImage;
                    break;
            }
            //MessageBox.Show(drawTool.ToString());
        }
    }
}

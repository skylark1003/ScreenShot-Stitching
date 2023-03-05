using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class ScreenShot : Form
    {
        public ScreenShot()
        {
            InitializeComponent();
        }
        int up = 0;
        int down = 10;

        Bitmap[] bitmap_arr = new Bitmap[20];

        String filenames = "";  //显示所选图片路径

        int num = 0;  //设置默认图片及个数
        String[] filenames_arr = new String[30] {"","", "", "", "", "", "", "", "", "", "", "", "", "", 
        "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };  //图片路径数组

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Bitmap pic_cut(Bitmap source_bitmap, int right, int up, int down)  //裁剪图片
        {
            Rectangle cropRect = new Rectangle(0, up, right, down - up);
            Bitmap target = new Bitmap(right, down - up);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(source_bitmap, 0, 0, cropRect, GraphicsUnit.Pixel);
            }
            return target;
        }

        public Bitmap pic_add(Bitmap source_bitmap1, Bitmap source_bitmap2)  //合并两张图片
        {
            Bitmap bitmap = new Bitmap(Math.Max(source_bitmap1.Width, source_bitmap2.Width), source_bitmap1.Height + source_bitmap2.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source_bitmap1, 0, 0);
                g.DrawImage(source_bitmap2, 0, source_bitmap1.Height);
            }
            return bitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            up = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            down = trackBar2.Value;
        }

        private void ScreenShot_Paint(object sender, PaintEventArgs e)
        {
            Rectangle tang = this.ClientRectangle;					//获取窗口矩形 为了下面得到窗口的宽高
            Graphics g3 = e.Graphics;								//新建一个画布
            Color c3 = Color.FromArgb(81, 73, 109);				    //声明一个 颜色
            Pen p3 = new Pen(c3);									//新建一支画笔
            g3.DrawLine(p3, 0, 0, 0, tang.Height - 1);				//在（0，0）和（tang.Width - 1, 0）这两点间画一条直线
            g3.DrawLine(p3, 0, tang.Height - 1, tang.Width - 1, tang.Height - 1);	//注意必须减1 不然显示不出来  因为 如果假设窗口的高度是3像素 我们知道（0，0）位置代表 窗口最左上角的像素点  那么最左下角的像素点应该是（0，2） 而不是（0，3） 因为0，1，2 已经三个像素点了
            g3.DrawLine(p3, tang.Width - 1, tang.Height - 1, tang.Width - 1, 0);
            g3.DrawLine(p3, tang.Width - 1, 0, 0, 0);
        }

        private void select_pic_Click(object sender, EventArgs e)
        {
            filenames = "";
            OpenFileDialog sel_screen = new OpenFileDialog();
            sel_screen.Title = "请选择上传的图片";
            sel_screen.Filter = "图片格式|*.jpg;*.png;";
            sel_screen.Multiselect = true;
            if (sel_screen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                num = sel_screen.FileNames.Length;
                for (int i = 0; i < sel_screen.FileNames.Length; i++)
                {
                    filenames = filenames + sel_screen.FileNames.GetValue(i).ToString() + Environment.NewLine;
                    filenames_arr[i] = sel_screen.FileNames.GetValue(i).ToString();
                }
            }

            pic_path.Text = "pics：" + Environment.NewLine + filenames;

            trackBar1.Minimum = 0;   //定义trackbar的最大最小值
            trackBar1.Maximum = new Bitmap(filenames_arr[0]).Height;

            trackBar2.Minimum = 0;
            trackBar2.Maximum = new Bitmap(filenames_arr[0]).Height;
        }

        private void add_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog sel_screen = new OpenFileDialog();
            sel_screen.Title = "请选择上传的图片";
            sel_screen.Filter = "图片格式|*.jpg;*.png;";
            sel_screen.Multiselect = true;
            if (sel_screen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {           
                for (int i = 0; i < sel_screen.FileNames.Length; i++)
                {
                    filenames = filenames + sel_screen.FileNames.GetValue(i).ToString() + Environment.NewLine;
                    filenames_arr[i + num] = sel_screen.FileNames.GetValue(i).ToString();
                }
                num = sel_screen.FileNames.Length + num;
            }
            pic_path.Text = "pics：" + Environment.NewLine + filenames;
        }

        private void preview_Click(object sender, EventArgs e)
        {
            if (num != 0 && up < down)
            {
                for (int i = 0; i < num; i++)    //根据路径获得图片数组
                    bitmap_arr[i] = new Bitmap(filenames_arr[i]);

                Bitmap test;
                bitmap_arr[0] = pic_cut(bitmap_arr[0], bitmap_arr[0].Width, 0, down);  //第一张图片从最顶端截取至字幕下方
                for (int i = 1; i < num - 1; i++)   //中间图片只截取字幕
                {
                    bitmap_arr[i] = pic_cut(bitmap_arr[i], bitmap_arr[i].Width, up, down);
                }
                bitmap_arr[num - 1] = pic_cut(bitmap_arr[num - 1], bitmap_arr[num - 1].Width, up, bitmap_arr[num - 1].Height);  //最后一张图片从字母上方截取至最下方

                test = bitmap_arr[0];
                for (int i = 1; i < num; i++)
                {
                    test = pic_add(test, bitmap_arr[i]);
                }

                Image img = Image.FromHbitmap(test.GetHbitmap());
                this.pictureBox1.Image = img;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (num != 0)
            {
                SaveFileDialog saveImageDialog = new SaveFileDialog();
                saveImageDialog.Title = "图片保存";
                saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp";
                if (saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveImageDialog.FileName.ToString();
                    if (fileName != "" && fileName != null)
                    {
                        string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();
                        System.Drawing.Imaging.ImageFormat imgformat = null;

                        if (fileExtName != "")
                        {
                            switch (fileExtName)
                            {
                                case "jpg":
                                    imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                    break;
                                case "bmp":
                                    imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                    break;
                                default:
                                    imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                    break;
                            }

                            try
                            {
                                Bitmap bit = new Bitmap(pictureBox1.Image);
                                MessageBox.Show(fileName);
                                pictureBox1.Image.Save(fileName, imgformat);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            id.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            id.Visible = false;
        }
    }

}

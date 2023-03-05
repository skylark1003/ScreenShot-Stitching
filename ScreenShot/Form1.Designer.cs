namespace ScreenShot
{
    partial class ScreenShot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShot));
            this.pic_path = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.add_pic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.select_pic = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_path
            // 
            this.pic_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.pic_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pic_path.Font = new System.Drawing.Font("Lucida Console", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic_path.ForeColor = System.Drawing.Color.White;
            this.pic_path.Location = new System.Drawing.Point(77, 142);
            this.pic_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_path.Multiline = true;
            this.pic_path.Name = "pic_path";
            this.pic_path.ReadOnly = true;
            this.pic_path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pic_path.Size = new System.Drawing.Size(380, 228);
            this.pic_path.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(77, 414);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(380, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(77, 476);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(380, 56);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("I.Ngaan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(785, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Maximum: 30 pics";
            // 
            // add_pic
            // 
            this.add_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_pic.BackgroundImage = global::ScreenShot.Properties.Resources.add;
            this.add_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_pic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_pic.FlatAppearance.BorderSize = 0;
            this.add_pic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_pic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_pic.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_pic.ForeColor = System.Drawing.Color.White;
            this.add_pic.Location = new System.Drawing.Point(407, 49);
            this.add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_pic.Name = "add_pic";
            this.add_pic.Size = new System.Drawing.Size(51, 50);
            this.add_pic.TabIndex = 10;
            this.add_pic.UseVisualStyleBackColor = false;
            this.add_pic.Click += new System.EventHandler(this.add_pic_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(973, 558);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.Transparent;
            this.preview.BackgroundImage = global::ScreenShot.Properties.Resources.re;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.preview.FlatAppearance.BorderSize = 0;
            this.preview.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preview.ForeColor = System.Drawing.Color.White;
            this.preview.Location = new System.Drawing.Point(525, 44);
            this.preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(251, 50);
            this.preview.TabIndex = 5;
            this.preview.UseVisualStyleBackColor = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = global::ScreenShot.Properties.Resources.save;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("华文新魏", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(277, 538);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 50);
            this.save.TabIndex = 4;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // select_pic
            // 
            this.select_pic.BackColor = System.Drawing.Color.Transparent;
            this.select_pic.BackgroundImage = global::ScreenShot.Properties.Resources.sel;
            this.select_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_pic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.select_pic.FlatAppearance.BorderSize = 0;
            this.select_pic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.select_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.select_pic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.select_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_pic.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_pic.ForeColor = System.Drawing.Color.White;
            this.select_pic.Location = new System.Drawing.Point(77, 49);
            this.select_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_pic.Name = "select_pic";
            this.select_pic.Size = new System.Drawing.Size(180, 50);
            this.select_pic.TabIndex = 0;
            this.select_pic.UseVisualStyleBackColor = false;
            this.select_pic.Click += new System.EventHandler(this.select_pic_Click);
            // 
            // id
            // 
            this.id.BackgroundImage = global::ScreenShot.Properties.Resources.tips;
            this.id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.id.Location = new System.Drawing.Point(569, 158);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(400, 375);
            this.id.TabIndex = 9;
            this.id.TabStop = false;
            this.id.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(525, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ScreenShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1083, 632);
            this.Controls.Add(this.add_pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.save);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pic_path);
            this.Controls.Add(this.select_pic);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ScreenShot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot Stitching";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenShot_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_pic;
        private System.Windows.Forms.TextBox pic_path;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox id;
        private System.Windows.Forms.Button add_pic;
    }
}


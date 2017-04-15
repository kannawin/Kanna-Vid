namespace Kanna_Movies
{
    partial class Kanna_Vod
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
            this.poster = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.movList = new System.Windows.Forms.ListBox();
            this.watch = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.len = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.voldown = new System.Windows.Forms.Button();
            this.skip10mfor = new System.Windows.Forms.Button();
            this.skip10back = new System.Windows.Forms.Button();
            this.volup = new System.Windows.Forms.Button();
            this.skip30back = new System.Windows.Forms.Button();
            this.skip30for = new System.Windows.Forms.Button();
            this.fastfow = new System.Windows.Forms.Button();
            this.rewind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullScreen = new System.Windows.Forms.Button();
            this.tvoff = new System.Windows.Forms.Button();
            this.tvon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // poster
            // 
            this.poster.Location = new System.Drawing.Point(204, 272);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(644, 896);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster.TabIndex = 0;
            this.poster.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(214, 95);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(178, 64);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // movList
            // 
            this.movList.BackColor = System.Drawing.Color.Black;
            this.movList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.movList.ForeColor = System.Drawing.Color.White;
            this.movList.FormattingEnabled = true;
            this.movList.ItemHeight = 36;
            this.movList.Location = new System.Drawing.Point(2062, 74);
            this.movList.Name = "movList";
            this.movList.Size = new System.Drawing.Size(652, 1696);
            this.movList.TabIndex = 3;
            this.movList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // watch
            // 
            this.watch.CausesValidation = false;
            this.watch.ForeColor = System.Drawing.Color.White;
            this.watch.Location = new System.Drawing.Point(1690, 895);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(328, 127);
            this.watch.TabIndex = 5;
            this.watch.Text = "Watch";
            this.watch.UseVisualStyleBackColor = true;
            this.watch.Click += new System.EventHandler(this.button1_Click);
            // 
            // play
            // 
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(1050, 762);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(138, 260);
            this.play.TabIndex = 6;
            this.play.Text = "Pause/Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button2_Click);
            // 
            // stop
            // 
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.Location = new System.Drawing.Point(1690, 1026);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(328, 127);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.11155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8884501F));
            this.tableLayoutPanel1.Controls.Add(this.description, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rating, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(885, 272);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.25469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.74531F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 373);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description.Location = new System.Drawing.Point(3, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(93, 32);
            this.description.TabIndex = 0;
            this.description.Text = "label2";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rating.Location = new System.Drawing.Point(3, 318);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(93, 32);
            this.rating.TabIndex = 9;
            this.rating.Text = "label3";
            // 
            // len
            // 
            this.len.AutoSize = true;
            this.len.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.len.Location = new System.Drawing.Point(3, 0);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(93, 32);
            this.len.TabIndex = 9;
            this.len.Text = "label4";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.len, 0, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(885, 641);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.74359F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25641F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1133, 52);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // voldown
            // 
            this.voldown.ForeColor = System.Drawing.Color.White;
            this.voldown.Location = new System.Drawing.Point(1357, 895);
            this.voldown.Name = "voldown";
            this.voldown.Size = new System.Drawing.Size(133, 127);
            this.voldown.TabIndex = 11;
            this.voldown.Text = "Vol -";
            this.voldown.UseVisualStyleBackColor = true;
            this.voldown.Click += new System.EventHandler(this.button4_Click);
            // 
            // skip10mfor
            // 
            this.skip10mfor.ForeColor = System.Drawing.Color.White;
            this.skip10mfor.Location = new System.Drawing.Point(1194, 944);
            this.skip10mfor.Name = "skip10mfor";
            this.skip10mfor.Size = new System.Drawing.Size(156, 78);
            this.skip10mfor.TabIndex = 12;
            this.skip10mfor.Text = "Skip 10m >>>";
            this.skip10mfor.UseVisualStyleBackColor = true;
            this.skip10mfor.Click += new System.EventHandler(this.button5_Click);
            // 
            // skip10back
            // 
            this.skip10back.ForeColor = System.Drawing.Color.White;
            this.skip10back.Location = new System.Drawing.Point(888, 944);
            this.skip10back.Name = "skip10back";
            this.skip10back.Size = new System.Drawing.Size(156, 78);
            this.skip10back.TabIndex = 13;
            this.skip10back.Text = "<<< Skip 10m";
            this.skip10back.UseVisualStyleBackColor = true;
            this.skip10back.Click += new System.EventHandler(this.button6_Click);
            // 
            // volup
            // 
            this.volup.ForeColor = System.Drawing.Color.White;
            this.volup.Location = new System.Drawing.Point(1357, 762);
            this.volup.Name = "volup";
            this.volup.Size = new System.Drawing.Size(133, 127);
            this.volup.TabIndex = 14;
            this.volup.Text = "Vol +";
            this.volup.UseVisualStyleBackColor = true;
            this.volup.Click += new System.EventHandler(this.button7_Click);
            // 
            // skip30back
            // 
            this.skip30back.ForeColor = System.Drawing.Color.White;
            this.skip30back.Location = new System.Drawing.Point(888, 846);
            this.skip30back.Name = "skip30back";
            this.skip30back.Size = new System.Drawing.Size(156, 92);
            this.skip30back.TabIndex = 15;
            this.skip30back.Text = "< Skip 30s";
            this.skip30back.UseVisualStyleBackColor = true;
            this.skip30back.Click += new System.EventHandler(this.button8_Click);
            // 
            // skip30for
            // 
            this.skip30for.ForeColor = System.Drawing.Color.White;
            this.skip30for.Location = new System.Drawing.Point(1194, 846);
            this.skip30for.Name = "skip30for";
            this.skip30for.Size = new System.Drawing.Size(156, 92);
            this.skip30for.TabIndex = 16;
            this.skip30for.Text = "Skip 30s >";
            this.skip30for.UseVisualStyleBackColor = true;
            this.skip30for.Click += new System.EventHandler(this.button9_Click);
            // 
            // fastfow
            // 
            this.fastfow.ForeColor = System.Drawing.Color.White;
            this.fastfow.Location = new System.Drawing.Point(1194, 762);
            this.fastfow.Name = "fastfow";
            this.fastfow.Size = new System.Drawing.Size(157, 78);
            this.fastfow.TabIndex = 17;
            this.fastfow.Text = "Fast Forward";
            this.fastfow.UseVisualStyleBackColor = true;
            this.fastfow.Click += new System.EventHandler(this.button10_Click);
            // 
            // rewind
            // 
            this.rewind.ForeColor = System.Drawing.Color.White;
            this.rewind.Location = new System.Drawing.Point(888, 762);
            this.rewind.Name = "rewind";
            this.rewind.Size = new System.Drawing.Size(156, 78);
            this.rewind.TabIndex = 18;
            this.rewind.Text = "Rewind";
            this.rewind.UseVisualStyleBackColor = true;
            this.rewind.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Year";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1802, 829);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 60);
            this.button2.TabIndex = 21;
            this.button2.Text = "Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1802, 762);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 61);
            this.button3.TabIndex = 22;
            this.button3.Text = "Year";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1684, 762);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sort by:";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(888, 1028);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(602, 125);
            this.button4.TabIndex = 25;
            this.button4.Text = "Random Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(204, 1236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(678, 1236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 427);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1164, 1236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(391, 427);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(198, 1675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(198, 1725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(671, 1675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 38);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(671, 1725);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1158, 1675);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 38);
            this.label8.TabIndex = 34;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1158, 1725);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 32);
            this.label9.TabIndex = 35;
            this.label9.Text = "label9";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1628, 1236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(390, 427);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1621, 1675);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 38);
            this.label10.TabIndex = 37;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1622, 1725);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 32);
            this.label11.TabIndex = 38;
            this.label11.Text = "label11";
            // 
            // fullScreen
            // 
            this.fullScreen.ForeColor = System.Drawing.Color.White;
            this.fullScreen.Location = new System.Drawing.Point(216, 0);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(248, 71);
            this.fullScreen.TabIndex = 39;
            this.fullScreen.Text = "Exit Full Screen";
            this.fullScreen.UseVisualStyleBackColor = true;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click_1);
            // 
            // tvoff
            // 
            this.tvoff.Enabled = false;
            this.tvoff.ForeColor = System.Drawing.Color.White;
            this.tvoff.Location = new System.Drawing.Point(799, 0);
            this.tvoff.Name = "tvoff";
            this.tvoff.Size = new System.Drawing.Size(323, 71);
            this.tvoff.TabIndex = 40;
            this.tvoff.Text = "TV Off";
            this.tvoff.UseVisualStyleBackColor = true;
            this.tvoff.Click += new System.EventHandler(this.tvoff_Click);
            // 
            // tvon
            // 
            this.tvon.ForeColor = System.Drawing.Color.White;
            this.tvon.Location = new System.Drawing.Point(470, 0);
            this.tvon.Name = "tvon";
            this.tvon.Size = new System.Drawing.Size(323, 71);
            this.tvon.TabIndex = 41;
            this.tvon.Text = "TV On";
            this.tvon.UseVisualStyleBackColor = true;
            this.tvon.Click += new System.EventHandler(this.tvon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(199, 1187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 32);
            this.label12.TabIndex = 42;
            this.label12.Text = "Starring:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(219, 1251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // Kanna_Vod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2726, 1774);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tvon);
            this.Controls.Add(this.tvoff);
            this.Controls.Add(this.fullScreen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rewind);
            this.Controls.Add(this.fastfow);
            this.Controls.Add(this.skip30for);
            this.Controls.Add(this.skip30back);
            this.Controls.Add(this.volup);
            this.Controls.Add(this.skip10back);
            this.Controls.Add(this.skip10mfor);
            this.Controls.Add(this.voldown);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.movList);
            this.Controls.Add(this.title);
            this.Controls.Add(this.poster);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Kanna_Vod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kanna-vid";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox movList;
        private System.Windows.Forms.Button watch;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label len;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button voldown;
        private System.Windows.Forms.Button skip10mfor;
        private System.Windows.Forms.Button skip10back;
        private System.Windows.Forms.Button volup;
        private System.Windows.Forms.Button skip30back;
        private System.Windows.Forms.Button skip30for;
        private System.Windows.Forms.Button fastfow;
        private System.Windows.Forms.Button rewind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button fullScreen;
        private System.Windows.Forms.Button tvoff;
        private System.Windows.Forms.Button tvon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
    }
}


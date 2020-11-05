namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IMG1 = new Emgu.CV.UI.ImageBox();
            this.IMG2 = new Emgu.CV.UI.ImageBox();
            this.load = new System.Windows.Forms.Button();
            this.blurb = new System.Windows.Forms.Button();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.trb2 = new System.Windows.Forms.TrackBar();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.findbutton = new System.Windows.Forms.Button();
            this.trb3 = new System.Windows.Forms.TrackBar();
            this.lb3 = new System.Windows.Forms.Label();
            this.finderbutton = new System.Windows.Forms.Button();
            this.trb4 = new System.Windows.Forms.TrackBar();
            this.lb4 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.trb5 = new System.Windows.Forms.TrackBar();
            this.lb5 = new System.Windows.Forms.Label();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.circle3 = new System.Windows.Forms.TrackBar();
            this.circle1 = new System.Windows.Forms.TrackBar();
            this.circle2 = new System.Windows.Forms.TrackBar();
            this.circle4 = new System.Windows.Forms.TrackBar();
            this.cb1 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.Label();
            this.cb4 = new System.Windows.Forms.Label();
            this.colorb = new System.Windows.Forms.Button();
            this.colortrb1 = new System.Windows.Forms.TrackBar();
            this.colortrb2 = new System.Windows.Forms.TrackBar();
            this.clb2 = new System.Windows.Forms.Label();
            this.clb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colortrb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colortrb2)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG1
            // 
            this.IMG1.Location = new System.Drawing.Point(12, 12);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(640, 480);
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            // 
            // IMG2
            // 
            this.IMG2.Location = new System.Drawing.Point(821, 12);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(640, 480);
            this.IMG2.TabIndex = 3;
            this.IMG2.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(658, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(157, 23);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // blurb
            // 
            this.blurb.Location = new System.Drawing.Point(658, 41);
            this.blurb.Name = "blurb";
            this.blurb.Size = new System.Drawing.Size(157, 23);
            this.blurb.TabIndex = 5;
            this.blurb.Text = "Find ROI";
            this.blurb.UseVisualStyleBackColor = true;
            this.blurb.Click += new System.EventHandler(this.blurb_Click);
            // 
            // trb1
            // 
            this.trb1.LargeChange = 2;
            this.trb1.Location = new System.Drawing.Point(658, 70);
            this.trb1.Maximum = 2;
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(157, 45);
            this.trb1.TabIndex = 6;
            this.trb1.Value = 2;
            this.trb1.ValueChanged += new System.EventHandler(this.trb1_ValueChanged);
            // 
            // trb2
            // 
            this.trb2.LargeChange = 20;
            this.trb2.Location = new System.Drawing.Point(658, 121);
            this.trb2.Maximum = 200;
            this.trb2.Name = "trb2";
            this.trb2.Size = new System.Drawing.Size(157, 45);
            this.trb2.SmallChange = 5;
            this.trb2.TabIndex = 7;
            this.trb2.Value = 80;
            this.trb2.ValueChanged += new System.EventHandler(this.trb2_ValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(802, 102);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "5";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(796, 153);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(19, 13);
            this.lb2.TabIndex = 9;
            this.lb2.Text = "80";
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(658, 172);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(157, 23);
            this.findbutton.TabIndex = 10;
            this.findbutton.Text = "Find edges";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // trb3
            // 
            this.trb3.LargeChange = 2;
            this.trb3.Location = new System.Drawing.Point(658, 201);
            this.trb3.Maximum = 5;
            this.trb3.Minimum = 1;
            this.trb3.Name = "trb3";
            this.trb3.Size = new System.Drawing.Size(157, 45);
            this.trb3.TabIndex = 11;
            this.trb3.Value = 3;
            this.trb3.ValueChanged += new System.EventHandler(this.trb3_ValueChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(796, 233);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(13, 13);
            this.lb3.TabIndex = 12;
            this.lb3.Text = "3";
            // 
            // finderbutton
            // 
            this.finderbutton.Location = new System.Drawing.Point(658, 249);
            this.finderbutton.Name = "finderbutton";
            this.finderbutton.Size = new System.Drawing.Size(157, 23);
            this.finderbutton.TabIndex = 13;
            this.finderbutton.Text = "Find primitives";
            this.finderbutton.UseVisualStyleBackColor = true;
            this.finderbutton.Click += new System.EventHandler(this.finderbutton_Click);
            // 
            // trb4
            // 
            this.trb4.LargeChange = 20;
            this.trb4.Location = new System.Drawing.Point(658, 289);
            this.trb4.Maximum = 100;
            this.trb4.Name = "trb4";
            this.trb4.Size = new System.Drawing.Size(157, 45);
            this.trb4.SmallChange = 5;
            this.trb4.TabIndex = 14;
            this.trb4.Value = 10;
            this.trb4.ValueChanged += new System.EventHandler(this.trb4_ValueChanged);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(784, 321);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(25, 13);
            this.lb4.TabIndex = 100;
            this.lb4.Text = "100";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(658, 388);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(63, 17);
            this.rb1.TabIndex = 101;
            this.rb1.TabStop = true;
            this.rb1.Text = "Triangle";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(658, 411);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(74, 17);
            this.rb2.TabIndex = 102;
            this.rb2.Text = "Rectangle";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // trb5
            // 
            this.trb5.LargeChange = 20;
            this.trb5.Location = new System.Drawing.Point(658, 337);
            this.trb5.Maximum = 20;
            this.trb5.Name = "trb5";
            this.trb5.Size = new System.Drawing.Size(157, 45);
            this.trb5.SmallChange = 5;
            this.trb5.TabIndex = 103;
            this.trb5.Value = 10;
            this.trb5.ValueChanged += new System.EventHandler(this.trb5_ValueChanged);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(784, 369);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(19, 13);
            this.lb5.TabIndex = 104;
            this.lb5.Text = "10";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(658, 434);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(51, 17);
            this.rb3.TabIndex = 105;
            this.rb3.Text = "Circle";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // circle3
            // 
            this.circle3.LargeChange = 20;
            this.circle3.Location = new System.Drawing.Point(1183, 498);
            this.circle3.Maximum = 100;
            this.circle3.Minimum = 1;
            this.circle3.Name = "circle3";
            this.circle3.Size = new System.Drawing.Size(157, 45);
            this.circle3.SmallChange = 5;
            this.circle3.TabIndex = 106;
            this.circle3.Value = 2;
            this.circle3.ValueChanged += new System.EventHandler(this.circle3_ValueChanged);
            // 
            // circle1
            // 
            this.circle1.LargeChange = 20;
            this.circle1.Location = new System.Drawing.Point(1010, 498);
            this.circle1.Maximum = 15;
            this.circle1.Minimum = 1;
            this.circle1.Name = "circle1";
            this.circle1.Size = new System.Drawing.Size(157, 45);
            this.circle1.SmallChange = 5;
            this.circle1.TabIndex = 107;
            this.circle1.Value = 2;
            this.circle1.ValueChanged += new System.EventHandler(this.circle1_ValueChanged);
            // 
            // circle2
            // 
            this.circle2.LargeChange = 20;
            this.circle2.Location = new System.Drawing.Point(1010, 549);
            this.circle2.Maximum = 100;
            this.circle2.Minimum = 1;
            this.circle2.Name = "circle2";
            this.circle2.Size = new System.Drawing.Size(157, 45);
            this.circle2.SmallChange = 5;
            this.circle2.TabIndex = 108;
            this.circle2.Value = 10;
            this.circle2.ValueChanged += new System.EventHandler(this.circle2_ValueChanged);
            // 
            // circle4
            // 
            this.circle4.LargeChange = 20;
            this.circle4.Location = new System.Drawing.Point(1183, 549);
            this.circle4.Maximum = 100;
            this.circle4.Minimum = 1;
            this.circle4.Name = "circle4";
            this.circle4.Size = new System.Drawing.Size(157, 45);
            this.circle4.SmallChange = 5;
            this.circle4.TabIndex = 109;
            this.circle4.Value = 100;
            this.circle4.ValueChanged += new System.EventHandler(this.circle4_ValueChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(1148, 530);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(19, 13);
            this.cb1.TabIndex = 110;
            this.cb1.Text = "20";
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(1148, 581);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(19, 13);
            this.cb2.TabIndex = 111;
            this.cb2.Text = "10";
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(1321, 530);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(13, 13);
            this.cb3.TabIndex = 112;
            this.cb3.Text = "2";
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(1309, 581);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(31, 13);
            this.cb4.TabIndex = 113;
            this.cb4.Text = "1000";
            // 
            // colorb
            // 
            this.colorb.Location = new System.Drawing.Point(658, 469);
            this.colorb.Name = "colorb";
            this.colorb.Size = new System.Drawing.Size(157, 23);
            this.colorb.TabIndex = 114;
            this.colorb.Text = "Color filter";
            this.colorb.UseVisualStyleBackColor = true;
            this.colorb.Click += new System.EventHandler(this.colorb_Click);
            // 
            // colortrb1
            // 
            this.colortrb1.LargeChange = 20;
            this.colortrb1.Location = new System.Drawing.Point(658, 498);
            this.colortrb1.Maximum = 255;
            this.colortrb1.Name = "colortrb1";
            this.colortrb1.Size = new System.Drawing.Size(157, 45);
            this.colortrb1.SmallChange = 5;
            this.colortrb1.TabIndex = 115;
            this.colortrb1.Value = 30;
            this.colortrb1.ValueChanged += new System.EventHandler(this.colortrb1_ValueChanged);
            // 
            // colortrb2
            // 
            this.colortrb2.LargeChange = 20;
            this.colortrb2.Location = new System.Drawing.Point(658, 540);
            this.colortrb2.Maximum = 20;
            this.colortrb2.Name = "colortrb2";
            this.colortrb2.Size = new System.Drawing.Size(157, 45);
            this.colortrb2.SmallChange = 5;
            this.colortrb2.TabIndex = 116;
            this.colortrb2.Value = 10;
            this.colortrb2.ValueChanged += new System.EventHandler(this.colortrb2_ValueChanged);
            // 
            // clb2
            // 
            this.clb2.AutoSize = true;
            this.clb2.Location = new System.Drawing.Point(790, 572);
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(19, 13);
            this.clb2.TabIndex = 117;
            this.clb2.Text = "10";
            // 
            // clb1
            // 
            this.clb1.AutoSize = true;
            this.clb1.Location = new System.Drawing.Point(790, 530);
            this.clb1.Name = "clb1";
            this.clb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clb1.Size = new System.Drawing.Size(19, 13);
            this.clb1.TabIndex = 118;
            this.clb1.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 623);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.clb2);
            this.Controls.Add(this.colortrb2);
            this.Controls.Add(this.colortrb1);
            this.Controls.Add(this.colorb);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.circle4);
            this.Controls.Add(this.circle2);
            this.Controls.Add(this.circle1);
            this.Controls.Add(this.circle3);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.trb5);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.trb4);
            this.Controls.Add(this.finderbutton);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.trb3);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.trb2);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.blurb);
            this.Controls.Add(this.load);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colortrb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colortrb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IMG1;
        private Emgu.CV.UI.ImageBox IMG2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button blurb;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.TrackBar trb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TrackBar trb3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button finderbutton;
        private System.Windows.Forms.TrackBar trb4;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TrackBar trb5;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.TrackBar circle3;
        private System.Windows.Forms.TrackBar circle1;
        private System.Windows.Forms.TrackBar circle2;
        private System.Windows.Forms.TrackBar circle4;
        private System.Windows.Forms.Label cb1;
        private System.Windows.Forms.Label cb2;
        private System.Windows.Forms.Label cb3;
        private System.Windows.Forms.Label cb4;
        private System.Windows.Forms.Button colorb;
        private System.Windows.Forms.TrackBar colortrb1;
        private System.Windows.Forms.TrackBar colortrb2;
        private System.Windows.Forms.Label clb2;
        private System.Windows.Forms.Label clb1;
    }
}


namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pbox_115 = new PictureBox();
            pbox_90 = new PictureBox();
            pbox_120 = new PictureBox();
            pbox_80 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_show = new Label();
            label7 = new Label();
            btn_rest = new Button();
            btn_click = new Button();
            ((System.ComponentModel.ISupportInitialize)pbox_115).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_90).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_120).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_80).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(324, 279);
            label1.TabIndex = 1;
            // 
            // pbox_115
            // 
            pbox_115.Image = Properties.Resources.Banana;
            pbox_115.Location = new Point(65, 54);
            pbox_115.Name = "pbox_115";
            pbox_115.Size = new Size(107, 106);
            pbox_115.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_115.TabIndex = 2;
            pbox_115.TabStop = false;
            pbox_115.Click += pbox_115_Click;
            // 
            // pbox_90
            // 
            pbox_90.Image = Properties.Resources.Orange;
            pbox_90.Location = new Point(65, 188);
            pbox_90.Name = "pbox_90";
            pbox_90.Size = new Size(107, 106);
            pbox_90.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_90.TabIndex = 3;
            pbox_90.TabStop = false;
            pbox_90.Click += pbox_90_Click;
            // 
            // pbox_120
            // 
            pbox_120.Image = Properties.Resources.Pear;
            pbox_120.Location = new Point(228, 188);
            pbox_120.Name = "pbox_120";
            pbox_120.Size = new Size(107, 106);
            pbox_120.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_120.TabIndex = 4;
            pbox_120.TabStop = false;
            pbox_120.Click += pbox_120_Click;
            // 
            // pbox_80
            // 
            pbox_80.Image = Properties.Resources.Apple;
            pbox_80.Location = new Point(228, 54);
            pbox_80.Name = "pbox_80";
            pbox_80.Size = new Size(107, 106);
            pbox_80.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_80.TabIndex = 5;
            pbox_80.TabStop = false;
            pbox_80.Click += pbox_80_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(65, 163);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 6;
            label2.Text = "115 Calories";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(228, 163);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 7;
            label3.Text = "80 Calories";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(228, 297);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 8;
            label4.Text = "120 Calories";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(65, 297);
            label5.Name = "label5";
            label5.Size = new Size(107, 22);
            label5.TabIndex = 9;
            label5.Text = "90 Calories";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_show
            // 
            lbl_show.BorderStyle = BorderStyle.FixedSingle;
            lbl_show.Location = new Point(404, 74);
            lbl_show.Name = "lbl_show";
            lbl_show.Size = new Size(91, 24);
            lbl_show.TabIndex = 10;
            lbl_show.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label7.Location = new Point(383, 43);
            label7.Name = "label7";
            label7.Size = new Size(139, 31);
            label7.TabIndex = 11;
            label7.Text = "Total Calories";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_rest
            // 
            btn_rest.Location = new Point(404, 238);
            btn_rest.Name = "btn_rest";
            btn_rest.Size = new Size(91, 25);
            btn_rest.TabIndex = 12;
            btn_rest.Text = "Reset";
            btn_rest.UseVisualStyleBackColor = true;
            btn_rest.Click += btn_rest_Click;
            // 
            // btn_click
            // 
            btn_click.Location = new Point(404, 269);
            btn_click.Name = "btn_click";
            btn_click.Size = new Size(91, 25);
            btn_click.TabIndex = 13;
            btn_click.Text = "Exist";
            btn_click.UseVisualStyleBackColor = true;
            btn_click.Click += btn_click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 355);
            Controls.Add(btn_click);
            Controls.Add(btn_rest);
            Controls.Add(label7);
            Controls.Add(lbl_show);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbox_80);
            Controls.Add(pbox_120);
            Controls.Add(pbox_90);
            Controls.Add(pbox_115);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbox_115).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_90).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_120).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_80).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pbox_115;
        private PictureBox pbox_90;
        private PictureBox pbox_120;
        private PictureBox pbox_80;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_show;
        private Label label7;
        private Button btn_rest;
        private Button btn_click;
    }
}

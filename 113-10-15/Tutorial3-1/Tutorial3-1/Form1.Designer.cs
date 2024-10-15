namespace Tutorial3_1
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
            lbl_week = new Label();
            lbl_date = new Label();
            lbl_month = new Label();
            lbl_year = new Label();
            input_week = new TextBox();
            input_date = new TextBox();
            input_month = new TextBox();
            input_year = new TextBox();
            lbl_show = new Label();
            btn_date = new Button();
            btn_clear = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_week
            // 
            lbl_week.AutoSize = true;
            lbl_week.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_week.Location = new Point(89, 84);
            lbl_week.Name = "lbl_week";
            lbl_week.Size = new Size(114, 41);
            lbl_week.TabIndex = 0;
            lbl_week.Text = "星期幾";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_date.Location = new Point(89, 160);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(82, 41);
            lbl_date.TabIndex = 1;
            lbl_date.Text = "日期";
            // 
            // lbl_month
            // 
            lbl_month.AutoSize = true;
            lbl_month.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_month.Location = new Point(89, 239);
            lbl_month.Name = "lbl_month";
            lbl_month.Size = new Size(82, 41);
            lbl_month.TabIndex = 2;
            lbl_month.Text = "月分";
            // 
            // lbl_year
            // 
            lbl_year.AutoSize = true;
            lbl_year.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_year.Location = new Point(89, 307);
            lbl_year.Name = "lbl_year";
            lbl_year.Size = new Size(82, 41);
            lbl_year.TabIndex = 3;
            lbl_year.Text = "年分";
            // 
            // input_week
            // 
            input_week.Font = new Font("Microsoft JhengHei UI", 24F);
            input_week.Location = new Point(224, 77);
            input_week.Name = "input_week";
            input_week.Size = new Size(329, 48);
            input_week.TabIndex = 4;
            // 
            // input_date
            // 
            input_date.Font = new Font("Microsoft JhengHei UI", 24F);
            input_date.Location = new Point(224, 157);
            input_date.Name = "input_date";
            input_date.Size = new Size(329, 48);
            input_date.TabIndex = 5;
            // 
            // input_month
            // 
            input_month.Font = new Font("Microsoft JhengHei UI", 24F);
            input_month.Location = new Point(224, 236);
            input_month.Name = "input_month";
            input_month.Size = new Size(329, 48);
            input_month.TabIndex = 6;
            // 
            // input_year
            // 
            input_year.Font = new Font("Microsoft JhengHei UI", 24F);
            input_year.Location = new Point(224, 304);
            input_year.Name = "input_year";
            input_year.Size = new Size(329, 48);
            input_year.TabIndex = 7;
            // 
            // lbl_show
            // 
            lbl_show.BorderStyle = BorderStyle.Fixed3D;
            lbl_show.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_show.Location = new Point(89, 381);
            lbl_show.Name = "lbl_show";
            lbl_show.Size = new Size(464, 77);
            lbl_show.TabIndex = 8;
            // 
            // btn_date
            // 
            btn_date.Location = new Point(89, 487);
            btn_date.Name = "btn_date";
            btn_date.Size = new Size(99, 48);
            btn_date.TabIndex = 9;
            btn_date.Text = "顯示完整日期";
            btn_date.UseVisualStyleBackColor = true;
            btn_date.Click += btn_date_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(273, 487);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(99, 48);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "清空內容";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(454, 487);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(99, 48);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "離開";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 605);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(btn_date);
            Controls.Add(lbl_show);
            Controls.Add(input_year);
            Controls.Add(input_month);
            Controls.Add(input_date);
            Controls.Add(input_week);
            Controls.Add(lbl_year);
            Controls.Add(lbl_month);
            Controls.Add(lbl_date);
            Controls.Add(lbl_week);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_week;
        private Label lbl_date;
        private Label lbl_month;
        private Label lbl_year;
        private TextBox input_week;
        private TextBox input_date;
        private TextBox input_month;
        private TextBox input_year;
        private Label lbl_show;
        private Button btn_date;
        private Button btn_clear;
        private Button btn_exit;
    }
}

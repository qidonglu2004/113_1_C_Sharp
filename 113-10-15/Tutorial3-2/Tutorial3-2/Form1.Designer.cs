namespace Tutorial3_2
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
            lbl_oils = new Label();
            lbl_km = new Label();
            lbl_result = new Label();
            input_km = new TextBox();
            input_oils = new TextBox();
            lbl_show = new Label();
            btn_cal = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_oils
            // 
            lbl_oils.AutoSize = true;
            lbl_oils.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_oils.Location = new Point(114, 132);
            lbl_oils.Name = "lbl_oils";
            lbl_oils.Size = new Size(146, 41);
            lbl_oils.TabIndex = 0;
            lbl_oils.Text = "使用油耗";
            // 
            // lbl_km
            // 
            lbl_km.AutoSize = true;
            lbl_km.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_km.Location = new Point(114, 55);
            lbl_km.Name = "lbl_km";
            lbl_km.Size = new Size(114, 41);
            lbl_km.TabIndex = 0;
            lbl_km.Text = "公里數";
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_result.Location = new Point(114, 227);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(146, 41);
            lbl_result.TabIndex = 1;
            lbl_result.Text = "公里公升";
            // 
            // input_km
            // 
            input_km.Font = new Font("Microsoft JhengHei UI", 24F);
            input_km.Location = new Point(269, 52);
            input_km.Name = "input_km";
            input_km.Size = new Size(251, 48);
            input_km.TabIndex = 2;
            // 
            // input_oils
            // 
            input_oils.Font = new Font("Microsoft JhengHei UI", 24F);
            input_oils.Location = new Point(269, 125);
            input_oils.Name = "input_oils";
            input_oils.Size = new Size(251, 48);
            input_oils.TabIndex = 3;
            // 
            // lbl_show
            // 
            lbl_show.BorderStyle = BorderStyle.Fixed3D;
            lbl_show.Font = new Font("Microsoft JhengHei UI", 24F);
            lbl_show.Location = new Point(269, 227);
            lbl_show.Name = "lbl_show";
            lbl_show.Size = new Size(251, 41);
            lbl_show.TabIndex = 4;
            // 
            // btn_cal
            // 
            btn_cal.Location = new Point(146, 313);
            btn_cal.Name = "btn_cal";
            btn_cal.Size = new Size(148, 63);
            btn_cal.TabIndex = 5;
            btn_cal.Text = "計算";
            btn_cal.UseVisualStyleBackColor = true;
            btn_cal.Click += btn_cal_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(357, 313);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(148, 63);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "離開";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 444);
            Controls.Add(btn_exit);
            Controls.Add(btn_cal);
            Controls.Add(lbl_show);
            Controls.Add(input_oils);
            Controls.Add(input_km);
            Controls.Add(lbl_result);
            Controls.Add(lbl_km);
            Controls.Add(lbl_oils);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_oils;
        private Label lbl_km;
        private Label lbl_result;
        private TextBox input_km;
        private TextBox input_oils;
        private Label lbl_show;
        private Button btn_cal;
        private Button btn_exit;
    }
}

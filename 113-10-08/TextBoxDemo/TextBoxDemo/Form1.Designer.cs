namespace TextBoxDemo
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
            label2 = new Label();
            label3 = new Label();
            btn_confirm = new Button();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            lbl_show = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(76, 57);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(76, 141);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(76, 222);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // btn_confirm
            // 
            btn_confirm.Font = new Font("Microsoft JhengHei UI", 18F);
            btn_confirm.Location = new Point(235, 294);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(165, 63);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new Font("Microsoft JhengHei UI", 24F);
            txt_firstname.Location = new Point(271, 57);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(263, 48);
            txt_firstname.TabIndex = 4;
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new Font("Microsoft JhengHei UI", 24F);
            txt_lastname.Location = new Point(271, 138);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(263, 48);
            txt_lastname.TabIndex = 5;
            // 
            // lbl_show
            // 
            lbl_show.BorderStyle = BorderStyle.Fixed3D;
            lbl_show.Location = new Point(271, 222);
            lbl_show.Name = "lbl_show";
            lbl_show.Size = new Size(263, 49);
            lbl_show.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 390);
            Controls.Add(lbl_show);
            Controls.Add(txt_lastname);
            Controls.Add(txt_firstname);
            Controls.Add(btn_confirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_confirm;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private Label lbl_show;
    }
}

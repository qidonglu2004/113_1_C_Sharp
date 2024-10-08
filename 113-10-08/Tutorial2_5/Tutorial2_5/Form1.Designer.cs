namespace Tutorial2_5
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
            ptx_back = new PictureBox();
            ptx_front = new PictureBox();
            btn_showback = new Button();
            btn_showfront = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptx_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptx_front).BeginInit();
            SuspendLayout();
            // 
            // ptx_back
            // 
            ptx_back.Image = Properties.Resources.Backface_Blue;
            ptx_back.Location = new Point(63, 12);
            ptx_back.Name = "ptx_back";
            ptx_back.Size = new Size(220, 280);
            ptx_back.SizeMode = PictureBoxSizeMode.StretchImage;
            ptx_back.TabIndex = 0;
            ptx_back.TabStop = false;
            ptx_back.Visible = false;
            // 
            // ptx_front
            // 
            ptx_front.Image = Properties.Resources.Ace_Spades;
            ptx_front.Location = new Point(300, 12);
            ptx_front.Name = "ptx_front";
            ptx_front.Size = new Size(220, 280);
            ptx_front.SizeMode = PictureBoxSizeMode.StretchImage;
            ptx_front.TabIndex = 1;
            ptx_front.TabStop = false;
            ptx_front.Visible = false;
            // 
            // btn_showback
            // 
            btn_showback.Location = new Point(117, 300);
            btn_showback.Name = "btn_showback";
            btn_showback.Size = new Size(101, 42);
            btn_showback.TabIndex = 2;
            btn_showback.Text = "背面";
            btn_showback.UseVisualStyleBackColor = true;
            btn_showback.Click += btn_showback_Click;
            // 
            // btn_showfront
            // 
            btn_showfront.Location = new Point(362, 300);
            btn_showfront.Name = "btn_showfront";
            btn_showfront.Size = new Size(101, 44);
            btn_showfront.TabIndex = 3;
            btn_showfront.Text = "正面";
            btn_showfront.UseVisualStyleBackColor = true;
            btn_showfront.Click += btn_showfront_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(117, 369);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(346, 39);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "離開";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 432);
            Controls.Add(btn_exit);
            Controls.Add(btn_showfront);
            Controls.Add(btn_showback);
            Controls.Add(ptx_front);
            Controls.Add(ptx_back);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptx_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptx_front).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptx_back;
        private PictureBox ptx_front;
        private Button btn_showback;
        private Button btn_showfront;
        private Button btn_exit;
    }
}

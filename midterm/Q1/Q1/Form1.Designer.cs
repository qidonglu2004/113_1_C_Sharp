namespace Q1
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
            length = new Label();
            width = new Label();
            unitcost = new Label();
            button1 = new Button();
            show = new Label();
            showarea = new Button();
            showcost = new Button();
            exist = new Button();
            length_input = new TextBox();
            width_input = new TextBox();
            unitcost_input = new TextBox();
            showboundary = new Button();
            showresult = new Label();
            SuspendLayout();
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Microsoft JhengHei UI", 13F);
            length.Location = new Point(50, 66);
            length.Name = "length";
            length.Size = new Size(169, 23);
            length.TabIndex = 0;
            length.Text = "Length of the Field";
            // 
            // width
            // 
            width.AutoSize = true;
            width.Font = new Font("Microsoft JhengHei UI", 13F);
            width.Location = new Point(50, 116);
            width.Name = "width";
            width.Size = new Size(162, 23);
            width.TabIndex = 1;
            width.Text = "Width of the Field";
            // 
            // unitcost
            // 
            unitcost.AutoSize = true;
            unitcost.Font = new Font("Microsoft JhengHei UI", 13F);
            unitcost.Location = new Point(50, 166);
            unitcost.Name = "unitcost";
            unitcost.Size = new Size(182, 23);
            unitcost.TabIndex = 2;
            unitcost.Text = "Unit Cost of Fencing";
            // 
            // button1
            // 
            button1.Location = new Point(178, 209);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Font = new Font("Microsoft JhengHei UI", 13F);
            show.Location = new Point(50, 209);
            show.Name = "show";
            show.Size = new Size(0, 23);
            show.TabIndex = 4;
            // 
            // showarea
            // 
            showarea.Font = new Font("Microsoft JhengHei UI", 13F);
            showarea.Location = new Point(50, 263);
            showarea.Name = "showarea";
            showarea.Size = new Size(107, 39);
            showarea.TabIndex = 5;
            showarea.Text = "Area";
            showarea.UseVisualStyleBackColor = true;
            showarea.Click += showarea_Click;
            // 
            // showcost
            // 
            showcost.Font = new Font("Microsoft JhengHei UI", 13F);
            showcost.Location = new Point(291, 263);
            showcost.Name = "showcost";
            showcost.Size = new Size(107, 39);
            showcost.TabIndex = 7;
            showcost.Text = "Cost";
            showcost.UseVisualStyleBackColor = true;
            showcost.Click += showcost_Click;
            // 
            // exist
            // 
            exist.Font = new Font("Microsoft JhengHei UI", 13F);
            exist.Location = new Point(404, 263);
            exist.Name = "exist";
            exist.Size = new Size(107, 39);
            exist.TabIndex = 8;
            exist.Text = "Exist";
            exist.UseVisualStyleBackColor = true;
            exist.Click += exist_Click;
            // 
            // length_input
            // 
            length_input.Location = new Point(262, 66);
            length_input.Name = "length_input";
            length_input.Size = new Size(136, 23);
            length_input.TabIndex = 9;
            // 
            // width_input
            // 
            width_input.Location = new Point(262, 116);
            width_input.Name = "width_input";
            width_input.Size = new Size(136, 23);
            width_input.TabIndex = 10;
            // 
            // unitcost_input
            // 
            unitcost_input.Location = new Point(262, 166);
            unitcost_input.Name = "unitcost_input";
            unitcost_input.Size = new Size(136, 23);
            unitcost_input.TabIndex = 11;
            // 
            // showboundary
            // 
            showboundary.Font = new Font("Microsoft JhengHei UI", 13F);
            showboundary.Location = new Point(178, 263);
            showboundary.Name = "showboundary";
            showboundary.Size = new Size(107, 39);
            showboundary.TabIndex = 12;
            showboundary.Text = "Boundary";
            showboundary.UseVisualStyleBackColor = true;
            showboundary.Click += showboundary_Click;
            // 
            // showresult
            // 
            showresult.Location = new Point(50, 214);
            showresult.Name = "showresult";
            showresult.Size = new Size(239, 30);
            showresult.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 356);
            Controls.Add(showresult);
            Controls.Add(showboundary);
            Controls.Add(unitcost_input);
            Controls.Add(width_input);
            Controls.Add(length_input);
            Controls.Add(exist);
            Controls.Add(showcost);
            Controls.Add(showarea);
            Controls.Add(show);
            Controls.Add(button1);
            Controls.Add(unitcost);
            Controls.Add(width);
            Controls.Add(length);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label length;
        private Label width;
        private Label unitcost;
        private Button button1;
        private Label show;
        private Button showarea;
        private Button showcost;
        private Button exist;
        private TextBox length_input;
        private TextBox width_input;
        private TextBox unitcost_input;
        private Button showboundary;
        private Label showresult;
    }
}

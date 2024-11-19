namespace Program4_10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_calories = new System.Windows.Forms.TextBox();
            this.input_fatgrams = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Is_LowFat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "The total number of calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "The number of fat grams:";
            // 
            // input_calories
            // 
            this.input_calories.Location = new System.Drawing.Point(161, 12);
            this.input_calories.Name = "input_calories";
            this.input_calories.Size = new System.Drawing.Size(100, 22);
            this.input_calories.TabIndex = 2;
            // 
            // input_fatgrams
            // 
            this.input_fatgrams.Location = new System.Drawing.Point(161, 42);
            this.input_fatgrams.Name = "input_fatgrams";
            this.input_fatgrams.Size = new System.Drawing.Size(100, 22);
            this.input_fatgrams.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 60);
            this.label3.TabIndex = 6;
            // 
            // Is_LowFat
            // 
            this.Is_LowFat.AutoSize = true;
            this.Is_LowFat.Location = new System.Drawing.Point(15, 75);
            this.Is_LowFat.Name = "Is_LowFat";
            this.Is_LowFat.Size = new System.Drawing.Size(237, 16);
            this.Is_LowFat.TabIndex = 7;
            this.Is_LowFat.TabStop = true;
            this.Is_LowFat.Text = "Check if you want to know the food is low fat";
            this.Is_LowFat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 197);
            this.Controls.Add(this.Is_LowFat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_fatgrams);
            this.Controls.Add(this.input_calories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program4_10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_calories;
        private System.Windows.Forms.TextBox input_fatgrams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Is_LowFat;
    }
}


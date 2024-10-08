namespace Tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbl_show.Text = "芬蘭";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbl_show.Text = "法國";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lbl_show.Text = "德國";
        }
    }
}

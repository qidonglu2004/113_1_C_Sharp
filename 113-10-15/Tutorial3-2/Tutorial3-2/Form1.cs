namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(input_km.Text);
            liters = double.Parse(input_oils.Text);
            average = kms / liters;

            lbl_show.Text = average.ToString("n3"); // 小數點後留三位
            //lbl_show.Text = (kms / liters).ToString();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

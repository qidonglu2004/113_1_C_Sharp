namespace Tutorial3_1
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

        private void btn_date_Click(object sender, EventArgs e)
        {
            string output;

            output = "����" + input_year.Text + "�~" + input_month.Text + "��" + input_date.Text + "��" + " �P��" + input_week.Text;

            lbl_show.Text = output;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_week.Text = "";
            input_date.Text = "";
            input_month.Text = "";
            input_year.Text = "";
            lbl_show.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

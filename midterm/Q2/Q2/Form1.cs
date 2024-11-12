namespace Q2
{
    public partial class Form1 : Form
    {
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        Boolean bananaClicked = false;
        Boolean appleClicked = false;
        Boolean orangeClicked = false;
        Boolean pearClicked = false;

        private double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbox_115_Click(object sender, EventArgs e)
        {
            appleClicked = false;
            orangeClicked = false;
            pearClicked = false;

            if (bananaClicked == false) 
            {
                total += BANANA;
                bananaClicked = true;
            }
            else
            {
                total -= BANANA;
            }
            lbl_show.Text = total.ToString();
        }

        private void pbox_80_Click(object sender, EventArgs e)
        {
            bananaClicked = false;
            orangeClicked = false;
            pearClicked = false;

            if (appleClicked == false)
            {
                total += APPLE;
                appleClicked = true;
            }
            else
            {
                total -= APPLE;
            }
            lbl_show.Text = total.ToString();
        }

        private void pbox_90_Click(object sender, EventArgs e)
        {
            bananaClicked = false;
            appleClicked = false;
            pearClicked = false;

            if (orangeClicked == false)
            {
                total += ORANGE;
                orangeClicked = true;
            }
            else
            {
                total -= ORANGE;
            }
            lbl_show.Text = total.ToString();
        }

        private void pbox_120_Click(object sender, EventArgs e)
        {
            bananaClicked = false;
            appleClicked = false;
            orangeClicked = false;

            if (pearClicked == false)
            {
                total += PEAR;
                pearClicked = true;
            }
            else
            {
                total -= PEAR;
            }
            lbl_show.Text = total.ToString();
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            total = 0;
            lbl_show.Text = total.ToString();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

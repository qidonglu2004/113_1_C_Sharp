using System.ComponentModel.DataAnnotations;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void showboundary_Click(object sender, EventArgs e)
        {
            decimal LENGTH;
            decimal WIDTH;
            decimal BOUNDARY;
            try
            {
                LENGTH = decimal.Parse(length_input.Text);
                WIDTH = decimal.Parse(width_input.Text);

                BOUNDARY = 2 * ( LENGTH + WIDTH );
                showresult.Text = "Total Boundary:" + BOUNDARY.ToString();
            }
            catch
            {
                MessageBox.Show("Error, please retry again");
                length_input.Text = "";
                width_input.Text = "";
                unitcost_input.Text = "";
                showresult.Text = "";
            }
        }

        private void showarea_Click(object sender, EventArgs e)
        {
            decimal LENGTH;
            decimal WIDTH;
            decimal AREA;
            try
            {
                LENGTH = decimal.Parse(length_input.Text);
                WIDTH = decimal.Parse(width_input.Text);

                AREA = LENGTH * WIDTH;
                showresult.Text = "Total Area:" + AREA.ToString();
            }
            catch
            {
                MessageBox.Show("Error, please retry again");
                length_input.Text = "";
                width_input.Text = "";
                unitcost_input.Text = "";
                showresult.Text = "";
            }
        }

        private void showcost_Click(object sender, EventArgs e)
        {
            decimal LENGTH;
            decimal WIDTH;
            decimal UNITCOST;
            decimal COST;
            try
            {
                LENGTH = decimal.Parse(length_input.Text);
                WIDTH = decimal.Parse(width_input.Text);
                UNITCOST = decimal.Parse(unitcost_input.Text);

                COST = UNITCOST * 2 * (LENGTH + WIDTH);
                showresult.Text = "Total Cost:" + COST.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error, please retry again");
                length_input.Text = "";
                width_input.Text = "";
                unitcost_input.Text = "";
                showresult.Text = "";
            }

            
        }

        private void exist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

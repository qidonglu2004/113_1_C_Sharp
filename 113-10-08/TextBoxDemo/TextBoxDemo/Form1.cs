namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;

            firstName = txt_firstname.Text;
            lastName = txt_lastname.Text;  
            fullName = lastName + " " + firstName;
            
            lbl_show.Text = fullName;
        }
    }
}

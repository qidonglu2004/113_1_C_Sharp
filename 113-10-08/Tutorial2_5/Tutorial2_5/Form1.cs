/*--------------------------------
�Z��:���G��
�Ǹ�:A111222205
�m�W:�h�ҪF
----------------------------------*/

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�L�I��
        private void btn_showback_Click(object sender, EventArgs e)
        {
            ptx_back.Visible = true; //�]�wvisible�ݩʬ�true
            ptx_back.Visible = false; //�]�wvisible�ݩʬ�false
        }
        //��ܼ��J�L����
        private void btn_showfront_Click(object sender, EventArgs e)
        {
            ptx_back.Visible = false; //�]�wvisible�ݩʬ�false
            ptx_back.Visible = true; //�]�wvisible�ݩʬ�true
        }
        //�����{��
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

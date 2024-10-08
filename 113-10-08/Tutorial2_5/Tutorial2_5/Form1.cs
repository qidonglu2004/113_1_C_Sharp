/*--------------------------------
班級:資科二甲
學號:A111222205
姓名:柳啟東
----------------------------------*/

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克盤背面
        private void btn_showback_Click(object sender, EventArgs e)
        {
            ptx_back.Visible = true; //設定visible屬性為true
            ptx_back.Visible = false; //設定visible屬性為false
        }
        //顯示撲克盤正面
        private void btn_showfront_Click(object sender, EventArgs e)
        {
            ptx_back.Visible = false; //設定visible屬性為false
            ptx_back.Visible = true; //設定visible屬性為true
        }
        //關閉程式
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

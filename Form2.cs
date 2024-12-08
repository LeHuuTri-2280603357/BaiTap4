using System;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class FormNhanVien : Form
    {
        public string MSNV { get; set; }
        public string Ten { get; set; }
        public string LuongCB { get; set; }

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            txt_msnv.Text = MSNV;
            txt_ten.Text = Ten;
            txt_luongcb.Text = LuongCB;
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            MSNV = txt_msnv.Text;
            Ten = txt_ten.Text;
            LuongCB = txt_luongcb.Text;

            if (string.IsNullOrWhiteSpace(MSNV) || string.IsNullOrWhiteSpace(Ten) || string.IsNullOrWhiteSpace(LuongCB))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

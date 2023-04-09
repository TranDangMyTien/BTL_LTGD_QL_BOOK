using System.Xml.Linq;

namespace BTL_QuanLyThuVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        //Thoát chương trình 
        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        //Tạo điều kiện đăng nhập 
        private void bntDN_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show(); //Hiện form main 
            this.Hide(); //Hiện form Main thì ẩn form ĐN 
            if (txtDN.Text != "TDMT" || txtMatKhau.Text != "admin")
                Application.Exit();
        }

        //Tạo biến chạy cho text box
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            lbName.Text = "     ~~ LOGIN AS ADMIN ~~    ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }
    }
}
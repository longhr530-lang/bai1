namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            // Kiểm tra và đọc dữ liệu
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng khách.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là một số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!double.TryParse(txtSoLuong.Text, out double soLuong))
            {
                MessageBox.Show("Số lượng phải là một số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            double giamGia = 0.0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!double.TryParse(txtGiamGia.Text, out giamGia))
                {
                    MessageBox.Show("Mã giảm giá phải là một số (phần trăm).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            if (donGia < 0 || soLuong < 0 || giamGia < 0)
            {
                MessageBox.Show("Các giá trị không được âm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (giamGia > 100)
            {
                MessageBox.Show("% giảm không thể lớn hơn 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }

            double tong = (donGia * soLuong) * (100.0 - giamGia) / 100.0;
            lblTongTien.Text = $"Tổng tiền: {tong:N2}";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtGiamGia.Text = string.Empty;
            lblTongTien.Text = "Tổng tiền: 0.00";
            txtDonGia.Focus();
        }
    }
}

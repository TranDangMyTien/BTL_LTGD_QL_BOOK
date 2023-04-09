namespace BTL_QuanLyThuVien
{
    public partial class FormMain : Form
    {
        int KM;
        int TienLai;

        public FormMain()
        {
            InitializeComponent();
        }

        private void XoaGiaoDien1()
        {
            txtLoaiSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtSoLuong.Text = "";
            txtGiaTien.Text = "";
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoaiSach.Text != "" && txtTenSach.Text != "" && txtTacGia.Text != "" && txtNXB.Text != "" && txtSoLuong.Text != "" && txtGiaTien.Text != "")
            {
                try
                {
                    int soLuong = Convert.ToInt32(txtSoLuong.Text);
                    try
                    {
                        int giaTien = Convert.ToInt32(txtGiaTien.Text);
                        dataGridViewKho.Rows.Add(txtLoaiSach.Text, txtTenSach.Text, txtTacGia.Text, txtNXB.Text, txtSoLuong.Text, txtGiaTien.Text);
                        XoaGiaoDien1();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nhập sai dữ liệu giá tiền!");
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu số lượng!");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewKho.CurrentCell.RowIndex; //Lay vi tri dong hien tai dang click 
            dataGridViewKho[0, vitri].Value = txtLoaiSach.Text;
            dataGridViewKho[1, vitri].Value = txtTenSach.Text;
            dataGridViewKho[2, vitri].Value = txtTacGia.Text;
            dataGridViewKho[3, vitri].Value = txtNXB.Text;
            dataGridViewKho[4, vitri].Value = txtSoLuong.Text;
            dataGridViewKho[5, vitri].Value = txtGiaTien.Text;
            XoaGiaoDien1();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewKho.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có muốn xóa thông tin này?", "Thông bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vitri > dataGridViewKho.SelectedCells.Count + 1)
                    MessageBox.Show("Vị trí chọn xóa không tồn tại !");
                dataGridViewKho.Rows.RemoveAt(vitri);
            }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridViewTimKiem.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[0, i].Value.ToString() == txtLoaiSach1.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value);

                    }
                }
            }
            else if (checkBox2.Checked)
            {
                dataGridViewTimKiem.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[2, i].Value.ToString() == txtTacGia1.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value);

                    }
                }
            }
            else if (checkBox3.Checked)
            {
                dataGridViewTimKiem.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[1, i].Value.ToString() == txtTenSach1.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value);

                    }
                }
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                dataGridViewTimKiem.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (dataGridViewKho[1, i].Value.ToString() == txtTenSach1.Text && dataGridViewKho[2, i].Value.ToString() == txtTacGia1.Text && dataGridViewKho[0, i].Value.ToString() == txtLoaiSach1.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, dataGridViewKho[2, i].Value);

                    }
                }
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (txtTenSach2.Text != "" && txtSoLuong1.Text != "" && txtGiaTien1.Text != "")
            {
                //try
                //{
                int soluong = Convert.ToInt32(txtSoLuong1.Text);
                //try
                //{
                int giatien = Convert.ToInt32(txtGiaTien1.Text);
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    //Điều kiện sách có trong kho 
                    if (dataGridViewKho[1, i].Value.ToString() == txtTenSach2.Text)
                    {
                        //Điều kiện sách số sách trong kho còn 
                        if (Convert.ToInt32(dataGridViewKho[4, i].Value) - Convert.ToInt32(txtSoLuong1.Text) >= 0)
                        {
                            int gia1 = Convert.ToInt32(dataGridViewKho[5, i].Value) / Convert.ToInt32(dataGridViewKho[4, i].Value); //Gia cua tung quyen sach
                            int gia2 = Convert.ToInt32(txtGiaTien1.Text) / Convert.ToInt32(txtSoLuong1.Text);
                            if (checkBox4.Checked)
                            {
                                KM = 1;

                            }
                            else
                            {
                                KM = 0;

                            }
                            TienLai = (gia2 - gia1) * Convert.ToInt32(txtSoLuong1.Text);
                            dataGridViewMua.Rows.Add(dataGridViewKho[0, i].Value, dataGridViewKho[1, i].Value, txtSoLuong1.Text, KM.ToString(), TienLai.ToString());
                            //Cập nhật lại giá tiền 
                            dataGridViewKho[5, i].Value = Convert.ToInt32(dataGridViewKho[5, i].Value) - Convert.ToInt32(gia1);
                            //Cập nhật lại số lượng sách 
                            dataGridViewKho[4, i].Value = Convert.ToInt32(dataGridViewKho[4, i].Value) - Convert.ToInt32(txtSoLuong1.Text);

                        }
                        else
                        {
                            MessageBox.Show("Số sách không đủ, chỉ còn " + dataGridViewKho[4, i].Value);
                        }


                    }
                }
                //}
                //catch (FormatException)
                //{
                //    MessageBox.Show("Nhập sai dữ liệu giá tiền!");
                //}
                //}
                //catch (FormatException)
                //{
                //    MessageBox.Show("Nhập sai dữ liệu số lượng!");
                //}
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
        }

        //Người dùng chỉ được nhập số 
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự nhập vào có phải là chữ số không 
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true; // Nếu không phải chữ số, hủy sự kiện KeyPress
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự nhập vào có phải là chữ số không 
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true; // Nếu không phải chữ số, hủy sự kiện KeyPress
        }

        private void txtSoLuong1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là chữ số không 
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true; // Nếu không phải chữ số, hủy sự kiện KeyPress
        }

        private void txtGiaTien1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là chữ số không 
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true; // Nếu không phải chữ số, hủy sự kiện KeyPress
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                dataGridViewThongKe.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewMua.Rows.Count - 1; i++)
                {
                    if (dataGridViewMua[0, i].Value.ToString() == txtLoaiSach2.Text)
                    {
                        dataGridViewThongKe.Rows.Add(dataGridViewMua[0, i].Value, dataGridViewMua[1, i].Value, dataGridViewMua[2, i].Value, dataGridViewMua[3, i].Value, dataGridViewMua[4, i].Value);

                    }
                }
            }
            if (checkBox6.Checked)
            {
                dataGridViewThongKe.Rows.Clear(); //Mỗi lần tìm kiếm lại thì bảng dữ liệu xuất ra sẽ được refresh 
                for (int i = 0; i < dataGridViewMua.Rows.Count - 1; i++)
                {
                    if (dataGridViewMua[1, i].Value.ToString() == txtTenSach3.Text)
                    {
                        dataGridViewThongKe.Rows.Add(dataGridViewMua[0, i].Value, dataGridViewMua[1, i].Value, dataGridViewMua[2, i].Value, dataGridViewMua[3, i].Value, dataGridViewMua[4, i].Value);

                    }
                }
            }

        }

        private void dataGridViewKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKho.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewKho.Rows[dataGridViewKho.CurrentCell.RowIndex];
                txtLoaiSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                txtNXB.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtGiaTien.Text = row.Cells[5].Value.ToString();
            }
        }


        //IMPORT FILE TXT (lúc form đang load) 
        private void FormMain_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:\BTL_LTGD\BTL_QuanLyThuVien\BTL_QuanLyThuVien\bin\Debug\net6.0-windows\Resource\DuLieu.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridViewKho.Rows.Add(row);
            }
        }


        //Lưu trữ thành file txt (dữ liệu kho sách sau khi thi thao tác). Lưu trên 1 file mới 
        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            TextWriter write = new StreamWriter(@"D:\BTL_LTGD\BTL_QuanLyThuVien\BTL_QuanLyThuVien\bin\Debug\net6.0-windows\Resource\LuuTru.txt");
            for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++) //row
            {
                for (int j = 0; j < dataGridViewKho.Columns.Count; j++) //columns
                {
                    write.Write("\\" + dataGridViewKho.Rows[i].Cells[j].Value.ToString());
                }
                write.WriteLine("");
            }
            write.Close();
            MessageBox.Show("Lưu dữ liệu thành công");
        }

        private void picMoTa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu là sinh viên khi mua đơn hàng sẽ có quà tặng kèm !");
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatSoLuongGioiTinh();
        }

        private void dgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTT.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                string gender = row.Cells[2].Value?.ToString();
                rdbNam.Checked = gender == "Nam";
                rdbNu.Checked = gender == "Nữ";
                txtDTB.Text = row.Cells[3].Value?.ToString();
                cmbKhoa.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            int selectedRow = TimDongTheoMSSV(txtMSSV.Text);
            if (selectedRow == -1)
            {
                // Thêm mới
                dgvTT.Rows.Add(
                    txtMSSV.Text,
                    txtHoTen.Text,
                    rdbNu.Checked ? "Nữ" : "Nam",
                    float.Parse(txtDTB.Text).ToString(),
                    cmbKhoa.Text
                );
                MessageBox.Show("Thêm sinh viên thành công!");
            }
            else
            {
                // Sửa
                CapNhatDong(selectedRow);
                MessageBox.Show("Cập nhật sinh viên thành công!");
            }
            CapNhatSoLuongGioiTinh();
        }
        private int TimDongTheoMSSV(string mssv)
        {
            for (int i = 0; i < dgvTT.Rows.Count; i++)
            {
                if (dgvTT.Rows[i].Cells[0].Value?.ToString() == mssv)
                    return i;
            }
            return -1;
        }

        private void CapNhatDong(int row)
        {
            dgvTT.Rows[row].Cells[0].Value = txtMSSV.Text;
            dgvTT.Rows[row].Cells[1].Value = txtHoTen.Text;
            dgvTT.Rows[row].Cells[2].Value = rdbNu.Checked ? "Nữ" : "Nam";
            dgvTT.Rows[row].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvTT.Rows[row].Cells[4].Value = cmbKhoa.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTT.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvTT.Rows.RemoveAt(dgvTT.SelectedRows[0].Index);
                    MessageBox.Show("Xóa sinh viên thành công!");
                    CapNhatSoLuongGioiTinh();
                }
            }
        }
            private void CapNhatSoLuongGioiTinh()
        {
            int nam = 0, nu = 0;
            foreach (DataGridViewRow row in dgvTT.Rows)
            {
                if (row.IsNewRow) continue;
                string gender = row.Cells[2].Value?.ToString();
                if (gender == "Nam") nam++;
                else if (gender == "Nữ") nu++;
            }
            lblTongNam.Text = $"Tổng SV Nam: {nam}";
            lblTongNu.Text = $"Tổng SV Nữ: {nu}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedItem = "QTKD";
            rdbNu.Checked = true;
            lblTongNam.Text = "Tổng SV Nam: 0";
            lblTongNu.Text = " Nữ: 0";
        }
    }
}


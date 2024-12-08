using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("msnv", "MSNV");
            dataGridView1.Columns.Add("ten", "Ten");
            dataGridView1.Columns.Add("luongcb", "LuongCB");

            dataGridView1.ReadOnly = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            if (formNhanVien.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(formNhanVien.MSNV, formNhanVien.Ten, formNhanVien.LuongCB);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                FormNhanVien formNhanVien = new FormNhanVien
                {
                    MSNV = selectedRow.Cells["msnv"].Value.ToString(),
                    Ten = selectedRow.Cells["ten"].Value.ToString(),
                    LuongCB = selectedRow.Cells["luongcb"].Value.ToString()
                };

                if (formNhanVien.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["msnv"].Value = formNhanVien.MSNV;
                    selectedRow.Cells["ten"].Value = formNhanVien.Ten;
                    selectedRow.Cells["luongcb"].Value = formNhanVien.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

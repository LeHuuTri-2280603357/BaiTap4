namespace BaiTap4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            msnv = new DataGridViewTextBoxColumn();
            ten = new DataGridViewTextBoxColumn();
            luongcb = new DataGridViewTextBoxColumn();
            btn_them = new Button();
            btn_dong = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { msnv, ten, luongcb });
            dataGridView1.Location = new Point(71, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(422, 353);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // msnv
            // 
            msnv.HeaderText = "MSNV";
            msnv.MinimumWidth = 6;
            msnv.Name = "msnv";
            msnv.Width = 125;
            // 
            // ten
            // 
            ten.HeaderText = "Tên";
            ten.MinimumWidth = 6;
            ten.Name = "ten";
            ten.Width = 125;
            // 
            // luongcb
            // 
            luongcb.HeaderText = "Lương CB";
            luongcb.MinimumWidth = 6;
            luongcb.Name = "luongcb";
            luongcb.Width = 125;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(512, 41);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_dong
            // 
            btn_dong.Location = new Point(512, 242);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(94, 29);
            btn_dong.TabIndex = 2;
            btn_dong.Text = "Đóng";
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(512, 174);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(512, 107);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 4;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_dong);
            Controls.Add(btn_them);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn msnv;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn luongcb;
        private Button btn_them;
        private Button btn_dong;
        private Button btn_sua;
        private Button btn_xoa;
    }
}

namespace BaiTap4
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_msnv = new TextBox();
            txt_luongcb = new TextBox();
            txt_ten = new TextBox();
            btn_boqua = new Button();
            btn_dongy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 246);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Lương CB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 166);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "MSNV";
            // 
            // txt_msnv
            // 
            txt_msnv.Location = new Point(337, 83);
            txt_msnv.Name = "txt_msnv";
            txt_msnv.Size = new Size(221, 27);
            txt_msnv.TabIndex = 3;
            // 
            // txt_luongcb
            // 
            txt_luongcb.Location = new Point(337, 246);
            txt_luongcb.Name = "txt_luongcb";
            txt_luongcb.Size = new Size(221, 27);
            txt_luongcb.TabIndex = 4;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(337, 163);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(221, 27);
            txt_ten.TabIndex = 5;
            // 
            // btn_boqua
            // 
            btn_boqua.Location = new Point(427, 314);
            btn_boqua.Name = "btn_boqua";
            btn_boqua.Size = new Size(99, 36);
            btn_boqua.TabIndex = 6;
            btn_boqua.Text = "Bỏ Qua";
            btn_boqua.UseVisualStyleBackColor = true;
            btn_boqua.Click += btn_boqua_Click;
            // 
            // btn_dongy
            // 
            btn_dongy.Location = new Point(281, 314);
            btn_dongy.Name = "btn_dongy";
            btn_dongy.Size = new Size(78, 35);
            btn_dongy.TabIndex = 7;
            btn_dongy.Text = "Đồng Ý";
            btn_dongy.UseVisualStyleBackColor = true;
            btn_dongy.Click += btn_dongy_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_dongy);
            Controls.Add(btn_boqua);
            Controls.Add(txt_ten);
            Controls.Add(txt_luongcb);
            Controls.Add(txt_msnv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhanVien";
            Text = "Form2";
            Load += FormNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_msnv;
        private TextBox txt_luongcb;
        private TextBox txt_ten;
        private Button btn_boqua;
        private Button btn_dongy;
    }
}
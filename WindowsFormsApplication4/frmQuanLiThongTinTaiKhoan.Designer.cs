namespace WindowsFormsApplication4
{
    partial class frmQuanLiThongTinTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoTienTrongTK = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.lblSoTK = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblDiaChiKH = new System.Windows.Forms.Label();
            this.lblSoTienTrongTK = new System.Windows.Forms.Label();
            this.btnThemCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(235, 56);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(268, 20);
            this.txtSTK.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(235, 82);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(268, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSoTienTrongTK
            // 
            this.txtSoTienTrongTK.Location = new System.Drawing.Point(235, 134);
            this.txtSoTienTrongTK.Name = "txtSoTienTrongTK";
            this.txtSoTienTrongTK.Size = new System.Drawing.Size(268, 20);
            this.txtSoTienTrongTK.TabIndex = 3;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(235, 108);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(268, 20);
            this.txtDiaChiKH.TabIndex = 2;
            // 
            // lblSoTK
            // 
            this.lblSoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTK.Location = new System.Drawing.Point(116, 47);
            this.lblSoTK.Name = "lblSoTK";
            this.lblSoTK.Size = new System.Drawing.Size(100, 30);
            this.lblSoTK.TabIndex = 2;
            this.lblSoTK.Text = "Số tài khoản";
            this.lblSoTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(82, 82);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(134, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            this.lblTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaChiKH
            // 
            this.lblDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiKH.Location = new System.Drawing.Point(82, 109);
            this.lblDiaChiKH.Name = "lblDiaChiKH";
            this.lblDiaChiKH.Size = new System.Drawing.Size(134, 20);
            this.lblDiaChiKH.TabIndex = 2;
            this.lblDiaChiKH.Text = "Địa chỉ khách hàng";
            this.lblDiaChiKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoTienTrongTK
            // 
            this.lblSoTienTrongTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienTrongTK.Location = new System.Drawing.Point(52, 136);
            this.lblSoTienTrongTK.Name = "lblSoTienTrongTK";
            this.lblSoTienTrongTK.Size = new System.Drawing.Size(164, 20);
            this.lblSoTienTrongTK.TabIndex = 2;
            this.lblSoTienTrongTK.Text = "Số tiền trong tài khoản";
            this.lblSoTienTrongTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThemCapNhat
            // 
            this.btnThemCapNhat.Location = new System.Drawing.Point(180, 162);
            this.btnThemCapNhat.Name = "btnThemCapNhat";
            this.btnThemCapNhat.Size = new System.Drawing.Size(116, 23);
            this.btnThemCapNhat.TabIndex = 4;
            this.btnThemCapNhat.Text = "Thêm / Cập nhật";
            this.btnThemCapNhat.UseVisualStyleBackColor = true;
            this.btnThemCapNhat.Click += new System.EventHandler(this.btnThemCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(428, 162);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 148);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // frmQuanLiThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 353);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemCapNhat);
            this.Controls.Add(this.lblSoTienTrongTK);
            this.Controls.Add(this.lblDiaChiKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblSoTK);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtSoTienTrongTK);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLiThongTinTaiKhoan";
            this.Text = "frmQuanLiThongTinTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLiThongTinTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoTienTrongTK;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label lblSoTK;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblDiaChiKH;
        private System.Windows.Forms.Label lblSoTienTrongTK;
        private System.Windows.Forms.Button btnThemCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
    }
}
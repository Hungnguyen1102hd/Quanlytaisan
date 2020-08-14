namespace _21_NguyenVanHung_2
{
    partial class frm5_NguyenVanHung
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
            this.cboMaDV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grid_KetQua = new System.Windows.Forms.DataGridView();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.radDV = new System.Windows.Forms.RadioButton();
            this.radTenLoai = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaDV
            // 
            this.cboMaDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDV.FormattingEnabled = true;
            this.cboMaDV.Location = new System.Drawing.Point(405, 131);
            this.cboMaDV.Name = "cboMaDV";
            this.cboMaDV.Size = new System.Drawing.Size(462, 34);
            this.cboMaDV.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 49);
            this.label1.TabIndex = 35;
            this.label1.Text = "TÌM KIẾM LOẠI TÀI SẢN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(909, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 66);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(909, 267);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 66);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grid_KetQua
            // 
            this.grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KetQua.Location = new System.Drawing.Point(186, 267);
            this.grid_KetQua.Name = "grid_KetQua";
            this.grid_KetQua.RowHeadersWidth = 51;
            this.grid_KetQua.RowTemplate.Height = 24;
            this.grid_KetQua.Size = new System.Drawing.Size(681, 184);
            this.grid_KetQua.TabIndex = 31;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(405, 181);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(462, 34);
            this.txtTenLoai.TabIndex = 38;
            // 
            // radDV
            // 
            this.radDV.AutoSize = true;
            this.radDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDV.Location = new System.Drawing.Point(163, 131);
            this.radDV.Name = "radDV";
            this.radDV.Size = new System.Drawing.Size(197, 31);
            this.radDV.TabIndex = 39;
            this.radDV.TabStop = true;
            this.radDV.Text = "Bộ phận quản lý:";
            this.radDV.UseVisualStyleBackColor = true;
            this.radDV.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radTenLoai
            // 
            this.radTenLoai.AutoSize = true;
            this.radTenLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenLoai.Location = new System.Drawing.Point(243, 184);
            this.radTenLoai.Name = "radTenLoai";
            this.radTenLoai.Size = new System.Drawing.Size(117, 31);
            this.radTenLoai.TabIndex = 40;
            this.radTenLoai.TabStop = true;
            this.radTenLoai.Text = "Tên loại:";
            this.radTenLoai.UseVisualStyleBackColor = true;
            // 
            // frm5_NguyenVanHung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 542);
            this.ControlBox = false;
            this.Controls.Add(this.radTenLoai);
            this.Controls.Add(this.radDV);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.cboMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grid_KetQua);
            this.Name = "frm5_NguyenVanHung";
            this.Text = "Tìm kiếm thông tin Tài sản";
            this.Load += new System.EventHandler(this.frm5_NguyenVanHung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView grid_KetQua;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.RadioButton radDV;
        private System.Windows.Forms.RadioButton radTenLoai;
    }
}
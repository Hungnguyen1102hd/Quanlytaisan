namespace _21_NguyenVanHung_2
{
    partial class frm6_NguyenVanHung
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
            this.crs_BaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crs_BaoCao
            // 
            this.crs_BaoCao.ActiveViewIndex = -1;
            this.crs_BaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crs_BaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crs_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crs_BaoCao.Location = new System.Drawing.Point(0, 0);
            this.crs_BaoCao.Name = "crs_BaoCao";
            this.crs_BaoCao.Size = new System.Drawing.Size(800, 450);
            this.crs_BaoCao.TabIndex = 0;
            // 
            // frm6_NguyenVanHung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crs_BaoCao);
            this.Name = "frm6_NguyenVanHung";
            this.Text = "Báo cáo tài sản sửa chữa";
            this.Load += new System.EventHandler(this.frm6_NguyenVanHung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crs_BaoCao;
    }
}
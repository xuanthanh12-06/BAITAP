namespace BAITAP
{
    partial class Bai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.bntTinh = new System.Windows.Forms.Button();
            this.bntLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính chu vi, diện tích hình chữ nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều dài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chiều rộng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chu vi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Diện tích";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(172, 114);
            this.txtChieuDai.Multiline = true;
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(336, 22);
            this.txtChieuDai.TabIndex = 2;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(172, 154);
            this.txtChieuRong.Multiline = true;
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(336, 22);
            this.txtChieuRong.TabIndex = 2;
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(172, 198);
            this.txtChuVi.Multiline = true;
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(336, 22);
            this.txtChuVi.TabIndex = 2;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(172, 239);
            this.txtDienTich.Multiline = true;
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(336, 22);
            this.txtDienTich.TabIndex = 2;
            // 
            // bntTinh
            // 
            this.bntTinh.Location = new System.Drawing.Point(154, 311);
            this.bntTinh.Name = "bntTinh";
            this.bntTinh.Size = new System.Drawing.Size(75, 23);
            this.bntTinh.TabIndex = 3;
            this.bntTinh.Text = "Tính";
            this.bntTinh.UseVisualStyleBackColor = true;
            this.bntTinh.Click += new System.EventHandler(this.bntTinh_Click);
            // 
            // bntLamLai
            // 
            this.bntLamLai.Location = new System.Drawing.Point(333, 311);
            this.bntLamLai.Name = "bntLamLai";
            this.bntLamLai.Size = new System.Drawing.Size(75, 23);
            this.bntLamLai.TabIndex = 3;
            this.bntLamLai.Text = "Làm lại";
            this.bntLamLai.UseVisualStyleBackColor = true;
            this.bntLamLai.Click += new System.EventHandler(this.bntLamLai_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntLamLai);
            this.Controls.Add(this.bntTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Button bntTinh;
        private System.Windows.Forms.Button bntLamLai;
    }
}
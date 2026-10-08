namespace BAITAP
{
    partial class Bai3
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
            this.txtHK1 = new System.Windows.Forms.TextBox();
            this.txtHK2 = new System.Windows.Forms.TextBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.bntDongY = new System.Windows.Forms.Button();
            this.bntLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xếp loại học tập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm HK1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm HK2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xếp loại";
            // 
            // txtHK1
            // 
            this.txtHK1.Location = new System.Drawing.Point(217, 133);
            this.txtHK1.Multiline = true;
            this.txtHK1.Name = "txtHK1";
            this.txtHK1.Size = new System.Drawing.Size(158, 22);
            this.txtHK1.TabIndex = 2;
            // 
            // txtHK2
            // 
            this.txtHK2.Location = new System.Drawing.Point(217, 195);
            this.txtHK2.Multiline = true;
            this.txtHK2.Name = "txtHK2";
            this.txtHK2.Size = new System.Drawing.Size(158, 22);
            this.txtHK2.TabIndex = 2;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(217, 259);
            this.txtXepLoai.Multiline = true;
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(158, 22);
            this.txtXepLoai.TabIndex = 2;
            // 
            // bntDongY
            // 
            this.bntDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDongY.Location = new System.Drawing.Point(91, 343);
            this.bntDongY.Name = "bntDongY";
            this.bntDongY.Size = new System.Drawing.Size(92, 36);
            this.bntDongY.TabIndex = 3;
            this.bntDongY.Text = "Đồng Ý";
            this.bntDongY.UseVisualStyleBackColor = true;
            this.bntDongY.Click += new System.EventHandler(this.bntDongY_Click);
            // 
            // bntLamLai
            // 
            this.bntLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLamLai.Location = new System.Drawing.Point(283, 343);
            this.bntLamLai.Name = "bntLamLai";
            this.bntLamLai.Size = new System.Drawing.Size(92, 36);
            this.bntLamLai.TabIndex = 3;
            this.bntLamLai.Text = "Làm lại";
            this.bntLamLai.UseVisualStyleBackColor = true;
            this.bntLamLai.Click += new System.EventHandler(this.bntLamLai_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntLamLai);
            this.Controls.Add(this.bntDongY);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtHK2);
            this.Controls.Add(this.txtHK1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHK1;
        private System.Windows.Forms.TextBox txtHK2;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Button bntDongY;
        private System.Windows.Forms.Button bntLamLai;
    }
}
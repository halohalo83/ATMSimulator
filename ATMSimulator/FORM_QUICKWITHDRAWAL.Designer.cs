namespace ATMSimulator
{
    partial class FORM_QUICKWITHDRAWAL
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
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn10000 = new System.Windows.Forms.Button();
            this.btn20000 = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnNhapSoKhac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(12, 12);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(179, 60);
            this.btn500.TabIndex = 0;
            this.btn500.Text = "500.000 vnđ";
            this.btn500.UseVisualStyleBackColor = true;
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(258, 12);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(179, 60);
            this.btn1000.TabIndex = 1;
            this.btn1000.Text = "1.000.000 vnđ";
            this.btn1000.UseVisualStyleBackColor = true;
            // 
            // btn2000
            // 
            this.btn2000.Location = new System.Drawing.Point(12, 112);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(179, 60);
            this.btn2000.TabIndex = 2;
            this.btn2000.Text = "2.000.000 vnđ";
            this.btn2000.UseVisualStyleBackColor = true;
            // 
            // btn5000
            // 
            this.btn5000.Location = new System.Drawing.Point(258, 112);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(179, 60);
            this.btn5000.TabIndex = 3;
            this.btn5000.Text = "5.000.000 vnđ";
            this.btn5000.UseVisualStyleBackColor = true;
            // 
            // btn10000
            // 
            this.btn10000.Location = new System.Drawing.Point(12, 212);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(179, 60);
            this.btn10000.TabIndex = 4;
            this.btn10000.Text = "10.000.000 vnđ";
            this.btn10000.UseVisualStyleBackColor = true;
            // 
            // btn20000
            // 
            this.btn20000.Location = new System.Drawing.Point(258, 212);
            this.btn20000.Name = "btn20000";
            this.btn20000.Size = new System.Drawing.Size(179, 60);
            this.btn20000.TabIndex = 5;
            this.btn20000.Text = "20.000.000 vnđ";
            this.btn20000.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(258, 305);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(179, 60);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnNhapSoKhac
            // 
            this.btnNhapSoKhac.Location = new System.Drawing.Point(12, 305);
            this.btnNhapSoKhac.Name = "btnNhapSoKhac";
            this.btnNhapSoKhac.Size = new System.Drawing.Size(179, 60);
            this.btnNhapSoKhac.TabIndex = 7;
            this.btnNhapSoKhac.Text = "Nhập số khác";
            this.btnNhapSoKhac.UseVisualStyleBackColor = true;
            this.btnNhapSoKhac.Click += new System.EventHandler(this.btnNhapSoKhac_Click);
            // 
            // FORM_QUICKWITHDRAWAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 386);
            this.Controls.Add(this.btnNhapSoKhac);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btn20000);
            this.Controls.Add(this.btn10000);
            this.Controls.Add(this.btn5000);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Name = "FORM_QUICKWITHDRAWAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rút tiền nhanh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn10000;
        private System.Windows.Forms.Button btn20000;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnNhapSoKhac;
    }
}
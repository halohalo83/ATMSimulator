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
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnNhapSoKhac = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(12, 73);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(179, 60);
            this.btn100.TabIndex = 0;
            this.btn100.Text = "100.000 vnđ";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(258, 73);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(179, 60);
            this.btn200.TabIndex = 1;
            this.btn200.Text = "200.000 vnđ";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(12, 185);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(179, 60);
            this.btn1000.TabIndex = 2;
            this.btn1000.Text = "1.000.000 vnđ";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn2000
            // 
            this.btn2000.Location = new System.Drawing.Point(258, 185);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(179, 60);
            this.btn2000.TabIndex = 3;
            this.btn2000.Text = "2.000.000 vnđ";
            this.btn2000.UseVisualStyleBackColor = true;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
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
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Teal;
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTen.Location = new System.Drawing.Point(0, 0);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(449, 54);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "ATM Simulator";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FORM_QUICKWITHDRAWAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 386);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnNhapSoKhac);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Name = "FORM_QUICKWITHDRAWAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rút tiền nhanh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnNhapSoKhac;
        private System.Windows.Forms.Label lblTen;
    }
}
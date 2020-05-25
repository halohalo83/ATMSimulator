namespace ATMSimulator
{
    partial class FORM_MAIN
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
            this.btnTruyVan = new System.Windows.Forms.Button();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.btnDoiPin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Location = new System.Drawing.Point(26, 36);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(163, 44);
            this.btnTruyVan.TabIndex = 0;
            this.btnTruyVan.Text = "Truy vấn số dư";
            this.btnTruyVan.UseVisualStyleBackColor = true;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // btnRutTien
            // 
            this.btnRutTien.Location = new System.Drawing.Point(26, 161);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(163, 44);
            this.btnRutTien.TabIndex = 1;
            this.btnRutTien.Text = "Rút tiền";
            this.btnRutTien.UseVisualStyleBackColor = true;
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
            // 
            // btnDoiPin
            // 
            this.btnDoiPin.Location = new System.Drawing.Point(316, 36);
            this.btnDoiPin.Name = "btnDoiPin";
            this.btnDoiPin.Size = new System.Drawing.Size(163, 44);
            this.btnDoiPin.TabIndex = 2;
            this.btnDoiPin.Text = "Đổi PIN";
            this.btnDoiPin.UseVisualStyleBackColor = true;
            this.btnDoiPin.Click += new System.EventHandler(this.btnDoiPin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(316, 161);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 44);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 254);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiPin);
            this.Controls.Add(this.btnRutTien);
            this.Controls.Add(this.btnTruyVan);
            this.Name = "FORM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTruyVan;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.Button btnDoiPin;
        private System.Windows.Forms.Button btnThoat;
    }
}
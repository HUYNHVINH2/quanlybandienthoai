﻿namespace QuanLiCuaHangDienThoai
{
    partial class frmQuanLiSanPham
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.GrV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTImKiem = new System.Windows.Forms.Button();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.checkID = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(79, 8);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(149, 29);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // panel23
            // 
            this.panel23.Location = new System.Drawing.Point(12, 140);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(228, 251);
            this.panel23.TabIndex = 2;
            // 
            // GrV
            // 
            this.GrV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrV.Location = new System.Drawing.Point(400, 140);
            this.GrV.Name = "GrV";
            this.GrV.Size = new System.Drawing.Size(240, 150);
            this.GrV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh Sách Sản Phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTImKiem
            // 
            this.btnTImKiem.Location = new System.Drawing.Point(603, 55);
            this.btnTImKiem.Name = "btnTImKiem";
            this.btnTImKiem.Size = new System.Drawing.Size(109, 38);
            this.btnTImKiem.TabIndex = 4;
            this.btnTImKiem.Text = "tim kiem";
            this.btnTImKiem.UseVisualStyleBackColor = true;
            this.btnTImKiem.Click += new System.EventHandler(this.btnTImKiem_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(440, 63);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(158, 20);
            this.tbxTimKiem.TabIndex = 5;
            // 
            // checkID
            // 
            this.checkID.AutoSize = true;
            this.checkID.Location = new System.Drawing.Point(440, 89);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(92, 17);
            this.checkID.TabIndex = 7;
            this.checkID.Text = "TIM THEO ID";
            this.checkID.UseVisualStyleBackColor = true;
            // 
            // frmQuanLiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 533);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.GrV);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.btnTImKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLiSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLiSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTImKiem;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.DataGridView GrV;
        private System.Windows.Forms.CheckBox checkID;
    }
}
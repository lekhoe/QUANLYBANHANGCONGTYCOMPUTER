namespace QUANLYBANHANGCONGTYCOMPUTER
{
    partial class Quanlyhoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblquaylai = new System.Windows.Forms.Button();
            this.tbldangxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbltimkiem = new System.Windows.Forms.Button();
            this.tblsapxep = new System.Windows.Forms.Button();
            this.tblxoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvquanlyhoadon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbtongtien = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tblquaylai);
            this.panel1.Controls.Add(this.tbldangxuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 131);
            this.panel1.TabIndex = 1;
            // 
            // tblquaylai
            // 
            this.tblquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblquaylai.Location = new System.Drawing.Point(61, 45);
            this.tblquaylai.Name = "tblquaylai";
            this.tblquaylai.Size = new System.Drawing.Size(160, 49);
            this.tblquaylai.TabIndex = 1;
            this.tblquaylai.Text = "Quay lại";
            this.tblquaylai.UseVisualStyleBackColor = true;
            // 
            // tbldangxuat
            // 
            this.tbldangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbldangxuat.Location = new System.Drawing.Point(835, 47);
            this.tbldangxuat.Name = "tbldangxuat";
            this.tbldangxuat.Size = new System.Drawing.Size(152, 49);
            this.tbldangxuat.TabIndex = 1;
            this.tbldangxuat.Text = "Đăng xuất";
            this.tbldangxuat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbltimkiem);
            this.panel2.Controls.Add(this.tblsapxep);
            this.panel2.Controls.Add(this.tblxoa);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 94);
            this.panel2.TabIndex = 2;
            // 
            // tbltimkiem
            // 
            this.tbltimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbltimkiem.Location = new System.Drawing.Point(404, 28);
            this.tbltimkiem.Name = "tbltimkiem";
            this.tbltimkiem.Size = new System.Drawing.Size(209, 42);
            this.tbltimkiem.TabIndex = 1;
            this.tbltimkiem.Text = "Tìm kiếm theo mã";
            this.tbltimkiem.UseVisualStyleBackColor = true;
            // 
            // tblsapxep
            // 
            this.tblsapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblsapxep.Location = new System.Drawing.Point(746, 28);
            this.tblsapxep.Name = "tblsapxep";
            this.tblsapxep.Size = new System.Drawing.Size(209, 42);
            this.tblsapxep.TabIndex = 2;
            this.tblsapxep.Text = "Sắp xếp theo ngày";
            this.tblsapxep.UseVisualStyleBackColor = true;
            // 
            // tblxoa
            // 
            this.tblxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblxoa.Location = new System.Drawing.Point(86, 28);
            this.tblxoa.Name = "tblxoa";
            this.tblxoa.Size = new System.Drawing.Size(209, 42);
            this.tblxoa.TabIndex = 0;
            this.tblxoa.Text = "Xóa";
            this.tblxoa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvquanlyhoadon);
            this.panel3.Location = new System.Drawing.Point(12, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 387);
            this.panel3.TabIndex = 3;
            // 
            // dgvquanlyhoadon
            // 
            this.dgvquanlyhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlyhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvquanlyhoadon.Location = new System.Drawing.Point(0, 0);
            this.dgvquanlyhoadon.Name = "dgvquanlyhoadon";
            this.dgvquanlyhoadon.RowHeadersWidth = 51;
            this.dgvquanlyhoadon.RowTemplate.Height = 24;
            this.dgvquanlyhoadon.Size = new System.Drawing.Size(1067, 387);
            this.dgvquanlyhoadon.TabIndex = 0;
            this.dgvquanlyhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền hóa đơn: ";
            // 
            // rtbtongtien
            // 
            this.rtbtongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbtongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbtongtien.Location = new System.Drawing.Point(759, 650);
            this.rtbtongtien.Name = "rtbtongtien";
            this.rtbtongtien.Size = new System.Drawing.Size(320, 43);
            this.rtbtongtien.TabIndex = 5;
            this.rtbtongtien.Text = "";
            // 
            // Quanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 703);
            this.Controls.Add(this.rtbtongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Quanlyhoadon";
            this.Text = "Quản lý hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tblquaylai;
        private System.Windows.Forms.Button tbldangxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tbltimkiem;
        private System.Windows.Forms.Button tblsapxep;
        private System.Windows.Forms.Button tblxoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvquanlyhoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbtongtien;
    }
}
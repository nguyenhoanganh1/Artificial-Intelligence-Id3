namespace WindowsFormsApp_ID3
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.txtTinhGain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.rdoHinhDang = new System.Windows.Forms.RadioButton();
            this.rdoChieuCao = new System.Windows.Forms.RadioButton();
            this.rdoGioiTinh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTinhToan2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnChonCayPhanHoach = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 253);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(755, 185);
            this.dgv.TabIndex = 1;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(477, 25);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(202, 20);
            this.txtInfo.TabIndex = 2;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(383, 25);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(39, 13);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "Info(D)";
            // 
            // txtTinhGain
            // 
            this.txtTinhGain.Location = new System.Drawing.Point(477, 63);
            this.txtTinhGain.Name = "txtTinhGain";
            this.txtTinhGain.Size = new System.Drawing.Size(202, 20);
            this.txtTinhGain.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gain";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(119, 70);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 10;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnPhanHoach_Click);
            // 
            // rdoHinhDang
            // 
            this.rdoHinhDang.AutoSize = true;
            this.rdoHinhDang.Location = new System.Drawing.Point(43, 28);
            this.rdoHinhDang.Name = "rdoHinhDang";
            this.rdoHinhDang.Size = new System.Drawing.Size(76, 17);
            this.rdoHinhDang.TabIndex = 11;
            this.rdoHinhDang.TabStop = true;
            this.rdoHinhDang.Text = "Hình Dáng";
            this.rdoHinhDang.UseVisualStyleBackColor = true;
            // 
            // rdoChieuCao
            // 
            this.rdoChieuCao.AutoSize = true;
            this.rdoChieuCao.Location = new System.Drawing.Point(142, 29);
            this.rdoChieuCao.Name = "rdoChieuCao";
            this.rdoChieuCao.Size = new System.Drawing.Size(73, 17);
            this.rdoChieuCao.TabIndex = 12;
            this.rdoChieuCao.TabStop = true;
            this.rdoChieuCao.Text = "Chiều cao";
            this.rdoChieuCao.UseVisualStyleBackColor = true;
            // 
            // rdoGioiTinh
            // 
            this.rdoGioiTinh.AutoSize = true;
            this.rdoGioiTinh.Location = new System.Drawing.Point(241, 29);
            this.rdoGioiTinh.Name = "rdoGioiTinh";
            this.rdoGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.rdoGioiTinh.TabIndex = 13;
            this.rdoGioiTinh.TabStop = true;
            this.rdoGioiTinh.Text = "Giới Tính";
            this.rdoGioiTinh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnTinhToan2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoChieuCao);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.rdoGioiTinh);
            this.groupBox1.Controls.Add(this.btnChonCayPhanHoach);
            this.groupBox1.Controls.Add(this.rdoHinhDang);
            this.groupBox1.Controls.Add(this.btnTinhToan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.txtTinhGain);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 235);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Chọn cây phân hoặch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTinhToan2
            // 
            this.btnTinhToan2.Location = new System.Drawing.Point(119, 70);
            this.btnTinhToan2.Name = "btnTinhToan2";
            this.btnTinhToan2.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan2.TabIndex = 14;
            this.btnTinhToan2.Text = "Tính toán";
            this.btnTinhToan2.UseVisualStyleBackColor = true;
            this.btnTinhToan2.Click += new System.EventHandler(this.btnTinhToan2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Max";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(477, 104);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(202, 20);
            this.txtMax.TabIndex = 15;
            // 
            // btnChonCayPhanHoach
            // 
            this.btnChonCayPhanHoach.Location = new System.Drawing.Point(477, 141);
            this.btnChonCayPhanHoach.Name = "btnChonCayPhanHoach";
            this.btnChonCayPhanHoach.Size = new System.Drawing.Size(202, 23);
            this.btnChonCayPhanHoach.TabIndex = 14;
            this.btnChonCayPhanHoach.Text = "Chọn cây phân hoặch";
            this.btnChonCayPhanHoach.UseVisualStyleBackColor = true;
            this.btnChonCayPhanHoach.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(43, 109);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 111);
            this.treeView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox txtTinhGain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.RadioButton rdoHinhDang;
        private System.Windows.Forms.RadioButton rdoChieuCao;
        private System.Windows.Forms.RadioButton rdoGioiTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonCayPhanHoach;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhToan2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
    }
}


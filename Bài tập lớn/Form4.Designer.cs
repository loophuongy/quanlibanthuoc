namespace Bài_tập_lớn
{
    partial class Form4
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
            this.lblNgaykiem = new System.Windows.Forms.Label();
            this.lblNguoikiem = new System.Windows.Forms.Label();
            this.dtpNgaykiem = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbDanhsach = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmTenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHansd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTondau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbDanhsach.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgaykiem
            // 
            this.lblNgaykiem.AutoSize = true;
            this.lblNgaykiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaykiem.Location = new System.Drawing.Point(3, 0);
            this.lblNgaykiem.Name = "lblNgaykiem";
            this.lblNgaykiem.Size = new System.Drawing.Size(81, 16);
            this.lblNgaykiem.TabIndex = 1;
            this.lblNgaykiem.Text = "Ngày kiểm";
            // 
            // lblNguoikiem
            // 
            this.lblNguoikiem.AutoSize = true;
            this.lblNguoikiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoikiem.Location = new System.Drawing.Point(3, 0);
            this.lblNguoikiem.Name = "lblNguoikiem";
            this.lblNguoikiem.Size = new System.Drawing.Size(85, 16);
            this.lblNguoikiem.TabIndex = 2;
            this.lblNguoikiem.Text = "Người kiểm";
            this.lblNguoikiem.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpNgaykiem
            // 
            this.dtpNgaykiem.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaykiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaykiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaykiem.Location = new System.Drawing.Point(3, 29);
            this.dtpNgaykiem.Name = "dtpNgaykiem";
            this.dtpNgaykiem.Size = new System.Drawing.Size(224, 22);
            this.dtpNgaykiem.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hàng hóa vào phiếu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.54786F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.45214F));
            this.tableLayoutPanel3.Controls.Add(this.btnTimkiem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1097, 37);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Teal;
            this.btnTimkiem.Location = new System.Drawing.Point(761, 3);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(149, 31);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 31);
            this.textBox1.TabIndex = 0;
            // 
            // grbDanhsach
            // 
            this.grbDanhsach.Controls.Add(this.tableLayoutPanel4);
            this.grbDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhsach.Location = new System.Drawing.Point(13, 152);
            this.grbDanhsach.Name = "grbDanhsach";
            this.grbDanhsach.Size = new System.Drawing.Size(1103, 426);
            this.grbDanhsach.TabIndex = 7;
            this.grbDanhsach.TabStop = false;
            this.grbDanhsach.Text = "Danh sách";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnLuu, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1097, 405);
            this.tableLayoutPanel4.TabIndex = 11;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Teal;
            this.btnLuu.Location = new System.Drawing.Point(450, 368);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(450, 3, 450, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(197, 34);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenthuoc,
            this.dgvSolo,
            this.dgvHansd,
            this.dgvTondau,
            this.dgvNhap,
            this.Clm,
            this.clmSoluong,
            this.clmDonvi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 359);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmTenthuoc
            // 
            this.clmTenthuoc.HeaderText = "Tên thuốc";
            this.clmTenthuoc.MinimumWidth = 6;
            this.clmTenthuoc.Name = "clmTenthuoc";
            this.clmTenthuoc.Width = 125;
            // 
            // dgvSolo
            // 
            this.dgvSolo.HeaderText = "Số lô";
            this.dgvSolo.MinimumWidth = 6;
            this.dgvSolo.Name = "dgvSolo";
            this.dgvSolo.Width = 125;
            // 
            // dgvHansd
            // 
            this.dgvHansd.HeaderText = "Hạn sử dụng";
            this.dgvHansd.MinimumWidth = 6;
            this.dgvHansd.Name = "dgvHansd";
            this.dgvHansd.Width = 125;
            // 
            // dgvTondau
            // 
            this.dgvTondau.HeaderText = "Tồn đầu";
            this.dgvTondau.MinimumWidth = 6;
            this.dgvTondau.Name = "dgvTondau";
            this.dgvTondau.Width = 80;
            // 
            // dgvNhap
            // 
            this.dgvNhap.HeaderText = "Nhập";
            this.dgvNhap.MinimumWidth = 6;
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.Width = 80;
            // 
            // Clm
            // 
            this.Clm.HeaderText = "Đơn giá";
            this.Clm.MinimumWidth = 6;
            this.Clm.Name = "Clm";
            this.Clm.Width = 125;
            // 
            // clmSoluong
            // 
            this.clmSoluong.HeaderText = "Số lượng";
            this.clmSoluong.MinimumWidth = 6;
            this.clmSoluong.Name = "clmSoluong";
            this.clmSoluong.Width = 80;
            // 
            // clmDonvi
            // 
            this.clmDonvi.HeaderText = "Đơn vị";
            this.clmDonvi.MinimumWidth = 6;
            this.clmDonvi.Name = "clmDonvi";
            this.clmDonvi.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtpNgaykiem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNgaykiem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.93548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.06452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 63);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblNguoikiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(239, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.50943F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.49057F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 63);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 887F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1103, 69);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.grbDanhsach, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13485F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20841F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.65675F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1129, 591);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Bài_tập_lớn.Properties.Resources.Full_background;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.quảnLýKhoTồnKhoToolStripMenuItem,
            this.kiểmKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bánHàngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpHàngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // quảnLýKhoTồnKhoToolStripMenuItem
            // 
            this.quảnLýKhoTồnKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKhoTồnKhoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýKhoTồnKhoToolStripMenuItem.Name = "quảnLýKhoTồnKhoToolStripMenuItem";
            this.quảnLýKhoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.quảnLýKhoTồnKhoToolStripMenuItem.Text = "Quản lý kho - Tồn kho";
            // 
            // kiểmKhoToolStripMenuItem
            // 
            this.kiểmKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiểmKhoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kiểmKhoToolStripMenuItem.Name = "kiểmKhoToolStripMenuItem";
            this.kiểmKhoToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.kiểmKhoToolStripMenuItem.Text = "Kiểm kho";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 619);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Kiểm kho";
            this.Load += new System.EventHandler(this.frmKiemkho_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grbDanhsach.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNgaykiem;
        private System.Windows.Forms.Label lblNguoikiem;
        private System.Windows.Forms.DateTimePicker dtpNgaykiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbDanhsach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHansd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTondau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDonvi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoTồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}
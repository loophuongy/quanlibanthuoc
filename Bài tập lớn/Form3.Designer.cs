namespace Bài_tập_lớn
{
    partial class Form3
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
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbTuychinh = new System.Windows.Forms.GroupBox();
            this.grbTgiannhapkho = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grbHangsx = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.grbTheohsd = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.grbDanhsach = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTuychinh.SuspendLayout();
            this.grbTgiannhapkho.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grbHangsx.SuspendLayout();
            this.grbTheohsd.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(3, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(63, 16);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            this.lblTuNgay.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grbTuychinh
            // 
            this.grbTuychinh.Controls.Add(this.tableLayoutPanel5);
            this.grbTuychinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTuychinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTuychinh.Location = new System.Drawing.Point(13, 13);
            this.grbTuychinh.Name = "grbTuychinh";
            this.grbTuychinh.Size = new System.Drawing.Size(220, 565);
            this.grbTuychinh.TabIndex = 8;
            this.grbTuychinh.TabStop = false;
            this.grbTuychinh.Text = "Tùy chỉnh";
            // 
            // grbTgiannhapkho
            // 
            this.grbTgiannhapkho.Controls.Add(this.tableLayoutPanel4);
            this.grbTgiannhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTgiannhapkho.Location = new System.Drawing.Point(3, 3);
            this.grbTgiannhapkho.Name = "grbTgiannhapkho";
            this.grbTgiannhapkho.Size = new System.Drawing.Size(208, 258);
            this.grbTgiannhapkho.TabIndex = 4;
            this.grbTgiannhapkho.TabStop = false;
            this.grbTgiannhapkho.Text = "Thời gian nhập kho";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grbHangsx, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.grbTheohsd, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(202, 237);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // grbHangsx
            // 
            this.grbHangsx.Controls.Add(this.comboBox4);
            this.grbHangsx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHangsx.Location = new System.Drawing.Point(3, 180);
            this.grbHangsx.Name = "grbHangsx";
            this.grbHangsx.Size = new System.Drawing.Size(196, 54);
            this.grbHangsx.TabIndex = 6;
            this.grbHangsx.TabStop = false;
            this.grbHangsx.Text = "Hãng sản xuất";
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 18);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(190, 24);
            this.comboBox4.TabIndex = 0;
            // 
            // grbTheohsd
            // 
            this.grbTheohsd.Controls.Add(this.comboBox3);
            this.grbTheohsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTheohsd.Location = new System.Drawing.Point(3, 121);
            this.grbTheohsd.Name = "grbTheohsd";
            this.grbTheohsd.Size = new System.Drawing.Size(196, 53);
            this.grbTheohsd.TabIndex = 5;
            this.grbTheohsd.TabStop = false;
            this.grbTheohsd.Text = "Tình trạng hạn sử dụng";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(190, 24);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblTuNgay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.57143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 53);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.42857F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.57143F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(196, 53);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tới ngày";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(3, 24);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // grbDanhsach
            // 
            this.grbDanhsach.Controls.Add(this.dataGridView1);
            this.grbDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhsach.Location = new System.Drawing.Point(239, 13);
            this.grbDanhsach.Name = "grbDanhsach";
            this.grbDanhsach.Size = new System.Drawing.Size(877, 565);
            this.grbDanhsach.TabIndex = 9;
            this.grbDanhsach.TabStop = false;
            this.grbDanhsach.Text = "Danh sách";
            this.grbDanhsach.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(871, 544);
            this.dataGridView1.TabIndex = 0;
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.46058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.53941F));
            this.tableLayoutPanel1.Controls.Add(this.grbTuychinh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbDanhsach, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 591);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnTimkiem, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.grbTgiannhapkho, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(214, 544);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Teal;
            this.btnTimkiem.Location = new System.Drawing.Point(50, 274);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(50, 10, 50, 3);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(114, 36);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bánHàngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpHàngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // quảnLýKhoTồnKhoToolStripMenuItem
            // 
            this.quảnLýKhoTồnKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKhoTồnKhoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýKhoTồnKhoToolStripMenuItem.Name = "quảnLýKhoTồnKhoToolStripMenuItem";
            this.quảnLýKhoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.quảnLýKhoTồnKhoToolStripMenuItem.Text = "Quản lý kho - Tồn kho";
            // 
            // kiểmKhoToolStripMenuItem
            // 
            this.kiểmKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiểmKhoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kiểmKhoToolStripMenuItem.Name = "kiểmKhoToolStripMenuItem";
            this.kiểmKhoToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.kiểmKhoToolStripMenuItem.Text = "Kiểm kho";
            this.kiểmKhoToolStripMenuItem.Click += new System.EventHandler(this.kiểmKhoToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Quản lý kho - Tồn kho";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grbTuychinh.ResumeLayout(false);
            this.grbTgiannhapkho.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grbHangsx.ResumeLayout(false);
            this.grbTheohsd.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grbDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grbTuychinh;
        private System.Windows.Forms.GroupBox grbTheohsd;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox grbTgiannhapkho;
        private System.Windows.Forms.GroupBox grbHangsx;
        private System.Windows.Forms.ComboBox comboBox4;
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
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
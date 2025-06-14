namespace Sistem_Reservasi_Hotel.View
{
    partial class FormRiwayatTransaksi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnKembali = new Button();
            dataGridViewRiwayatTransaksi = new DataGridView();
            dtpFilterBulan = new DateTimePicker();
            btnFilterBulan = new Button();
            btnReset = new Button();
            lblTotalPendapatan = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(59, 74, 107);
            btnKembali.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(500, 600);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(220, 80);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridViewRiwayatTransaksi
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewRiwayatTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRiwayatTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRiwayatTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRiwayatTransaksi.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewRiwayatTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewRiwayatTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRiwayatTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRiwayatTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 74, 107);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRiwayatTransaksi.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRiwayatTransaksi.EnableHeadersVisualStyles = false;
            dataGridViewRiwayatTransaksi.Location = new Point(0, 56);
            dataGridViewRiwayatTransaksi.MultiSelect = false;
            dataGridViewRiwayatTransaksi.Name = "dataGridViewRiwayatTransaksi";
            dataGridViewRiwayatTransaksi.ReadOnly = true;
            dataGridViewRiwayatTransaksi.RowHeadersVisible = false;
            dataGridViewRiwayatTransaksi.RowHeadersWidth = 51;
            dataGridViewRiwayatTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRiwayatTransaksi.Size = new Size(1180, 332);
            dataGridViewRiwayatTransaksi.TabIndex = 14;
            dataGridViewRiwayatTransaksi.CellContentClick += dataGridViewRiwayatTransaksi_CellContentClick;
            // 
            // dtpFilterBulan
            // 
            dtpFilterBulan.Location = new Point(721, 12);
            dtpFilterBulan.Name = "dtpFilterBulan";
            dtpFilterBulan.Size = new Size(250, 27);
            dtpFilterBulan.TabIndex = 15;
            // 
            // btnFilterBulan
            // 
            btnFilterBulan.Location = new Point(977, 10);
            btnFilterBulan.Name = "btnFilterBulan";
            btnFilterBulan.Size = new Size(94, 29);
            btnFilterBulan.TabIndex = 16;
            btnFilterBulan.Text = "Filter Bulan";
            btnFilterBulan.UseVisualStyleBackColor = true;
            btnFilterBulan.Click += btnFilterBulan_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1077, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPendapatan.Location = new Point(380, 480);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(352, 46);
            lblTotalPendapatan.TabIndex = 18;
            lblTotalPendapatan.Text = "Total Pendapatan: Rp0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(59, 74, 107);
            label2.Location = new Point(184, -2);
            label2.Name = "label2";
            label2.Size = new Size(358, 54);
            label2.TabIndex = 19;
            label2.Text = "Riwayat Transaksi";
            // 
            // FormRiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(label2);
            Controls.Add(lblTotalPendapatan);
            Controls.Add(btnReset);
            Controls.Add(btnFilterBulan);
            Controls.Add(dtpFilterBulan);
            Controls.Add(dataGridViewRiwayatTransaksi);
            Controls.Add(btnKembali);
            Name = "FormRiwayatTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRiwayatTransaksi";
            Load += FormRiwayatTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayatTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnKembali;
        private DataGridView dataGridViewRiwayatTransaksi;
        private DateTimePicker dtpFilterBulan;
        private Button btnFilterBulan;
        private Button btnReset;
        private Label lblTotalPendapatan;
        private Label label2;
    }
}
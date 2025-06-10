namespace Sistem_Reservasi_Hotel.View
{
    partial class Dasboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnKelolaKamar = new Button();
            btnKelolaFasilitas = new Button();
            btnCheckIn = new Button();
            btnRiwayatTransaksi = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
//            panel2 = new Panel();
            dataGridViewKamarTersedia = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridViewReservasi = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKamarTersedia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservasi).BeginInit();
            SuspendLayout();
            // 
            // btnKelolaKamar
            // 
            btnKelolaKamar.BackColor = Color.FromArgb(242, 52, 86);
            btnKelolaKamar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaKamar.ForeColor = Color.Transparent;
            btnKelolaKamar.Location = new Point(10, 100);
            btnKelolaKamar.Name = "btnKelolaKamar";
            btnKelolaKamar.Size = new Size(220, 80);
            btnKelolaKamar.TabIndex = 3;
            btnKelolaKamar.Text = "KELOLA KAMAR";
            btnKelolaKamar.UseVisualStyleBackColor = false;
            btnKelolaKamar.Click += btnKelolaKamar_Click;
            // 
            // btnKelolaFasilitas
            // 
            btnKelolaFasilitas.BackColor = Color.FromArgb(242, 52, 86);
            btnKelolaFasilitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaFasilitas.ForeColor = Color.Transparent;
            btnKelolaFasilitas.Location = new Point(10, 200);
            btnKelolaFasilitas.Name = "btnKelolaFasilitas";
            btnKelolaFasilitas.Size = new Size(220, 80);
            btnKelolaFasilitas.TabIndex = 5;
            btnKelolaFasilitas.Text = "KELOLA FASILITAS";
            btnKelolaFasilitas.UseVisualStyleBackColor = false;
            btnKelolaFasilitas.Click += btnKelolaFasilitas_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(242, 52, 86);
            btnCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.Transparent;
            btnCheckIn.Location = new Point(10, 300);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(220, 80);
            btnCheckIn.TabIndex = 6;
            btnCheckIn.Text = "RESERVASI";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.FromArgb(242, 52, 86);
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.Transparent;
            btnRiwayatTransaksi.Location = new Point(10, 400);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(220, 80);
            btnRiwayatTransaksi.TabIndex = 7;
            btnRiwayatTransaksi.Text = "RIWAYAT TRANSAKSI";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(242, 52, 86);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(10, 500);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 80);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 74, 107);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnKelolaKamar);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRiwayatTransaksi);
            panel1.Controls.Add(btnKelolaFasilitas);
            panel1.Controls.Add(btnCheckIn);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 750);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
//            panel2.AutoSize = true;
            //panel2.Dock = DockStyle.Fill;
            //panel2.Location = new Point(0, 0);
            //panel2.Name = "panel2";
            //panel2.Size = new Size(250, 750);
            //panel2.TabIndex = 9;
            // 
            // dataGridViewKamarTersedia
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewKamarTersedia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKamarTersedia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewKamarTersedia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewKamarTersedia.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewKamarTersedia.BorderStyle = BorderStyle.None;
            dataGridViewKamarTersedia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKamarTersedia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewKamarTersedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKamarTersedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(242, 52, 86);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewKamarTersedia.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKamarTersedia.EnableHeadersVisualStyles = false;
            dataGridViewKamarTersedia.Location = new Point(256, 72);
            dataGridViewKamarTersedia.MultiSelect = false;
            dataGridViewKamarTersedia.Name = "dataGridViewKamarTersedia";
            dataGridViewKamarTersedia.ReadOnly = true;
            dataGridViewKamarTersedia.RowHeadersVisible = false;
            dataGridViewKamarTersedia.RowHeadersWidth = 51;
            dataGridViewKamarTersedia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKamarTersedia.Size = new Size(915, 245);
            dataGridViewKamarTersedia.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 52, 86);
            label1.Location = new Point(550, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 62);
            label1.TabIndex = 12;
            label1.Text = "Kamar Tersedia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 52, 86);
            label2.Location = new Point(614, 331);
            label2.Name = "label2";
            label2.Size = new Size(232, 62);
            label2.TabIndex = 13;
            label2.Text = "Reservasi";
            // 
            // dataGridViewReservasi
            // 
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewReservasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReservasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReservasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewReservasi.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewReservasi.BorderStyle = BorderStyle.None;
            dataGridViewReservasi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewReservasi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewReservasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 52, 86);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewReservasi.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewReservasi.EnableHeadersVisualStyles = false;
            dataGridViewReservasi.Location = new Point(257, 399);
            dataGridViewReservasi.MultiSelect = false;
            dataGridViewReservasi.Name = "dataGridViewReservasi";
            dataGridViewReservasi.ReadOnly = true;
            dataGridViewReservasi.RowHeadersVisible = false;
            dataGridViewReservasi.RowHeadersWidth = 51;
            dataGridViewReservasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservasi.Size = new Size(914, 350);
            dataGridViewReservasi.TabIndex = 14;
            dataGridViewReservasi.CellContentClick += dataGridViewReservasi_CellContentClick;
            // 
            // Dasboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridViewReservasi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewKamarTersedia);
            Controls.Add(panel1);
            Name = "Dasboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Dasboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKamarTersedia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKelolaKamar;
        private Button btnKelolaFasilitas;
        private Button btnCheckIn;
        private Button btnRiwayatTransaksi;
        private Button btnLogout;
        private Panel panel1;
        private DataGridView dataGridViewKamarTersedia;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewReservasi;
        private Panel panel2;
    }
}
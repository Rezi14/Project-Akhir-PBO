namespace Sistem_Reservasi_Hotel.View
{
    partial class KelolaFasilitas
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
            btnTambahFasilitas1 = new Button();
            btnKembali = new Button();
            dataGridViewKelolaFasilitas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaFasilitas).BeginInit();
            SuspendLayout();
            // 
            // btnTambahFasilitas1
            // 
            btnTambahFasilitas1.BackColor = Color.FromArgb(241, 212, 58);
            btnTambahFasilitas1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahFasilitas1.ForeColor = Color.Transparent;
            btnTambahFasilitas1.Location = new Point(298, 633);
            btnTambahFasilitas1.Name = "btnTambahFasilitas1";
            btnTambahFasilitas1.Size = new Size(220, 80);
            btnTambahFasilitas1.TabIndex = 5;
            btnTambahFasilitas1.Text = "TAMBAH FASILITAS";
            btnTambahFasilitas1.UseVisualStyleBackColor = false;
            btnTambahFasilitas1.Click += btnTambahFasilitas1_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(242, 52, 86);
            btnKembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(611, 633);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(220, 80);
            btnKembali.TabIndex = 6;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridViewKelolaFasilitas
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewKelolaFasilitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKelolaFasilitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewKelolaFasilitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewKelolaFasilitas.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewKelolaFasilitas.BorderStyle = BorderStyle.None;
            dataGridViewKelolaFasilitas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKelolaFasilitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 52, 86);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 52, 86);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewKelolaFasilitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKelolaFasilitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(40, 0, 50, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewKelolaFasilitas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKelolaFasilitas.EnableHeadersVisualStyles = false;
            dataGridViewKelolaFasilitas.Location = new Point(1, 1);
            dataGridViewKelolaFasilitas.MultiSelect = false;
            dataGridViewKelolaFasilitas.Name = "dataGridViewKelolaFasilitas";
            dataGridViewKelolaFasilitas.ReadOnly = true;
            dataGridViewKelolaFasilitas.RowHeadersVisible = false;
            dataGridViewKelolaFasilitas.RowHeadersWidth = 51;
            dataGridViewKelolaFasilitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKelolaFasilitas.Size = new Size(1180, 600);
            dataGridViewKelolaFasilitas.TabIndex = 12;
            dataGridViewKelolaFasilitas.CellContentClick += dataGridViewKelolaFasilitas_CellContentClick;
            // 
            // KelolaFasilitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridViewKelolaFasilitas);
            Controls.Add(btnKembali);
            Controls.Add(btnTambahFasilitas1);
            Name = "KelolaFasilitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KelolaFasilitas";
            Load += KelolaFasilitas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaFasilitas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambahFasilitas1;
        private Button btnKembali;
        private DataGridView dataGridViewKelolaFasilitas;
    }
}
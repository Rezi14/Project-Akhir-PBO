namespace Sistem_Reservasi_Hotel.View
{
    partial class FormKelolaKamar
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
            btnTambahKamar1 = new Button();
            btnKembali = new Button();
            dataGridViewKelolaKamar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKamar).BeginInit();
            SuspendLayout();
            // 
            // btnTambahKamar1
            // 
            btnTambahKamar1.BackColor = Color.FromArgb(35, 178, 218);
            btnTambahKamar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahKamar1.ForeColor = Color.Transparent;
            btnTambahKamar1.Location = new Point(273, 630);
            btnTambahKamar1.Name = "btnTambahKamar1";
            btnTambahKamar1.Size = new Size(220, 80);
            btnTambahKamar1.TabIndex = 4;
            btnTambahKamar1.Text = "TAMBAH KAMAR";
            btnTambahKamar1.UseVisualStyleBackColor = false;
            btnTambahKamar1.Click += btnTambahKamar1_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(242, 52, 86);
            btnKembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(644, 630);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(220, 80);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridViewKelolaKamar
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewKelolaKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKelolaKamar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewKelolaKamar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewKelolaKamar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewKelolaKamar.BackgroundColor = Color.FromArgb(225, 225, 225);
            dataGridViewKelolaKamar.BorderStyle = BorderStyle.None;
            dataGridViewKelolaKamar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKelolaKamar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 212, 58);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewKelolaKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKelolaKamar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 225, 225);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(20, 0, 15, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 178, 218);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewKelolaKamar.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKelolaKamar.EnableHeadersVisualStyles = false;
            dataGridViewKelolaKamar.Location = new Point(1, 1);
            dataGridViewKelolaKamar.MultiSelect = false;
            dataGridViewKelolaKamar.Name = "dataGridViewKelolaKamar";
            dataGridViewKelolaKamar.ReadOnly = true;
            dataGridViewKelolaKamar.RowHeadersVisible = false;
            dataGridViewKelolaKamar.RowHeadersWidth = 51;
            dataGridViewKelolaKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKelolaKamar.Size = new Size(1180, 600);
            dataGridViewKelolaKamar.TabIndex = 13;
            dataGridViewKelolaKamar.CellContentClick += dataGridViewKelolaKamar_CellContentClick_1;
            // 
            // FormKelolaKamar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridViewKelolaKamar);
            Controls.Add(btnKembali);
            Controls.Add(btnTambahKamar1);
            Name = "FormKelolaKamar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelolaKamar";
            Load += FormKelolaKamar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKamar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambahKamar1;
        private Button btnKembali;
        private DataGridView dataGridViewKelolaKamar;
    }
}
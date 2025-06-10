namespace Sistem_Reservasi_Hotel.View
{
    partial class FormReservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservasi));
            textNamaTamu1 = new TextBox();
            textNomorIdentitas1 = new TextBox();
            cbNomorKamar1 = new ComboBox();
            textNomorKontak1 = new TextBox();
            dateTimeCheckIn1 = new DateTimePicker();
            dateTimeCheckOut1 = new DateTimePicker();
            checkStatusReservasi1 = new CheckBox();
            btnReservasi = new Button();
            btnBatal = new Button();
            checkedListBoxFasilitas = new CheckedListBox();
            SuspendLayout();
            // 
            // textNamaTamu1
            // 
            textNamaTamu1.Location = new Point(620, 295);
            textNamaTamu1.Name = "textNamaTamu1";
            textNamaTamu1.Size = new Size(212, 27);
            textNamaTamu1.TabIndex = 2;
            // 
            // textNomorIdentitas1
            // 
            textNomorIdentitas1.Location = new Point(620, 354);
            textNomorIdentitas1.Name = "textNomorIdentitas1";
            textNomorIdentitas1.Size = new Size(212, 27);
            textNomorIdentitas1.TabIndex = 3;
            // 
            // cbNomorKamar1
            // 
            cbNomorKamar1.FormattingEnabled = true;
            cbNomorKamar1.Location = new Point(620, 178);
            cbNomorKamar1.Name = "cbNomorKamar1";
            cbNomorKamar1.Size = new Size(212, 28);
            cbNomorKamar1.TabIndex = 4;
            cbNomorKamar1.SelectedIndexChanged += cbNomorKamar1_SelectedIndexChanged;
            // 
            // textNomorKontak1
            // 
            textNomorKontak1.Location = new Point(620, 414);
            textNomorKontak1.Name = "textNomorKontak1";
            textNomorKontak1.Size = new Size(212, 27);
            textNomorKontak1.TabIndex = 6;
            // 
            // dateTimeCheckIn1
            // 
            dateTimeCheckIn1.Location = new Point(620, 473);
            dateTimeCheckIn1.Name = "dateTimeCheckIn1";
            dateTimeCheckIn1.Size = new Size(250, 27);
            dateTimeCheckIn1.TabIndex = 7;
            // 
            // dateTimeCheckOut1
            // 
            dateTimeCheckOut1.Location = new Point(620, 533);
            dateTimeCheckOut1.Name = "dateTimeCheckOut1";
            dateTimeCheckOut1.Size = new Size(250, 27);
            dateTimeCheckOut1.TabIndex = 8;
            // 
            // checkStatusReservasi1
            // 
            checkStatusReservasi1.AutoSize = true;
            checkStatusReservasi1.BackColor = Color.Transparent;
            checkStatusReservasi1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkStatusReservasi1.Location = new Point(620, 591);
            checkStatusReservasi1.Name = "checkStatusReservasi1";
            checkStatusReservasi1.Size = new Size(66, 24);
            checkStatusReservasi1.TabIndex = 9;
            checkStatusReservasi1.Text = "Aktif";
            checkStatusReservasi1.UseVisualStyleBackColor = false;
            // 
            // btnReservasi
            // 
            btnReservasi.BackColor = Color.FromArgb(59, 74, 107);
            btnReservasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservasi.ForeColor = Color.Transparent;
            btnReservasi.Location = new Point(670, 635);
            btnReservasi.Name = "btnReservasi";
            btnReservasi.Size = new Size(200, 40);
            btnReservasi.TabIndex = 10;
            btnReservasi.Text = "RESERVASI";
            btnReservasi.UseVisualStyleBackColor = false;
            btnReservasi.Click += btnReservasi_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(59, 74, 107);
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.Transparent;
            btnBatal.Location = new Point(238, 336);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(220, 80);
            btnBatal.TabIndex = 11;
            btnBatal.Text = "CANCEL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // checkedListBoxFasilitas
            // 
            checkedListBoxFasilitas.FormattingEnabled = true;
            checkedListBoxFasilitas.Location = new Point(620, 234);
            checkedListBoxFasilitas.Name = "checkedListBoxFasilitas";
            checkedListBoxFasilitas.Size = new Size(212, 26);
            checkedListBoxFasilitas.TabIndex = 12;
            checkedListBoxFasilitas.SelectedIndexChanged += checkedListBoxFasilitas_SelectedIndexChanged;
            // 
            // FormReservasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(checkedListBoxFasilitas);
            Controls.Add(btnBatal);
            Controls.Add(btnReservasi);
            Controls.Add(checkStatusReservasi1);
            Controls.Add(dateTimeCheckOut1);
            Controls.Add(dateTimeCheckIn1);
            Controls.Add(textNomorKontak1);
            Controls.Add(cbNomorKamar1);
            Controls.Add(textNomorIdentitas1);
            Controls.Add(textNamaTamu1);
            DoubleBuffered = true;
            Name = "FormReservasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservasi";
            Load += FormReservasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textNamaTamu1;
        private TextBox textNomorIdentitas1;
        private ComboBox cbNomorKamar1;
        private TextBox textNomorKontak1;
        private DateTimePicker dateTimeCheckIn1;
        private DateTimePicker dateTimeCheckOut1;
        private CheckBox checkStatusReservasi1;
        private Button btnReservasi;
        private Button btnBatal;
        private CheckedListBox checkedListBoxFasilitas;
    }
}
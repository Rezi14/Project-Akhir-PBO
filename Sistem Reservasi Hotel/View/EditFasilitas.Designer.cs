namespace Sistem_Reservasi_Hotel.View
{
    partial class EditFasilitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFasilitas));
            btnSimpan = new Button();
            textDeskripsi2 = new TextBox();
            textBiayaTambahan2 = new TextBox();
            textNamaFasilitas2 = new TextBox();
            btnBatal = new Button();
            checkBoxStatusFasilitas = new CheckBox();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(241, 212, 58);
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Transparent;
            btnSimpan.Location = new Point(753, 539);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(220, 80);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // textDeskripsi2
            // 
            textDeskripsi2.Location = new Point(620, 415);
            textDeskripsi2.Multiline = true;
            textDeskripsi2.Name = "textDeskripsi2";
            textDeskripsi2.Size = new Size(190, 27);
            textDeskripsi2.TabIndex = 9;
            // 
            // textBiayaTambahan2
            // 
            textBiayaTambahan2.Location = new Point(620, 345);
            textBiayaTambahan2.Name = "textBiayaTambahan2";
            textBiayaTambahan2.Size = new Size(190, 27);
            textBiayaTambahan2.TabIndex = 8;
            // 
            // textNamaFasilitas2
            // 
            textNamaFasilitas2.Location = new Point(620, 270);
            textNamaFasilitas2.Name = "textNamaFasilitas2";
            textNamaFasilitas2.Size = new Size(190, 27);
            textNamaFasilitas2.TabIndex = 7;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(241, 212, 58);
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.Transparent;
            btnBatal.Location = new Point(234, 336);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(220, 80);
            btnBatal.TabIndex = 11;
            btnBatal.Text = "CANCEL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // checkBoxStatusFasilitas
            // 
            checkBoxStatusFasilitas.AutoSize = true;
            checkBoxStatusFasilitas.Location = new Point(620, 489);
            checkBoxStatusFasilitas.Name = "checkBoxStatusFasilitas";
            checkBoxStatusFasilitas.Size = new Size(86, 24);
            checkBoxStatusFasilitas.TabIndex = 12;
            checkBoxStatusFasilitas.Text = "Tersedia";
            checkBoxStatusFasilitas.UseVisualStyleBackColor = true;
            // 
            // EditFasilitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(checkBoxStatusFasilitas);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(textDeskripsi2);
            Controls.Add(textBiayaTambahan2);
            Controls.Add(textNamaFasilitas2);
            DoubleBuffered = true;
            Name = "EditFasilitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditFasilitas";
            Load += EditFasilitas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox textDeskripsi2;
        private TextBox textBiayaTambahan2;
        private TextBox textNamaFasilitas2;
        private Button btnBatal;
        private CheckBox checkBoxStatusFasilitas;
    }
}
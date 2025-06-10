namespace Sistem_Reservasi_Hotel.View
{
    partial class TambahFasilitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahFasilitas));
            textNamaFasilitas = new TextBox();
            textBiayaTambahan = new TextBox();
            textDeskripsi = new TextBox();
            btnTambahFasilitas1 = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // textNamaFasilitas
            // 
            textNamaFasilitas.Location = new Point(130, 295);
            textNamaFasilitas.Name = "textNamaFasilitas";
            textNamaFasilitas.Size = new Size(190, 27);
            textNamaFasilitas.TabIndex = 0;
            // 
            // textBiayaTambahan
            // 
            textBiayaTambahan.Location = new Point(130, 370);
            textBiayaTambahan.Name = "textBiayaTambahan";
            textBiayaTambahan.Size = new Size(190, 27);
            textBiayaTambahan.TabIndex = 1;
            // 
            // textDeskripsi
            // 
            textDeskripsi.Location = new Point(130, 436);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(190, 27);
            textDeskripsi.TabIndex = 2;
            // 
            // btnTambahFasilitas1
            // 
            btnTambahFasilitas1.BackColor = Color.FromArgb(241, 212, 58);
            btnTambahFasilitas1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahFasilitas1.ForeColor = Color.Transparent;
            btnTambahFasilitas1.Location = new Point(227, 511);
            btnTambahFasilitas1.Name = "btnTambahFasilitas1";
            btnTambahFasilitas1.Size = new Size(220, 80);
            btnTambahFasilitas1.TabIndex = 6;
            btnTambahFasilitas1.Text = "TAMBAH FASILITAS";
            btnTambahFasilitas1.UseVisualStyleBackColor = false;
            btnTambahFasilitas1.Click += btnTambahFasilitas2_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(241, 212, 58);
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.Transparent;
            btnBatal.Location = new Point(732, 340);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(220, 80);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "CANCEL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // TambahFasilitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnBatal);
            Controls.Add(btnTambahFasilitas1);
            Controls.Add(textDeskripsi);
            Controls.Add(textBiayaTambahan);
            Controls.Add(textNamaFasilitas);
            DoubleBuffered = true;
            Name = "TambahFasilitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahFasilitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNamaFasilitas;
        private TextBox textBiayaTambahan;
        private TextBox textDeskripsi;
        private Button btnTambahFasilitas1;
        private Button btnBatal;
    }
}
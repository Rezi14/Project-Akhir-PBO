namespace Sistem_Reservasi_Hotel.View
{
    partial class TambahKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahKamar));
            textNomorKamar1 = new TextBox();
            textDeskripsi1 = new TextBox();
            btnTambahKamar2 = new Button();
            btnBatal1 = new Button();
            cbStatusKamar = new CheckBox();
            comboBoxTipeKamar = new ComboBox();
            SuspendLayout();
            // 
            // textNomorKamar1
            // 
            textNomorKamar1.Location = new Point(130, 300);
            textNomorKamar1.Name = "textNomorKamar1";
            textNomorKamar1.Size = new Size(164, 27);
            textNomorKamar1.TabIndex = 0;
            // 
            // textDeskripsi1
            // 
            textDeskripsi1.Location = new Point(130, 516);
            textDeskripsi1.Multiline = true;
            textDeskripsi1.Name = "textDeskripsi1";
            textDeskripsi1.Size = new Size(164, 27);
            textDeskripsi1.TabIndex = 3;
            textDeskripsi1.TextChanged += textDeskripsi1_TextChanged;
            // 
            // btnTambahKamar2
            // 
            btnTambahKamar2.BackColor = Color.FromArgb(35, 178, 218);
            btnTambahKamar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahKamar2.ForeColor = Color.Transparent;
            btnTambahKamar2.Location = new Point(222, 559);
            btnTambahKamar2.Name = "btnTambahKamar2";
            btnTambahKamar2.Size = new Size(220, 80);
            btnTambahKamar2.TabIndex = 5;
            btnTambahKamar2.Text = "TAMBAH KAMAR";
            btnTambahKamar2.UseVisualStyleBackColor = false;
            btnTambahKamar2.Click += btnTambahKamar2_Click;
            // 
            // btnBatal1
            // 
            btnBatal1.BackColor = Color.FromArgb(35, 178, 218);
            btnBatal1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal1.ForeColor = Color.Transparent;
            btnBatal1.Location = new Point(718, 425);
            btnBatal1.Name = "btnBatal1";
            btnBatal1.Size = new Size(220, 80);
            btnBatal1.TabIndex = 6;
            btnBatal1.Text = "CANCEL";
            btnBatal1.UseVisualStyleBackColor = false;
            btnBatal1.Click += btnBatal_Click;
            // 
            // cbStatusKamar
            // 
            cbStatusKamar.AutoSize = true;
            cbStatusKamar.BackColor = Color.Transparent;
            cbStatusKamar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbStatusKamar.Location = new Point(130, 444);
            cbStatusKamar.Name = "cbStatusKamar";
            cbStatusKamar.Size = new Size(111, 27);
            cbStatusKamar.TabIndex = 7;
            cbStatusKamar.Text = "TERSEDIA";
            cbStatusKamar.UseVisualStyleBackColor = false;
            // 
            // comboBoxTipeKamar
            // 
            comboBoxTipeKamar.FormattingEnabled = true;
            comboBoxTipeKamar.Location = new Point(130, 370);
            comboBoxTipeKamar.Name = "comboBoxTipeKamar";
            comboBoxTipeKamar.Size = new Size(164, 28);
            comboBoxTipeKamar.TabIndex = 8;
            // 
            // TambahKamar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(comboBoxTipeKamar);
            Controls.Add(cbStatusKamar);
            Controls.Add(btnBatal1);
            Controls.Add(btnTambahKamar2);
            Controls.Add(textDeskripsi1);
            Controls.Add(textNomorKamar1);
            DoubleBuffered = true;
            Name = "TambahKamar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahKamar";
            Load += TambahKamar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNomorKamar1;
        private TextBox textDeskripsi1;
        private Button btnTambahKamar2;
        private Button btnBatal1;
        private CheckBox cbStatusKamar;
        private ComboBox comboBoxTipeKamar;
    }
}
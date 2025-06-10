namespace Sistem_Reservasi_Hotel.View
{
    partial class EditKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditKamar));
            textNomorKamar2 = new TextBox();
            textDeskripsi2 = new TextBox();
            comboBoxTipeKamar2 = new ComboBox();
            cbStatusKamar2 = new CheckBox();
            btnSimpan = new Button();
            btnBatal2 = new Button();
            SuspendLayout();
            // 
            // textNomorKamar2
            // 
            textNomorKamar2.Location = new Point(619, 289);
            textNomorKamar2.Name = "textNomorKamar2";
            textNomorKamar2.Size = new Size(164, 27);
            textNomorKamar2.TabIndex = 1;
            // 
            // textDeskripsi2
            // 
            textDeskripsi2.Location = new Point(619, 509);
            textDeskripsi2.Multiline = true;
            textDeskripsi2.Name = "textDeskripsi2";
            textDeskripsi2.Size = new Size(164, 27);
            textDeskripsi2.TabIndex = 2;
            // 
            // comboBoxTipeKamar2
            // 
            comboBoxTipeKamar2.FormattingEnabled = true;
            comboBoxTipeKamar2.Location = new Point(619, 359);
            comboBoxTipeKamar2.Name = "comboBoxTipeKamar2";
            comboBoxTipeKamar2.Size = new Size(164, 28);
            comboBoxTipeKamar2.TabIndex = 9;
            // 
            // cbStatusKamar2
            // 
            cbStatusKamar2.AutoSize = true;
            cbStatusKamar2.BackColor = Color.Transparent;
            cbStatusKamar2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbStatusKamar2.Location = new Point(619, 436);
            cbStatusKamar2.Name = "cbStatusKamar2";
            cbStatusKamar2.Size = new Size(111, 27);
            cbStatusKamar2.TabIndex = 10;
            cbStatusKamar2.Text = "TERSEDIA";
            cbStatusKamar2.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(35, 178, 218);
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Transparent;
            btnSimpan.Location = new Point(730, 552);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(220, 80);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal2
            // 
            btnBatal2.BackColor = Color.FromArgb(35, 178, 218);
            btnBatal2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal2.ForeColor = Color.Transparent;
            btnBatal2.Location = new Point(230, 359);
            btnBatal2.Name = "btnBatal2";
            btnBatal2.Size = new Size(220, 80);
            btnBatal2.TabIndex = 12;
            btnBatal2.Text = "CANCEL";
            btnBatal2.UseVisualStyleBackColor = false;
            btnBatal2.Click += btnBatal2_Click;
            // 
            // EditKamar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnBatal2);
            Controls.Add(btnSimpan);
            Controls.Add(cbStatusKamar2);
            Controls.Add(comboBoxTipeKamar2);
            Controls.Add(textDeskripsi2);
            Controls.Add(textNomorKamar2);
            DoubleBuffered = true;
            Name = "EditKamar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditKamar";
            Load += EditKamar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNomorKamar2;
        private TextBox textDeskripsi2;
        private ComboBox comboBoxTipeKamar2;
        private CheckBox cbStatusKamar2;
        private Button btnSimpan;
        private Button btnBatal2;
    }
}
namespace Sistem_Reservasi_Hotel.View
{
    partial class FormDaftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftar));
            textusername2 = new TextBox();
            textpassword2 = new TextBox();
            textkonfirmasi = new TextBox();
            btndaftar2 = new Button();
            btnlogin2 = new Button();
            SuspendLayout();
            // 
            // textusername2
            // 
            textusername2.Location = new Point(167, 332);
            textusername2.Name = "textusername2";
            textusername2.Size = new Size(291, 27);
            textusername2.TabIndex = 1;
            // 
            // textpassword2
            // 
            textpassword2.Location = new Point(167, 402);
            textpassword2.Name = "textpassword2";
            textpassword2.Size = new Size(291, 27);
            textpassword2.TabIndex = 2;
            // 
            // textkonfirmasi
            // 
            textkonfirmasi.Location = new Point(167, 473);
            textkonfirmasi.Name = "textkonfirmasi";
            textkonfirmasi.Size = new Size(291, 27);
            textkonfirmasi.TabIndex = 3;
            // 
            // btndaftar2
            // 
            btndaftar2.BackColor = Color.FromArgb(242, 52, 86);
            btndaftar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftar2.ForeColor = Color.Transparent;
            btndaftar2.Location = new Point(209, 524);
            btndaftar2.Name = "btndaftar2";
            btndaftar2.Size = new Size(216, 61);
            btndaftar2.TabIndex = 4;
            btndaftar2.Text = "DAFTAR";
            btndaftar2.UseVisualStyleBackColor = false;
            btndaftar2.Click += btndaftar2_Click;
            // 
            // btnlogin2
            // 
            btnlogin2.BackColor = Color.FromArgb(242, 52, 86);
            btnlogin2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin2.ForeColor = Color.Transparent;
            btnlogin2.Location = new Point(728, 421);
            btnlogin2.Name = "btnlogin2";
            btnlogin2.Size = new Size(216, 61);
            btnlogin2.TabIndex = 5;
            btnlogin2.Text = "LOGIN";
            btnlogin2.UseVisualStyleBackColor = false;
            btnlogin2.Click += btnlogin2_Click;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(btnlogin2);
            Controls.Add(btndaftar2);
            Controls.Add(textkonfirmasi);
            Controls.Add(textpassword2);
            Controls.Add(textusername2);
            DoubleBuffered = true;
            Name = "FormDaftar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDaftar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textusername2;
        private TextBox textpassword2;
        private TextBox textkonfirmasi;
        private Button btndaftar2;
        private Button btnlogin2;
    }
}
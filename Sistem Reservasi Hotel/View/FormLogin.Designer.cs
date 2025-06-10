namespace Sistem_Reservasi_Hotel.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textusername1 = new TextBox();
            textpassword1 = new TextBox();
            btnlogin1 = new Button();
            btndaftar1 = new Button();
            SuspendLayout();
            // 
            // textusername1
            // 
            textusername1.Location = new Point(660, 334);
            textusername1.Name = "textusername1";
            textusername1.Size = new Size(291, 27);
            textusername1.TabIndex = 0;
            // 
            // textpassword1
            // 
            textpassword1.Location = new Point(660, 402);
            textpassword1.Name = "textpassword1";
            textpassword1.Size = new Size(291, 27);
            textpassword1.TabIndex = 1;
            // 
            // btnlogin1
            // 
            btnlogin1.BackColor = Color.FromArgb(242, 52, 86);
            btnlogin1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin1.ForeColor = Color.Transparent;
            btnlogin1.Location = new Point(735, 464);
            btnlogin1.Name = "btnlogin1";
            btnlogin1.Size = new Size(216, 61);
            btnlogin1.TabIndex = 2;
            btnlogin1.Text = "LOGIN";
            btnlogin1.UseVisualStyleBackColor = false;
            btnlogin1.Click += btnlogin1_Click;
            // 
            // btndaftar1
            // 
            btndaftar1.BackColor = Color.FromArgb(242, 52, 86);
            btndaftar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftar1.ForeColor = Color.Transparent;
            btndaftar1.Location = new Point(230, 424);
            btndaftar1.Name = "btndaftar1";
            btndaftar1.Size = new Size(216, 61);
            btndaftar1.TabIndex = 3;
            btndaftar1.Text = "DAFTAR";
            btndaftar1.UseVisualStyleBackColor = false;
            btndaftar1.Click += btndaftar1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(btndaftar1);
            Controls.Add(btnlogin1);
            Controls.Add(textpassword1);
            Controls.Add(textusername1);
            DoubleBuffered = true;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textusername1;
        private TextBox textpassword1;
        private Button btnlogin1;
        private Button btndaftar1;
    }
}
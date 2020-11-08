namespace SunCheats
{
    partial class destektalebi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaGradientButton7 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaGradientButton7
            // 
            this.gunaGradientButton7.Animated = true;
            this.gunaGradientButton7.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton7.AnimationSpeed = 0.03F;
            this.gunaGradientButton7.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton7.BaseColor2 = System.Drawing.Color.Green;
            this.gunaGradientButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton7.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton7.Image = null;
            this.gunaGradientButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton7.Location = new System.Drawing.Point(261, 240);
            this.gunaGradientButton7.Name = "gunaGradientButton7";
            this.gunaGradientButton7.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.gunaGradientButton7.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton7.OnHoverImage = null;
            this.gunaGradientButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.Size = new System.Drawing.Size(267, 43);
            this.gunaGradientButton7.TabIndex = 16;
            this.gunaGradientButton7.Text = "Bildir";
            this.gunaGradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton7.Click += new System.EventHandler(this.gunaGradientButton7_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Location = new System.Drawing.Point(87, 74);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(632, 32);
            this.gunaTextBox1.TabIndex = 17;
            this.gunaTextBox1.Text = "Problemin";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(1, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 49);
            this.label2.TabIndex = 19;
            this.label2.Text = "Problemin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(794, 49);
            this.label3.TabIndex = 21;
            this.label3.Text = "Discord Adresin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(12, 118);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(776, 10);
            this.gunaSeparator2.TabIndex = 23;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.ForeColor = System.Drawing.Color.White;
            this.gunaTextBox2.Location = new System.Drawing.Point(87, 180);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(632, 32);
            this.gunaTextBox2.TabIndex = 24;
            this.gunaTextBox2.Text = "Discord Adresin";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // destektalebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaGradientButton7);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "destektalebi";
            this.Size = new System.Drawing.Size(800, 320);
            this.Load += new System.EventHandler(this.destektalebi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton7;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

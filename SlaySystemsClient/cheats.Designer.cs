namespace SlaySystemsClient
{
    partial class cheats
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
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradientButton7 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton8 = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 209);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(794, 10);
            this.gunaSeparator1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 82);
            this.label2.TabIndex = 14;
            this.label2.Text = "Açıklama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gunaGradientButton7.Location = new System.Drawing.Point(3, 162);
            this.gunaGradientButton7.Name = "gunaGradientButton7";
            this.gunaGradientButton7.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.gunaGradientButton7.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton7.OnHoverImage = null;
            this.gunaGradientButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.Size = new System.Drawing.Size(267, 43);
            this.gunaGradientButton7.TabIndex = 15;
            this.gunaGradientButton7.Text = "Aktif Et";
            this.gunaGradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton7.Click += new System.EventHandler(this.GunaGradientButton7_Click);
            // 
            // gunaGradientButton8
            // 
            this.gunaGradientButton8.Animated = true;
            this.gunaGradientButton8.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton8.AnimationSpeed = 0.03F;
            this.gunaGradientButton8.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton8.BaseColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton8.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton8.Image = null;
            this.gunaGradientButton8.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton8.Location = new System.Drawing.Point(530, 162);
            this.gunaGradientButton8.Name = "gunaGradientButton8";
            this.gunaGradientButton8.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.gunaGradientButton8.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton8.OnHoverImage = null;
            this.gunaGradientButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton8.Size = new System.Drawing.Size(267, 43);
            this.gunaGradientButton8.TabIndex = 16;
            this.gunaGradientButton8.Text = "Kapat";
            this.gunaGradientButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton8.Click += new System.EventHandler(this.GunaGradientButton8_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(276, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "Durum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(794, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Açıklama";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Sekmeme"});
            this.gunaComboBox1.Location = new System.Drawing.Point(3, 225);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(794, 26);
            this.gunaComboBox1.TabIndex = 19;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.GunaComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(3, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(794, 66);
            this.label5.TabIndex = 20;
            this.label5.Text = "Üstteki menüden hile seçiniz.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cheats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaGradientButton8);
            this.Controls.Add(this.gunaGradientButton7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaSeparator1);
            this.Name = "cheats";
            this.Size = new System.Drawing.Size(800, 320);
            this.Load += new System.EventHandler(this.Cheats_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton7;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}

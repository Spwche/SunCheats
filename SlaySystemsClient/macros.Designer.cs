namespace SlaySystemsClient
{
    partial class macros
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
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric2 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaGradient2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradientButton3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaVSeparator2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaNumeric2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaVSeparator1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaSeparator1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaNumeric1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaTrackBar1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(3, 3);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(794, 168);
            this.gunaGradient2Panel1.TabIndex = 2;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GunaGradient2Panel1_Paint);
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.Animated = true;
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Green;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = null;
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(200, 95);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(160, 48);
            this.gunaGradientButton3.TabIndex = 10;
            this.gunaGradientButton3.Text = "AutoRod Aktif";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton3.Click += new System.EventHandler(this.GunaGradientButton3_Click);
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator2.Location = new System.Drawing.Point(184, 95);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(10, 48);
            this.gunaVSeparator2.TabIndex = 9;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(103, 95);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(75, 15);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Olta Slotu";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaNumeric2
            // 
            this.gunaNumeric2.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric2.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaNumeric2.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric2.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric2.Location = new System.Drawing.Point(103, 113);
            this.gunaNumeric2.Maximum = ((long)(9999999));
            this.gunaNumeric2.Minimum = ((long)(1));
            this.gunaNumeric2.Name = "gunaNumeric2";
            this.gunaNumeric2.Size = new System.Drawing.Size(75, 30);
            this.gunaNumeric2.TabIndex = 8;
            this.gunaNumeric2.Text = "gunaNumeric2";
            this.gunaNumeric2.Value = ((long)(2));
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(87, 95);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 48);
            this.gunaVSeparator1.TabIndex = 6;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(6, 65);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(785, 10);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(6, 95);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Kılıç Slotu";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.Location = new System.Drawing.Point(6, 113);
            this.gunaNumeric1.Maximum = ((long)(9999999));
            this.gunaNumeric1.Minimum = ((long)(1));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Size = new System.Drawing.Size(75, 30);
            this.gunaNumeric1.TabIndex = 4;
            this.gunaNumeric1.Text = "gunaNumeric1";
            this.gunaNumeric1.Value = ((long)(1));
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(791, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Delay";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Location = new System.Drawing.Point(6, 9);
            this.gunaTrackBar1.Maximum = 1000;
            this.gunaTrackBar1.Minimum = 1;
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(785, 23);
            this.gunaTrackBar1.TabIndex = 0;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.Magenta;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.Purple;
            this.gunaTrackBar1.Value = 100;
            this.gunaTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GunaTrackBar1_Scroll);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Purple;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = null;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(3, 177);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(794, 52);
            this.gunaGradientButton2.TabIndex = 5;
            this.gunaGradientButton2.Text = "AutoRod Tuş Seç";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.Click += new System.EventHandler(this.GunaGradientButton2_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel4.Location = new System.Drawing.Point(3, 232);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(794, 88);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "FNF - Çakmak makrosu olarakta kullanabilirsiniz.";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel4.Click += new System.EventHandler(this.GunaLabel4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // macros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaGradientButton2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Name = "macros";
            this.Size = new System.Drawing.Size(800, 320);
            this.Load += new System.EventHandler(this.Macros_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private System.Windows.Forms.Timer timer2;
    }
}

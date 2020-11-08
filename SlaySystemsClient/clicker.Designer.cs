namespace SlaySystemsClient
{
    partial class clicker
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
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradientButton5 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaTrackBar4 = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTrackBar2 = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.jittertest = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGradient2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.Location = new System.Drawing.Point(3, 9);
            this.gunaTrackBar1.Minimum = 1;
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(224, 23);
            this.gunaTrackBar1.TabIndex = 0;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.Magenta;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.Purple;
            this.gunaTrackBar1.Value = 10;
            this.gunaTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GunaTrackBar1_Scroll);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradientButton2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaTrackBar1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(286, 132);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(230, 185);
            this.gunaGradient2Panel1.TabIndex = 1;
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
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = null;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(3, 146);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(224, 27);
            this.gunaGradientButton2.TabIndex = 5;
            this.gunaGradientButton2.Text = "Sağ Click Tuş Seç";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.Click += new System.EventHandler(this.GunaGradientButton2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(224, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Sağ Click CPS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaPanel1.Controls.Add(this.gunaGradientButton5);
            this.gunaPanel1.Controls.Add(this.gunaGradientButton4);
            this.gunaPanel1.Controls.Add(this.gunaGradientButton3);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(794, 77);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaGradientButton5
            // 
            this.gunaGradientButton5.Animated = true;
            this.gunaGradientButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton5.AnimationSpeed = 0.03F;
            this.gunaGradientButton5.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton5.BaseColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton5.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.Image = null;
            this.gunaGradientButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton5.Location = new System.Drawing.Point(338, 17);
            this.gunaGradientButton5.Name = "gunaGradientButton5";
            this.gunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.Green;
            this.gunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.OnHoverImage = null;
            this.gunaGradientButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton5.TabIndex = 2;
            this.gunaGradientButton5.Text = "Jitter Kapalı";
            this.gunaGradientButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton5.Click += new System.EventHandler(this.GunaGradientButton5_Click);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.Animated = true;
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = null;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(172, 17);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.Green;
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton4.TabIndex = 1;
            this.gunaGradientButton4.Text = "Sağ Clicker Kapalı";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton4.Click += new System.EventHandler(this.GunaGradientButton4_Click);
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.Animated = true;
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = null;
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(6, 17);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.Green;
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton3.TabIndex = 0;
            this.gunaGradientButton3.Text = "Sol Clicker Kapalı";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton3.Click += new System.EventHandler(this.GunaGradientButton3_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 100);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(776, 10);
            this.gunaSeparator1.TabIndex = 7;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel4);
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel2.Controls.Add(this.pictureBox1);
            this.gunaGradient2Panel2.Controls.Add(this.gunaTrackBar4);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(567, 132);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(230, 185);
            this.gunaGradient2Panel2.TabIndex = 6;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(3, 35);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(224, 15);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Jitter";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.gunaLabel3.Location = new System.Drawing.Point(8, 113);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(213, 15);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Test Alanı";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel3.MouseEnter += new System.EventHandler(this.GunaLabel3_MouseEnter);
            this.gunaLabel3.MouseLeave += new System.EventHandler(this.GunaLabel3_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 114);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // gunaTrackBar4
            // 
            this.gunaTrackBar4.Location = new System.Drawing.Point(3, 9);
            this.gunaTrackBar4.Minimum = 1;
            this.gunaTrackBar4.Name = "gunaTrackBar4";
            this.gunaTrackBar4.Size = new System.Drawing.Size(224, 23);
            this.gunaTrackBar4.TabIndex = 0;
            this.gunaTrackBar4.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaTrackBar4.TrackHoverColor = System.Drawing.Color.Magenta;
            this.gunaTrackBar4.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTrackBar4.TrackPressedColor = System.Drawing.Color.Purple;
            this.gunaTrackBar4.Value = 10;
            this.gunaTrackBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GunaTrackBar4_Scroll);
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.gunaGradientButton1);
            this.gunaGradient2Panel3.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel3.Controls.Add(this.gunaTrackBar2);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(3, 132);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(230, 185);
            this.gunaGradient2Panel3.TabIndex = 6;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Purple;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(3, 146);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(224, 27);
            this.gunaGradientButton1.TabIndex = 5;
            this.gunaGradientButton1.Text = "Sol Click Tuş Seç";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.GunaGradientButton1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(3, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(224, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Sol Click CPS";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaTrackBar2
            // 
            this.gunaTrackBar2.Location = new System.Drawing.Point(3, 9);
            this.gunaTrackBar2.Minimum = 1;
            this.gunaTrackBar2.Name = "gunaTrackBar2";
            this.gunaTrackBar2.Size = new System.Drawing.Size(224, 23);
            this.gunaTrackBar2.TabIndex = 0;
            this.gunaTrackBar2.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaTrackBar2.TrackHoverColor = System.Drawing.Color.Magenta;
            this.gunaTrackBar2.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaTrackBar2.TrackPressedColor = System.Drawing.Color.Purple;
            this.gunaTrackBar2.Value = 10;
            this.gunaTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GunaTrackBar2_Scroll_1);
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaVSeparator1.Location = new System.Drawing.Point(239, 132);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(41, 185);
            this.gunaVSeparator1.TabIndex = 8;
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaVSeparator2.Location = new System.Drawing.Point(519, 132);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(45, 182);
            this.gunaVSeparator2.TabIndex = 9;
            // 
            // jittertest
            // 
            this.jittertest.Enabled = true;
            this.jittertest.Tick += new System.EventHandler(this.Jittertest_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.gunaVSeparator2);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Name = "clicker";
            this.Size = new System.Drawing.Size(800, 320);
            this.Load += new System.EventHandler(this.Clicker_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaGradient2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton5;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar4;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTrackBar gunaTrackBar2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Timer jittertest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

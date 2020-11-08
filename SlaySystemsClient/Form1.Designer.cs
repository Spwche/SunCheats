namespace SlaySystemsClient
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.cheats1 = new SlaySystemsClient.cheats();
            this.macros1 = new SlaySystemsClient.macros();
            this.clicker1 = new SlaySystemsClient.clicker();
            this.regedit1 = new SlaySystemsClient.regedit();
            this.destektalebi1 = new SunCheats.destektalebi();
            this.gunaGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaGradientPanel2;
            // 
            // gunaGradientPanel2
            // 
            resources.ApplyResources(this.gunaGradientPanel2, "gunaGradientPanel2");
            this.gunaGradientPanel2.Controls.Add(this.gunaButton6);
            this.gunaGradientPanel2.Controls.Add(this.gunaButton5);
            this.gunaGradientPanel2.Controls.Add(this.gunaButton4);
            this.gunaGradientPanel2.Controls.Add(this.gunaButton3);
            this.gunaGradientPanel2.Controls.Add(this.gunaButton2);
            this.gunaGradientPanel2.Controls.Add(this.pictureBox1);
            this.gunaGradientPanel2.Controls.Add(this.gunaButton1);
            this.gunaGradientPanel2.Controls.Add(this.gunaGradientPanel1);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Click += new System.EventHandler(this.GunaGradientPanel2_Click);
            // 
            // gunaButton6
            // 
            resources.ApplyResources(this.gunaButton6, "gunaButton6");
            this.gunaButton6.Animated = true;
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = null;
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Red;
            this.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // gunaButton5
            // 
            resources.ApplyResources(this.gunaButton5, "gunaButton5");
            this.gunaButton5.Animated = true;
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Magenta;
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton4
            // 
            resources.ApplyResources(this.gunaButton4, "gunaButton4");
            this.gunaButton4.Animated = true;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::SunCheats.Properties.Resources.x_07_512;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Magenta;
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.GunaButton4_Click);
            // 
            // gunaButton3
            // 
            resources.ApplyResources(this.gunaButton3, "gunaButton3");
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::SunCheats.Properties.Resources.machine_learning_icon_10;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Magenta;
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.GunaButton3_Click);
            // 
            // gunaButton2
            // 
            resources.ApplyResources(this.gunaButton2, "gunaButton2");
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::SunCheats.Properties.Resources.cancel;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Red;
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.GunaButton2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SunCheats.Properties.Resources.dsfsdfsdfsdfsdfsdfsdfsdfsd;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // gunaButton1
            // 
            resources.ApplyResources(this.gunaButton1, "gunaButton1");
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::SunCheats.Properties.Resources._99162;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Magenta;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // gunaGradientPanel1
            // 
            resources.ApplyResources(this.gunaGradientPanel1, "gunaGradientPanel1");
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Magenta;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Purple;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.pictureBox1;
            // 
            // gunaSeparator1
            // 
            resources.ApplyResources(this.gunaSeparator1, "gunaSeparator1");
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaSeparator1.Name = "gunaSeparator1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cheats1
            // 
            resources.ApplyResources(this.cheats1, "cheats1");
            this.cheats1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cheats1.Name = "cheats1";
            this.cheats1.Load += new System.EventHandler(this.cheats1_Load);
            // 
            // macros1
            // 
            resources.ApplyResources(this.macros1, "macros1");
            this.macros1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.macros1.Name = "macros1";
            this.macros1.Load += new System.EventHandler(this.Macros1_Load);
            // 
            // clicker1
            // 
            resources.ApplyResources(this.clicker1, "clicker1");
            this.clicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clicker1.Name = "clicker1";
            this.clicker1.Load += new System.EventHandler(this.Clicker1_Load);
            // 
            // regedit1
            // 
            resources.ApplyResources(this.regedit1, "regedit1");
            this.regedit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.regedit1.Name = "regedit1";
            // 
            // destektalebi1
            // 
            resources.ApplyResources(this.destektalebi1, "destektalebi1");
            this.destektalebi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.destektalebi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.destektalebi1.Name = "destektalebi1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.cheats1);
            this.Controls.Add(this.macros1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.clicker1);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.regedit1);
            this.Controls.Add(this.destektalebi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private clicker clicker1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private macros macros1;
        private cheats cheats1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private regedit regedit1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private SunCheats.destektalebi destektalebi1;
    }
}


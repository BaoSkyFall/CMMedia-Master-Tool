namespace CMMedia_Master_Tool
{
     partial class Form1
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_right = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_management = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_rocket = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_left.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.White;
            this.panel_right.Controls.Add(this.pictureBox1);
            this.panel_right.Controls.Add(this.txt_user);
            this.panel_right.Controls.Add(this.btn_login);
            this.panel_right.Controls.Add(this.label2);
            this.panel_right.Controls.Add(this.bunifuMaterialTextbox2);
            this.panel_right.Controls.Add(this.label1);
            this.panel_right.Controls.Add(this.txt_password);
            this.bunifuTransition2.SetDecoration(this.panel_right, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_right, BunifuAnimatorNS.DecorationType.None);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_right.Location = new System.Drawing.Point(427, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(411, 464);
            this.panel_right.TabIndex = 7;
            this.panel_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_right_Paint);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txt_user
            // 
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.txt_user, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.txt_user, BunifuAnimatorNS.DecorationType.None);
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.txt_user.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.txt_user.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.txt_user.LineThickness = 4;
            this.txt_user.Location = new System.Drawing.Point(23, 139);
            this.txt_user.Margin = new System.Windows.Forms.Padding(10, 16, 10, 16);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(370, 60);
            this.txt_user.TabIndex = 14;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user.OnValueChanged += new System.EventHandler(this.txt_user_OnValueChanged);
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 15;
            this.btn_login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btn_login, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_login, BunifuAnimatorNS.DecorationType.None);
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btn_login.Location = new System.Drawing.Point(23, 333);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 41);
            this.btn_login.TabIndex = 11;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(21, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = true;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(37, 518);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(601, 91);
            this.bunifuMaterialTextbox2.TabIndex = 9;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.txt_password, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.txt_password, BunifuAnimatorNS.DecorationType.None);
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = false;
            this.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.txt_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.txt_password.LineThickness = 4;
            this.txt_password.Location = new System.Drawing.Point(24, 264);
            this.txt_password.Margin = new System.Windows.Forms.Padding(10, 16, 10, 16);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(370, 60);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.OnValueChanged += new System.EventHandler(this.txt_password_OnValueChanged);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.panel_left.Controls.Add(this.panel_title);
            this.panel_left.Controls.Add(this.pic_rocket);
            this.bunifuTransition2.SetDecoration(this.panel_left, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_left, BunifuAnimatorNS.DecorationType.None);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(427, 464);
            this.panel_left.TabIndex = 0;
            this.panel_left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_left_Paint);
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.lbl_management);
            this.panel_title.Controls.Add(this.pictureBox2);
            this.bunifuTransition2.SetDecoration(this.panel_title, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_title, BunifuAnimatorNS.DecorationType.None);
            this.panel_title.Location = new System.Drawing.Point(24, 171);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(386, 108);
            this.panel_title.TabIndex = 14;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            // 
            // lbl_management
            // 
            this.lbl_management.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_management, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_management, BunifuAnimatorNS.DecorationType.None);
            this.lbl_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbl_management.Location = new System.Drawing.Point(94, 30);
            this.lbl_management.Name = "lbl_management";
            this.lbl_management.Size = new System.Drawing.Size(277, 55);
            this.lbl_management.TabIndex = 12;
            this.lbl_management.Text = "Master Tool";
            this.lbl_management.Click += new System.EventHandler(this.lbl_management_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_rocket
            // 
            this.bunifuTransition1.SetDecoration(this.pic_rocket, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pic_rocket, BunifuAnimatorNS.DecorationType.None);
            this.pic_rocket.Image = global::CMMedia_Master_Tool.Properties.Resources.rocket;
            this.pic_rocket.Location = new System.Drawing.Point(105, 181);
            this.pic_rocket.Name = "pic_rocket";
            this.pic_rocket.Size = new System.Drawing.Size(206, 98);
            this.pic_rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_rocket.TabIndex = 0;
            this.pic_rocket.TabStop = false;
            this.pic_rocket.Visible = false;
            this.pic_rocket.Click += new System.EventHandler(this.pic_rocket_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 20;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuTransition2.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(808, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.Interval = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "Please check your input valid";
            this.notifyIcon1.BalloonTipTitle = "Error when add new Product!";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // notifyIcon3
            // 
            this.notifyIcon3.Text = "notifyIcon3";
            this.notifyIcon3.Visible = true;
            this.notifyIcon3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon3_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(840, 464);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.btn_close);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel_right;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lbl_management;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_rocket;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.NotifyIcon notifyIcon3;
    }
}


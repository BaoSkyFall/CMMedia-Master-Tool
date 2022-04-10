namespace CMMedia_Master_Tool
{
    partial class CheckVia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckVia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnCheck = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 234);
            this.panel1.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(12, 3);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(755, 42);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Nhập chuỗi định dạng UID | Pass | 2fa | mail | pass mail";
            // 
            // btnCheck
            // 
            this.btnCheck.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.BorderRadius = 0;
            this.btnCheck.ButtonText = "Check";
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheck.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheck.Iconimage = null;
            this.btnCheck.Iconimage_right = null;
            this.btnCheck.Iconimage_right_Selected = null;
            this.btnCheck.Iconimage_Selected = null;
            this.btnCheck.IconMarginLeft = 0;
            this.btnCheck.IconMarginRight = 0;
            this.btnCheck.IconRightVisible = true;
            this.btnCheck.IconRightZoom = 0D;
            this.btnCheck.IconVisible = true;
            this.btnCheck.IconZoom = 90D;
            this.btnCheck.IsTab = false;
            this.btnCheck.Location = new System.Drawing.Point(773, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btnCheck.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(32)))));
            this.btnCheck.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheck.selected = false;
            this.btnCheck.Size = new System.Drawing.Size(61, 48);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Textcolor = System.Drawing.Color.White;
            this.btnCheck.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CheckVia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CheckVia";
            this.Size = new System.Drawing.Size(992, 518);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheck;
    }
}

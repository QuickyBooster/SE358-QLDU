namespace SchoolManagement
{
    partial class AddNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudent));
            this.Sidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParents = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_AddAvatar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Sidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BorderRadius = 18;
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.btnParents);
            this.Sidebar.Controls.Add(this.btnPersonal);
            this.Sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.Sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.Sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Sidebar.Location = new System.Drawing.Point(1, 106);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(226, 595);
            this.Sidebar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // btnParents
            // 
            this.btnParents.Animated = true;
            this.btnParents.AnimatedGIF = true;
            this.btnParents.BackColor = System.Drawing.Color.Transparent;
            this.btnParents.BorderRadius = 15;
            this.btnParents.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.family;
            this.btnParents.CustomImages.Image = global::SchoolManagement.Properties.Resources.family;
            this.btnParents.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParents.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnParents.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnParents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParents.FillColor = System.Drawing.Color.Transparent;
            this.btnParents.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnParents.ForeColor = System.Drawing.Color.DimGray;
            this.btnParents.HoverState.FillColor = System.Drawing.Color.White;
            this.btnParents.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnParents.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.btnParents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParents.Location = new System.Drawing.Point(0, 102);
            this.btnParents.Margin = new System.Windows.Forms.Padding(2);
            this.btnParents.Name = "btnParents";
            this.btnParents.Size = new System.Drawing.Size(221, 42);
            this.btnParents.TabIndex = 3;
            this.btnParents.Text = "Parents";
            this.btnParents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParents.TextOffset = new System.Drawing.Point(77, 0);
            this.btnParents.Click += new System.EventHandler(this.btnParents_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Animated = true;
            this.btnPersonal.AnimatedGIF = true;
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BorderRadius = 15;
            this.btnPersonal.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.iconuser;
            this.btnPersonal.CustomImages.Image = global::SchoolManagement.Properties.Resources.iconuser;
            this.btnPersonal.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersonal.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnPersonal.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPersonal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersonal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersonal.FillColor = System.Drawing.Color.Transparent;
            this.btnPersonal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnPersonal.ForeColor = System.Drawing.Color.DimGray;
            this.btnPersonal.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPersonal.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPersonal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.btnPersonal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersonal.Location = new System.Drawing.Point(0, 49);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(221, 42);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersonal.TextOffset = new System.Drawing.Point(77, 0);
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 350;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox4);
            this.guna2Panel1.Controls.Add(this.btn_AddAvatar);
            this.guna2Panel1.Controls.Add(this.picAvatar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 102);
            this.guna2Panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 201;
            this.label2.Text = "Personal information";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox2.Location = new System.Drawing.Point(911, 13);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 31);
            this.guna2ControlBox2.TabIndex = 200;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.BorderRadius = 10;
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox4.Location = new System.Drawing.Point(954, 13);
            this.guna2ControlBox4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(35, 31);
            this.guna2ControlBox4.TabIndex = 199;
            // 
            // btn_AddAvatar
            // 
            this.btn_AddAvatar.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddAvatar.BorderRadius = 15;
            this.btn_AddAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddAvatar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btn_AddAvatar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btn_AddAvatar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAvatar.ForeColor = System.Drawing.Color.White;
            this.btn_AddAvatar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_AddAvatar.Location = new System.Drawing.Point(139, 33);
            this.btn_AddAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddAvatar.Name = "btn_AddAvatar";
            this.btn_AddAvatar.Size = new System.Drawing.Size(138, 40);
            this.btn_AddAvatar.TabIndex = 198;
            this.btn_AddAvatar.Text = "Add Avatar";
            this.btn_AddAvatar.Click += new System.EventHandler(this.btn_AddAvatar_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::SchoolManagement.Properties.Resources.Engman1;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(23, 5);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(95, 95);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.panelDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDisplay.Location = new System.Drawing.Point(227, 106);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(773, 592);
            this.panelDisplay.TabIndex = 17;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox3.BorderRadius = 10;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox3.Location = new System.Drawing.Point(906, 13);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(35, 31);
            this.guna2ControlBox3.TabIndex = 16;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox1.Location = new System.Drawing.Point(945, 13);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 31);
            this.guna2ControlBox1.TabIndex = 15;
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewStudent";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnParents;
        private Guna.UI2.WinForms.Guna2Button btnPersonal;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddAvatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Panel panelDisplay;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private UCAddParentsInfo ucAddParentsInfo;
        private UCAddStudentInfo ucAddStudentInfo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private System.Windows.Forms.Label label2;
    }
}
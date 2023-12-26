namespace SchoolManagement
{
    partial class StudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformation));
            this.Sidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Scores = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuiitionfee = new Guna.UI2.WinForms.Guna2Button();
            this.btnParents = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbEventName = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Sidebar.Controls.Add(this.Scores);
            this.Sidebar.Controls.Add(this.btnTuiitionfee);
            this.Sidebar.Controls.Add(this.btnParents);
            this.Sidebar.Controls.Add(this.btnPersonal);
            this.Sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.Sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.Sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Sidebar.Location = new System.Drawing.Point(1, 96);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(226, 605);
            this.Sidebar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // Scores
            // 
            this.Scores.Animated = true;
            this.Scores.AnimatedGIF = true;
            this.Scores.BackColor = System.Drawing.Color.Transparent;
            this.Scores.BorderRadius = 15;
            this.Scores.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.file__1_;
            this.Scores.CustomImages.Image = global::SchoolManagement.Properties.Resources.file__1_;
            this.Scores.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Scores.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Scores.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.Scores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Scores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Scores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Scores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Scores.FillColor = System.Drawing.Color.Transparent;
            this.Scores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Scores.ForeColor = System.Drawing.Color.DimGray;
            this.Scores.HoverState.FillColor = System.Drawing.Color.White;
            this.Scores.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Scores.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Scores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Scores.Location = new System.Drawing.Point(0, 155);
            this.Scores.Margin = new System.Windows.Forms.Padding(2);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(221, 42);
            this.Scores.TabIndex = 5;
            this.Scores.Text = "Scores";
            this.Scores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Scores.TextOffset = new System.Drawing.Point(77, 0);
            // 
            // btnTuiitionfee
            // 
            this.btnTuiitionfee.Animated = true;
            this.btnTuiitionfee.AnimatedGIF = true;
            this.btnTuiitionfee.BackColor = System.Drawing.Color.Transparent;
            this.btnTuiitionfee.BorderRadius = 15;
            this.btnTuiitionfee.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources._3d;
            this.btnTuiitionfee.CustomImages.Image = global::SchoolManagement.Properties.Resources._3d;
            this.btnTuiitionfee.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTuiitionfee.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnTuiitionfee.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTuiitionfee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuiitionfee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuiitionfee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuiitionfee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuiitionfee.FillColor = System.Drawing.Color.Transparent;
            this.btnTuiitionfee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnTuiitionfee.ForeColor = System.Drawing.Color.DimGray;
            this.btnTuiitionfee.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTuiitionfee.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTuiitionfee.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.btnTuiitionfee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTuiitionfee.Location = new System.Drawing.Point(0, 209);
            this.btnTuiitionfee.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuiitionfee.Name = "btnTuiitionfee";
            this.btnTuiitionfee.Size = new System.Drawing.Size(221, 42);
            this.btnTuiitionfee.TabIndex = 4;
            this.btnTuiitionfee.Text = "Employees";
            this.btnTuiitionfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTuiitionfee.TextOffset = new System.Drawing.Point(77, 0);
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
            this.btnParents.Text = "Students";
            this.btnParents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParents.TextOffset = new System.Drawing.Point(77, 0);
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
            this.guna2Panel1.Controls.Add(this.lbStudentID);
            this.guna2Panel1.Controls.Add(this.lbEventName);
            this.guna2Panel1.Controls.Add(this.picAvatar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 102);
            this.guna2Panel1.TabIndex = 8;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.BackColor = System.Drawing.Color.White;
            this.lbStudentID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbStudentID.ForeColor = System.Drawing.Color.DimGray;
            this.lbStudentID.Location = new System.Drawing.Point(124, 50);
            this.lbStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(108, 28);
            this.lbStudentID.TabIndex = 4;
            this.lbStudentID.Text = "21522495";
            // 
            // lbEventName
            // 
            this.lbEventName.AutoSize = true;
            this.lbEventName.BackColor = System.Drawing.Color.White;
            this.lbEventName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbEventName.ForeColor = System.Drawing.Color.Black;
            this.lbEventName.Location = new System.Drawing.Point(124, 17);
            this.lbEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(289, 30);
            this.lbEventName.TabIndex = 3;
            this.lbEventName.Text = "Nguyen Hoang Minh Quan";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::SchoolManagement.Properties.Resources.Engman1;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(23, 9);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(83, 83);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
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
            this.guna2ControlBox3.TabIndex = 11;
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
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(227, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 592);
            this.panel1.TabIndex = 12;
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInformation";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel Sidebar;
        private Guna.UI2.WinForms.Guna2Button Scores;
        private Guna.UI2.WinForms.Guna2Button btnTuiitionfee;
        private Guna.UI2.WinForms.Guna2Button btnParents;
        private Guna.UI2.WinForms.Guna2Button btnPersonal;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
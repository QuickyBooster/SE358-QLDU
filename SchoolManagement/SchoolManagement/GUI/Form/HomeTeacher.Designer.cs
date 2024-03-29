﻿namespace SchoolManagement
{
    partial class HomeTeacher
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTeacher));
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Log_out = new Guna.UI2.WinForms.Guna2Button();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Classes = new Guna.UI2.WinForms.Guna2Button();
            this.Sidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Students = new Guna.UI2.WinForms.Guna2Button();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.HomePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 691);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher";
            // 
            // Log_out
            // 
            this.Log_out.Animated = true;
            this.Log_out.AnimatedGIF = true;
            this.Log_out.BackColor = System.Drawing.Color.Transparent;
            this.Log_out.BorderRadius = 10;
            this.Log_out.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.icon__log_out_hover;
            this.Log_out.CustomImages.Image = global::SchoolManagement.Properties.Resources.icon__log_out;
            this.Log_out.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Log_out.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.Log_out.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Transition1.SetDecoration(this.Log_out, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Log_out.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Log_out.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Log_out.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Log_out.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Log_out.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(95)))), ((int)(((byte)(240)))));
            this.Log_out.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Log_out.ForeColor = System.Drawing.Color.White;
            this.Log_out.HoverState.FillColor = System.Drawing.Color.White;
            this.Log_out.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Log_out.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Log_out.Location = new System.Drawing.Point(0, 735);
            this.Log_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(219, 38);
            this.Log_out.TabIndex = 9;
            this.Log_out.Text = "Log out";
            this.Log_out.TextOffset = new System.Drawing.Point(8, 0);
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.AnimatedGIF = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BorderRadius = 15;
            this.Settings.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.blue_icon__settings;
            this.Settings.CustomImages.Image = global::SchoolManagement.Properties.Resources.icon__settings;
            this.Settings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Settings.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Settings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.HoverState.FillColor = System.Drawing.Color.White;
            this.Settings.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Settings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.Location = new System.Drawing.Point(0, 243);
            this.Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(221, 42);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.TextOffset = new System.Drawing.Point(77, 0);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Classes
            // 
            this.Classes.Animated = true;
            this.Classes.AnimatedGIF = true;
            this.Classes.BackColor = System.Drawing.Color.Transparent;
            this.Classes.BorderRadius = 15;
            this.Classes.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.blue_icon__edit;
            this.Classes.CustomImages.Image = global::SchoolManagement.Properties.Resources.icon__edit;
            this.Classes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Classes.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Classes.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Classes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Classes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Classes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Classes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Classes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Classes.FillColor = System.Drawing.Color.Transparent;
            this.Classes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Classes.ForeColor = System.Drawing.Color.White;
            this.Classes.HoverState.FillColor = System.Drawing.Color.White;
            this.Classes.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Classes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Classes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Classes.Location = new System.Drawing.Point(0, 190);
            this.Classes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(221, 42);
            this.Classes.TabIndex = 5;
            this.Classes.Text = "Classes";
            this.Classes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Classes.TextOffset = new System.Drawing.Point(77, 0);
            this.Classes.Click += new System.EventHandler(this.Classes_Click_1);
            // 
            // Sidebar
            // 
            this.Sidebar.BorderRadius = 18;
            this.Sidebar.Controls.Add(this.pictureBox2);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.Log_out);
            this.Sidebar.Controls.Add(this.guna2CirclePictureBox2);
            this.Sidebar.Controls.Add(this.Settings);
            this.Sidebar.Controls.Add(this.Classes);
            this.Sidebar.Controls.Add(this.Students);
            this.Sidebar.Controls.Add(this.Home);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.Sidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.Sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(72, 800);
            this.Sidebar.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::SchoolManagement.Properties.Resources.libraryn;
            this.pictureBox2.Location = new System.Drawing.Point(20, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox2.Image = global::SchoolManagement.Properties.Resources.Engman;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(12, 679);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(40, 41);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 8;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Students
            // 
            this.Students.Animated = true;
            this.Students.AnimatedGIF = true;
            this.Students.BackColor = System.Drawing.Color.Transparent;
            this.Students.BorderRadius = 15;
            this.Students.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.blue_icon__group;
            this.Students.CustomImages.Image = global::SchoolManagement.Properties.Resources.icon__group;
            this.Students.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Students.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Students.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Students, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Students.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Students.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Students.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Students.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Students.FillColor = System.Drawing.Color.Transparent;
            this.Students.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.HoverState.FillColor = System.Drawing.Color.White;
            this.Students.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Students.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Students.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Students.Location = new System.Drawing.Point(0, 137);
            this.Students.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(221, 42);
            this.Students.TabIndex = 3;
            this.Students.Text = "Students";
            this.Students.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Students.TextOffset = new System.Drawing.Point(77, 0);
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Home
            // 
            this.Home.Animated = true;
            this.Home.AnimatedGIF = true;
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BorderRadius = 15;
            this.Home.CustomImages.HoveredImage = global::SchoolManagement.Properties.Resources.blue_home_simple_door_;
            this.Home.CustomImages.Image = global::SchoolManagement.Properties.Resources.home_simple_door;
            this.Home.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.Home.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Transition1.SetDecoration(this.Home, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home.FillColor = System.Drawing.Color.Transparent;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.HoverState.FillColor = System.Drawing.Color.White;
            this.Home.HoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Home.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.Location = new System.Drawing.Point(0, 84);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(221, 42);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.TextOffset = new System.Drawing.Point(77, 0);
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.Myschool;
            this.pictureBox1.Location = new System.Drawing.Point(81, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.Interval = 5;
            this.guna2Transition1.MaxAnimationTime = 1000;
            // 
            // HomePanel
            // 
            this.HomePanel.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePanel.BorderRadius = 20;
            this.guna2Transition1.SetDecoration(this.HomePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HomePanel.FillColor = System.Drawing.Color.Transparent;
            this.HomePanel.FillColor2 = System.Drawing.Color.Transparent;
            this.HomePanel.FillColor3 = System.Drawing.Color.Transparent;
            this.HomePanel.FillColor4 = System.Drawing.Color.Transparent;
            this.HomePanel.Location = new System.Drawing.Point(76, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomePanel.Size = new System.Drawing.Size(1124, 800);
            this.HomePanel.TabIndex = 11;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1118, 7);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 22);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1155, 7);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 22);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 350;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // HomeTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.HomePanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeTeacher";
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Button Log_out;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Classes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel Sidebar;
        private Guna.UI2.WinForms.Guna2Button Students;
        private Guna.UI2.WinForms.Guna2Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel HomePanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        private UCHome_Teacher uCHome_Teacher;
        private UCStudent_Teacher uCStudent_Teacher;
        private UCClasses_Teacher uCClasses_Teacher;
        private UCSettings_Teacher uCSettings_Teacher;
    }
}
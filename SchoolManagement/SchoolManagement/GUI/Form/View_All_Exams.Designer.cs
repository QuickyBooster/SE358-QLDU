namespace SchoolManagement
{
    partial class View_All_Exams
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_All_Exams));
			this.btnAddStudent = new Guna.UI2.WinForms.Guna2GradientButton();
			this.txtSearchStudent = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSearch = new System.Windows.Forms.PictureBox();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.gridviewSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.File_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.lbTotalStudents = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewSupplier)).BeginInit();
			this.guna2CustomGradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddStudent.AutoRoundedCorners = true;
			this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
			this.btnAddStudent.BorderRadius = 25;
			this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddStudent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btnAddStudent.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(85)))), ((int)(((byte)(254)))));
			this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnAddStudent.ForeColor = System.Drawing.Color.White;
			this.btnAddStudent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btnAddStudent.Location = new System.Drawing.Point(753, 82);
			this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(204, 52);
			this.btnAddStudent.TabIndex = 70;
			this.btnAddStudent.Text = "Add new exam";
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddExam_Click);
			// 
			// txtSearchStudent
			// 
			this.txtSearchStudent.AutoRoundedCorners = true;
			this.txtSearchStudent.BackColor = System.Drawing.Color.Transparent;
			this.txtSearchStudent.BorderColor = System.Drawing.Color.Gray;
			this.txtSearchStudent.BorderRadius = 25;
			this.txtSearchStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearchStudent.DefaultText = "";
			this.txtSearchStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearchStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearchStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtSearchStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchStudent.Location = new System.Drawing.Point(120, 82);
			this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtSearchStudent.Name = "txtSearchStudent";
			this.txtSearchStudent.PasswordChar = '\0';
			this.txtSearchStudent.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtSearchStudent.PlaceholderText = "Enter exam\'s name";
			this.txtSearchStudent.SelectedText = "";
			this.txtSearchStudent.Size = new System.Drawing.Size(315, 52);
			this.txtSearchStudent.TabIndex = 69;
			this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchExam_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.Image = global::SchoolManagement.Properties.Resources.search;
			this.btnSearch.Location = new System.Drawing.Point(32, 82);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(57, 52);
			this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnSearch.TabIndex = 68;
			this.btnSearch.TabStop = false;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
			this.guna2Panel1.BorderRadius = 35;
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
			this.guna2Panel1.Controls.Add(this.gridviewSupplier);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.label4);
			this.guna2Panel1.FillColor = System.Drawing.Color.White;
			this.guna2Panel1.Location = new System.Drawing.Point(32, 163);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(916, 476);
			this.guna2Panel1.TabIndex = 71;
			// 
			// guna2ComboBox1
			// 
			this.guna2ComboBox1.AccessibleName = "";
			this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox1.ItemHeight = 30;
			this.guna2ComboBox1.Location = new System.Drawing.Point(606, 32);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.Size = new System.Drawing.Size(292, 36);
			this.guna2ComboBox1.TabIndex = 44;
			// 
			// gridviewSupplier
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.gridviewSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridviewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridviewSupplier.ColumnHeadersHeight = 38;
			this.gridviewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gridviewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.File_name,
            this.Download,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridviewSupplier.DefaultCellStyle = dataGridViewCellStyle3;
			this.gridviewSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridviewSupplier.Location = new System.Drawing.Point(4, 92);
			this.gridviewSupplier.Margin = new System.Windows.Forms.Padding(4);
			this.gridviewSupplier.Name = "gridviewSupplier";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gridviewSupplier.RowHeadersVisible = false;
			this.gridviewSupplier.RowHeadersWidth = 50;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewSupplier.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.gridviewSupplier.RowTemplate.Height = 40;
			this.gridviewSupplier.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewSupplier.Size = new System.Drawing.Size(908, 346);
			this.gridviewSupplier.TabIndex = 43;
			this.gridviewSupplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gridviewSupplier.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gridviewSupplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.gridviewSupplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gridviewSupplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gridviewSupplier.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.gridviewSupplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridviewSupplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gridviewSupplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridviewSupplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridviewSupplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gridviewSupplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gridviewSupplier.ThemeStyle.HeaderStyle.Height = 38;
			this.gridviewSupplier.ThemeStyle.ReadOnly = false;
			this.gridviewSupplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gridviewSupplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridviewSupplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridviewSupplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gridviewSupplier.ThemeStyle.RowsStyle.Height = 40;
			this.gridviewSupplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridviewSupplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// Num
			// 
			this.Num.FillWeight = 200F;
			this.Num.HeaderText = "Num";
			this.Num.MinimumWidth = 6;
			this.Num.Name = "Num";
			// 
			// File_name
			// 
			this.File_name.HeaderText = "File name";
			this.File_name.MinimumWidth = 6;
			this.File_name.Name = "File_name";
			// 
			// Download
			// 
			this.Download.FillWeight = 50F;
			this.Download.HeaderText = "Download";
			this.Download.MinimumWidth = 6;
			this.Download.Name = "Download";
			// 
			// Edit
			// 
			this.Edit.HeaderText = "Edit";
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.MinimumWidth = 6;
			this.Delete.Name = "Delete";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.DarkGray;
			this.label3.Location = new System.Drawing.Point(32, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(287, 56);
			this.label3.TabIndex = 42;
			this.label3.Text = "These are list exams of class \r\n\r\n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(32, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(203, 30);
			this.label4.TabIndex = 41;
			this.label4.Text = "Exam information ";
			// 
			// guna2CustomGradientPanel1
			// 
			this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2CustomGradientPanel1.BorderRadius = 25;
			this.guna2CustomGradientPanel1.Controls.Add(this.lbTotalStudents);
			this.guna2CustomGradientPanel1.Controls.Add(this.label1);
			this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
			this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(32, 12);
			this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
			this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
			this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(925, 54);
			this.guna2CustomGradientPanel1.TabIndex = 67;
			// 
			// lbTotalStudents
			// 
			this.lbTotalStudents.AutoSize = true;
			this.lbTotalStudents.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.lbTotalStudents.ForeColor = System.Drawing.Color.White;
			this.lbTotalStudents.Location = new System.Drawing.Point(343, 12);
			this.lbTotalStudents.Name = "lbTotalStudents";
			this.lbTotalStudents.Size = new System.Drawing.Size(57, 35);
			this.lbTotalStudents.TabIndex = 2;
			this.lbTotalStudents.Text = "100";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Total exams ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.students;
			this.pictureBox1.Location = new System.Drawing.Point(803, 5);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// View_All_Exams
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(994, 673);
			this.Controls.Add(this.btnAddStudent);
			this.Controls.Add(this.txtSearchStudent);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2CustomGradientPanel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "View_All_Exams";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Exam_Teacher";
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridviewSupplier)).EndInit();
			this.guna2CustomGradientPanel1.ResumeLayout(false);
			this.guna2CustomGradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnAddStudent;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStudent;
        private System.Windows.Forms.PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_name;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lbTotalStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
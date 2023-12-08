namespace SchoolManagement
{
    partial class UCClasses_Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.gridviewSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddClass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotaClasses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Avatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSupplier)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Classes information";
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
            this.Avatar,
            this.Grade,
            this.Class_name,
            this.NumStudents,
            this.Form_teacher,
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
            this.gridviewSupplier.Location = new System.Drawing.Point(3, 75);
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
            this.gridviewSupplier.Size = new System.Drawing.Size(1011, 423);
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
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 35;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.gridviewSupplier);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(54, 226);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1017, 529);
            this.guna2Panel1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "These are list of all classes in our school up to now ";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClass.AutoRoundedCorners = true;
            this.btnAddClass.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClass.BorderRadius = 22;
            this.btnAddClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btnAddClass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(85)))), ((int)(((byte)(254)))));
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddClass.Location = new System.Drawing.Point(901, 142);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(170, 47);
            this.btnAddClass.TabIndex = 64;
            this.btnAddClass.Text = "Add new class";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::SchoolManagement.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(53, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 47);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 63;
            this.btnSearch.TabStop = false;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.AutoRoundedCorners = true;
            this.txtSearchClass.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchClass.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchClass.BorderRadius = 22;
            this.txtSearchClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClass.DefaultText = "";
            this.txtSearchClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClass.Location = new System.Drawing.Point(115, 142);
            this.txtSearchClass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.PasswordChar = '\0';
            this.txtSearchClass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchClass.PlaceholderText = "Enter class\'s name";
            this.txtSearchClass.SelectedText = "";
            this.txtSearchClass.Size = new System.Drawing.Size(390, 47);
            this.txtSearchClass.TabIndex = 62;
            // 
            // lbTotaClasses
            // 
            this.lbTotaClasses.AutoSize = true;
            this.lbTotaClasses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbTotaClasses.ForeColor = System.Drawing.Color.White;
            this.lbTotaClasses.Location = new System.Drawing.Point(257, 15);
            this.lbTotaClasses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotaClasses.Name = "lbTotaClasses";
            this.lbTotaClasses.Size = new System.Drawing.Size(60, 28);
            this.lbTotaClasses.TabIndex = 2;
            this.lbTotaClasses.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total classes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.virtual_event;
            this.pictureBox1.Location = new System.Drawing.Point(926, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 25;
            this.guna2CustomGradientPanel1.Controls.Add(this.lbTotaClasses);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(53, 45);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1018, 61);
            this.guna2CustomGradientPanel1.TabIndex = 61;
            // 
            // Avatar
            // 
            this.Avatar.FillWeight = 150F;
            this.Avatar.HeaderText = "Avatar";
            this.Avatar.Name = "Avatar";
            this.Avatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Avatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // Class_name
            // 
            this.Class_name.FillWeight = 150F;
            this.Class_name.HeaderText = "Class name";
            this.Class_name.Name = "Class_name";
            // 
            // NumStudents
            // 
            this.NumStudents.HeaderText = "Num of students";
            this.NumStudents.Name = "NumStudents";
            // 
            // Form_teacher
            // 
            this.Form_teacher.FillWeight = 150F;
            this.Form_teacher.HeaderText = "Form teacher";
            this.Form_teacher.Name = "Form_teacher";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // UCClasses_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchClass);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.Name = "UCClasses_Principal";
            this.Size = new System.Drawing.Size(1124, 800);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSupplier)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewSupplier;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddClass;
        private System.Windows.Forms.PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClass;
        private System.Windows.Forms.Label lbTotaClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewImageColumn Avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form_teacher;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

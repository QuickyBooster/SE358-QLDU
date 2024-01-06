namespace SchoolManagement
{
    partial class UCStudentScoreInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.gridviewClass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FifteenMins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnePeriodScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAVGPoint = new System.Windows.Forms.Label();
            //this.lbStudentName = new System.Windows.Forms.Label();
            //this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            //this.label1 = new System.Windows.Forms.Label();
            //this.lbAVGPoint = new System.Windows.Forms.Label();
            //this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.FifteenMins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.OnePeriodScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSemester
            // 
            this.comboSemester.BackColor = System.Drawing.Color.Transparent;
            this.comboSemester.BorderColor = System.Drawing.Color.Gray;
            this.comboSemester.BorderRadius = 12;
            this.comboSemester.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSemester.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.comboSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboSemester.ItemHeight = 30;
            this.comboSemester.Location = new System.Drawing.Point(306, 19);
            this.comboSemester.Name = "comboSemester";
            this.comboSemester.Size = new System.Drawing.Size(165, 36);
            this.comboSemester.TabIndex = 197;
            this.comboSemester.SelectedValueChanged += new System.EventHandler(this.comboSemester_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(173, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 198;
            this.label12.Text = "Choose subject";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.gridviewClass);
            this.guna2Panel1.Controls.Add(this.lbStudentName);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(45, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(681, 384);
            this.guna2Panel1.TabIndex = 199;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::SchoolManagement.Properties.Resources.refresh;
            this.btnSearch.Location = new System.Drawing.Point(645, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 23);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 64;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridviewClass
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.gridviewClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridviewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridviewClass.ColumnHeadersHeight = 36;
            this.gridviewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.FifteenMins,
            this.OnePeriodScore});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewClass.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridviewClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewClass.Location = new System.Drawing.Point(3, 47);
            this.gridviewClass.Name = "gridviewClass";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridviewClass.RowHeadersVisible = false;
            this.gridviewClass.RowHeadersWidth = 50;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewClass.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridviewClass.RowTemplate.Height = 36;
            this.gridviewClass.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewClass.Size = new System.Drawing.Size(675, 314);
            this.gridviewClass.TabIndex = 43;
            this.gridviewClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewClass.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewClass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewClass.ThemeStyle.HeaderStyle.Height = 36;
            this.gridviewClass.ThemeStyle.ReadOnly = false;
            this.gridviewClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewClass.ThemeStyle.RowsStyle.Height = 36;
            this.gridviewClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ExamID
            // 
            this.ExamID.HeaderText = "Exam ID";
            this.ExamID.Name = "ExamID";
            // 
            // Subject
            // 
            this.Subject.FillWeight = 200F;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // FifteenMins
            // 
            this.FifteenMins.HeaderText = "Type Exam";
            this.FifteenMins.Name = "FifteenMins";
            // 
            // OnePeriodScore
            // 
            this.OnePeriodScore.FillWeight = 150F;
            this.OnePeriodScore.HeaderText = "Score";
            this.OnePeriodScore.Name = "OnePeriodScore";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoEllipsis = true;
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbStudentName.Location = new System.Drawing.Point(11, 11);
            this.lbStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentName.MaximumSize = new System.Drawing.Size(117, 21);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(117, 21);
            this.lbStudentName.TabIndex = 41;
            this.lbStudentName.Text = "Student name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEdit.Location = new System.Drawing.Point(314, 535);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 36);
            this.btnEdit.TabIndex = 201;
            this.btnEdit.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(59, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 202;
            this.label1.Text = "Average points:";
            // 
            // lbAVGPoint
            // 
            this.lbAVGPoint.AutoSize = true;
            this.lbAVGPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbAVGPoint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbAVGPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAVGPoint.Location = new System.Drawing.Point(182, 496);
            this.lbAVGPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAVGPoint.Name = "lbAVGPoint";
            this.lbAVGPoint.Size = new System.Drawing.Size(119, 20);
            this.lbAVGPoint.TabIndex = 203;
            this.lbAVGPoint.Text = "Average points:";
            // 
            // Subject
            // 
            this.Subject.FillWeight = 200F;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // FifteenMins
            // 
            this.FifteenMins.HeaderText = "Type Exam";
            this.FifteenMins.Name = "FifteenMins";
            // 
            // OnePeriodScore
            // 
            this.OnePeriodScore.FillWeight = 150F;
            this.OnePeriodScore.HeaderText = "Score";
            this.OnePeriodScore.Name = "OnePeriodScore";
            // 
            // UCStudentScoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbAVGPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboSemester);
            this.DoubleBuffered = true;
            this.Name = "UCStudentScoreInfo";
            this.Size = new System.Drawing.Size(773, 592);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboSemester;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewClass;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAVGPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn FifteenMins;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnePeriodScore;
    }
}

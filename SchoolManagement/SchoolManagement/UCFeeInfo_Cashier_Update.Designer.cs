namespace SchoolManagement
{
    partial class UCFeeInfo_Cashier_Update
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
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnSearch = new System.Windows.Forms.PictureBox();
			this.gridviewClass = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lbStudentName = new System.Windows.Forms.Label();
			this.FeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).BeginInit();
			this.SuspendLayout();
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
			this.guna2Panel1.Location = new System.Drawing.Point(61, 84);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(908, 560);
			this.guna2Panel1.TabIndex = 207;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.Image = global::SchoolManagement.Properties.Resources.refresh;
			this.btnSearch.Location = new System.Drawing.Point(860, 10);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(31, 28);
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
			this.gridviewClass.ColumnHeadersHeight = 38;
			this.gridviewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gridviewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeName,
            this.Amount,
            this.Cashier,
            this.Status});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(254)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridviewClass.DefaultCellStyle = dataGridViewCellStyle8;
			this.gridviewClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridviewClass.Location = new System.Drawing.Point(4, 59);
			this.gridviewClass.Margin = new System.Windows.Forms.Padding(4);
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
			this.gridviewClass.Size = new System.Drawing.Size(900, 480);
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
			this.gridviewClass.ThemeStyle.HeaderStyle.Height = 38;
			this.gridviewClass.ThemeStyle.ReadOnly = false;
			this.gridviewClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gridviewClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gridviewClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridviewClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gridviewClass.ThemeStyle.RowsStyle.Height = 36;
			this.gridviewClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gridviewClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// lbStudentName
			// 
			this.lbStudentName.AutoEllipsis = true;
			this.lbStudentName.AutoSize = true;
			this.lbStudentName.BackColor = System.Drawing.Color.Transparent;
			this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
			this.lbStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbStudentName.Location = new System.Drawing.Point(15, 14);
			this.lbStudentName.MaximumSize = new System.Drawing.Size(156, 26);
			this.lbStudentName.Name = "lbStudentName";
			this.lbStudentName.Size = new System.Drawing.Size(144, 26);
			this.lbStudentName.TabIndex = 41;
			this.lbStudentName.Text = "Student name";
			// 
			// FeeName
			// 
			this.FeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.FeeName.FillWeight = 150F;
			this.FeeName.Frozen = true;
			this.FeeName.HeaderText = "Fee name";
			this.FeeName.MinimumWidth = 6;
			this.FeeName.Name = "FeeName";
			this.FeeName.Width = 270;
			// 
			// Amount
			// 
			this.Amount.FillWeight = 150F;
			this.Amount.HeaderText = "Amount (VNĐ)";
			this.Amount.MinimumWidth = 6;
			this.Amount.Name = "Amount";
			// 
			// Cashier
			// 
			this.Cashier.FillWeight = 150F;
			this.Cashier.HeaderText = "Cashier";
			this.Cashier.MinimumWidth = 6;
			this.Cashier.Name = "Cashier";
			// 
			// Status
			// 
			this.Status.FillWeight = 50F;
			this.Status.HeaderText = "Status";
			this.Status.MinimumWidth = 6;
			this.Status.Name = "Status";
			// 
			// UCFeeInfo_Cashier_Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.guna2Panel1);
			this.DoubleBuffered = true;
			this.Name = "UCFeeInfo_Cashier_Update";
			this.Size = new System.Drawing.Size(1031, 729);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewClass;
        private System.Windows.Forms.Label lbStudentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FeeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}

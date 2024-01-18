namespace SchoolManagement
{
	partial class AddFee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFee));
			this.subjectsTableAdapter = new SchoolManagement.SE358_SchoolManagementDataSetTableAdapters.SubjectsTableAdapter();
			this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sE358_SchoolManagementDataSet = new SchoolManagement.SE358_SchoolManagementDataSet();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.btn_Add = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Delete = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
			this.label3 = new System.Windows.Forms.Label();
			this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.txtSubName = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
			this.dtpCollectionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sE358_SchoolManagementDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// subjectsTableAdapter
			// 
			this.subjectsTableAdapter.ClearBeforeFill = true;
			// 
			// subjectsBindingSource
			// 
			this.subjectsBindingSource.DataMember = "Subjects";
			this.subjectsBindingSource.DataSource = this.sE358_SchoolManagementDataSet;
			// 
			// sE358_SchoolManagementDataSet
			// 
			this.sE358_SchoolManagementDataSet.DataSetName = "SE358_SchoolManagementDataSet";
			this.sE358_SchoolManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(179, 342);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 19);
			this.label5.TabIndex = 219;
			this.label5.Text = "Collection Date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(178, 252);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 19);
			this.label4.TabIndex = 217;
			this.label4.Text = "Amount (VND)";
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Animated = true;
			this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
			this.guna2TextBox1.BorderRadius = 13;
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "Enter amount";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2TextBox1.ForeColor = System.Drawing.Color.DimGray;
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Location = new System.Drawing.Point(180, 281);
			this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.guna2TextBox1.PlaceholderText = "Enter 45\' test";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new System.Drawing.Size(357, 46);
			this.guna2TextBox1.TabIndex = 216;
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.Transparent;
			this.btn_Add.BorderRadius = 15;
			this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.Color.White;
			this.btn_Add.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btn_Add.Location = new System.Drawing.Point(475, 445);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(133, 43);
			this.btn_Add.TabIndex = 212;
			this.btn_Add.Text = "Add";
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
			this.btn_Delete.BorderRadius = 15;
			this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Delete.ForeColor = System.Drawing.Color.White;
			this.btn_Delete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btn_Delete.Location = new System.Drawing.Point(302, 445);
			this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(133, 43);
			this.btn_Delete.TabIndex = 214;
			this.btn_Delete.Text = "Delete";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
			this.btn_Cancel.BorderRadius = 15;
			this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.White;
			this.btn_Cancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btn_Cancel.Location = new System.Drawing.Point(135, 445);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(133, 43);
			this.btn_Cancel.TabIndex = 213;
			this.btn_Cancel.Text = "Cancel";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(178, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 24);
			this.label3.TabIndex = 211;
			this.label3.Text = "Student name";
			// 
			// guna2ControlBox3
			// 
			this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox3.Animated = true;
			this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox3.BorderRadius = 5;
			this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox3.CustomIconSize = 20F;
			this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox3.Location = new System.Drawing.Point(1381, 103);
			this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2ControlBox3.Name = "guna2ControlBox3";
			this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
			this.guna2ControlBox3.TabIndex = 210;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.Animated = true;
			this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderRadius = 5;
			this.guna2ControlBox1.CustomIconSize = 20F;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox1.Location = new System.Drawing.Point(694, 22);
			this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
			this.guna2ControlBox1.TabIndex = 209;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(254)))));
			this.label1.Location = new System.Drawing.Point(277, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 35);
			this.label1.TabIndex = 206;
			this.label1.Text = "Add new Fee";
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.AnimateWindow = true;
			this.guna2BorderlessForm1.AnimationInterval = 200;
			this.guna2BorderlessForm1.BorderRadius = 35;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockForm = false;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(178, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 19);
			this.label2.TabIndex = 208;
			this.label2.Text = "Fee name";
			// 
			// txtSubName
			// 
			this.txtSubName.Animated = true;
			this.txtSubName.BackColor = System.Drawing.Color.Transparent;
			this.txtSubName.BorderColor = System.Drawing.Color.Gray;
			this.txtSubName.BorderRadius = 13;
			this.txtSubName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSubName.DefaultText = "Enter fee name";
			this.txtSubName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSubName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSubName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSubName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSubName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSubName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtSubName.ForeColor = System.Drawing.Color.DimGray;
			this.txtSubName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSubName.Location = new System.Drawing.Point(180, 193);
			this.txtSubName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtSubName.Name = "txtSubName";
			this.txtSubName.PasswordChar = '\0';
			this.txtSubName.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtSubName.PlaceholderText = "Enter 15\' test";
			this.txtSubName.SelectedText = "";
			this.txtSubName.Size = new System.Drawing.Size(357, 49);
			this.txtSubName.TabIndex = 207;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.Animated = true;
			this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox2.BorderRadius = 5;
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.CustomIconSize = 20F;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
			this.guna2ControlBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.Location = new System.Drawing.Point(652, 22);
			this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
			this.guna2ControlBox2.TabIndex = 221;
			// 
			// guna2TextBox3
			// 
			this.guna2TextBox3.Animated = true;
			this.guna2TextBox3.BackColor = System.Drawing.Color.Transparent;
			this.guna2TextBox3.BorderColor = System.Drawing.Color.Gray;
			this.guna2TextBox3.BorderRadius = 13;
			this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox3.DefaultText = "Student name";
			this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2TextBox3.ForeColor = System.Drawing.Color.DimGray;
			this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox3.Location = new System.Drawing.Point(180, 102);
			this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.guna2TextBox3.Name = "guna2TextBox3";
			this.guna2TextBox3.PasswordChar = '\0';
			this.guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.guna2TextBox3.PlaceholderText = "Enter 15\' test";
			this.guna2TextBox3.SelectedText = "";
			this.guna2TextBox3.Size = new System.Drawing.Size(357, 45);
			this.guna2TextBox3.TabIndex = 222;
			// 
			// dtpCollectionDate
			// 
			this.dtpCollectionDate.AutoRoundedCorners = true;
			this.dtpCollectionDate.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.dtpCollectionDate.BorderColor = System.Drawing.Color.Transparent;
			this.dtpCollectionDate.BorderRadius = 13;
			this.dtpCollectionDate.Checked = true;
			this.dtpCollectionDate.FillColor = System.Drawing.Color.Transparent;
			this.dtpCollectionDate.FocusedColor = System.Drawing.Color.Transparent;
			this.dtpCollectionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpCollectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpCollectionDate.Location = new System.Drawing.Point(180, 371);
			this.dtpCollectionDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCollectionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpCollectionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpCollectionDate.Name = "dtpCollectionDate";
			this.dtpCollectionDate.Size = new System.Drawing.Size(357, 47);
			this.dtpCollectionDate.TabIndex = 223;
			this.dtpCollectionDate.Value = new System.DateTime(2023, 12, 5, 9, 59, 40, 580);
			// 
			// AddFee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SchoolManagement.Properties.Resources.raucu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(751, 545);
			this.Controls.Add(this.dtpCollectionDate);
			this.Controls.Add(this.guna2TextBox3);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.guna2ControlBox3);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSubName);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddFee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddFee";
			this.Load += new System.EventHandler(this.AddFee_Load);
			((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sE358_SchoolManagementDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SE358_SchoolManagementDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
		private System.Windows.Forms.BindingSource subjectsBindingSource;
		private SE358_SchoolManagementDataSet sE358_SchoolManagementDataSet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private Guna.UI2.WinForms.Guna2GradientButton btn_Add;
		private Guna.UI2.WinForms.Guna2GradientButton btn_Delete;
		private Guna.UI2.WinForms.Guna2GradientButton btn_Cancel;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtSubName;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpCollectionDate;
	}
}
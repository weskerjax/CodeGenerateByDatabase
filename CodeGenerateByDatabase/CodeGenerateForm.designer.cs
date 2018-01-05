namespace CodeGenerateByDatabase
{
	partial class CodeGenerateForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label nameSpaceLabel;
			System.Windows.Forms.Label dcNameLabel;
			System.Windows.Forms.SplitContainer hSplitContainer;
			System.Windows.Forms.SplitContainer vSplitContainer;
			this._templateSelect = new System.Windows.Forms.FlowLayoutPanel();
			this._tableSelect = new System.Windows.Forms.CheckedListBox();
			this._execStatusMsg = new System.Windows.Forms.TextBox();
			this._cntStringBox = new System.Windows.Forms.ComboBox();
			this._cntStringBtn = new System.Windows.Forms.Button();
			this._solutionBox = new System.Windows.Forms.ComboBox();
			this._solutionBtn = new System.Windows.Forms.Button();
			this._isOverride = new System.Windows.Forms.CheckBox();
			this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this._nameSpaceBox = new System.Windows.Forms.TextBox();
			this._dcNameBox = new System.Windows.Forms.TextBox();
			this._solitionDialog = new System.Windows.Forms.OpenFileDialog();
			this._toolTip = new System.Windows.Forms.ToolTip(this.components);
			this._execBtn = new System.Windows.Forms.Button();
			this._closeBtn = new System.Windows.Forms.Button();
			nameSpaceLabel = new System.Windows.Forms.Label();
			dcNameLabel = new System.Windows.Forms.Label();
			hSplitContainer = new System.Windows.Forms.SplitContainer();
			vSplitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(hSplitContainer)).BeginInit();
			hSplitContainer.Panel1.SuspendLayout();
			hSplitContainer.Panel2.SuspendLayout();
			hSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(vSplitContainer)).BeginInit();
			vSplitContainer.Panel1.SuspendLayout();
			vSplitContainer.Panel2.SuspendLayout();
			vSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// nameSpaceLabel
			// 
			nameSpaceLabel.AutoSize = true;
			nameSpaceLabel.Location = new System.Drawing.Point(20, 75);
			nameSpaceLabel.Name = "nameSpaceLabel";
			nameSpaceLabel.Size = new System.Drawing.Size(86, 12);
			nameSpaceLabel.TabIndex = 101;
			nameSpaceLabel.Text = "Class NameSpace";
			// 
			// dcNameLabel
			// 
			dcNameLabel.AutoSize = true;
			dcNameLabel.Location = new System.Drawing.Point(13, 107);
			dcNameLabel.Name = "dcNameLabel";
			dcNameLabel.Size = new System.Drawing.Size(93, 12);
			dcNameLabel.TabIndex = 102;
			dcNameLabel.Text = "DataContext Name";
			// 
			// hSplitContainer
			// 
			hSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			hSplitContainer.Location = new System.Drawing.Point(11, 133);
			hSplitContainer.Name = "hSplitContainer";
			// 
			// hSplitContainer.Panel1
			// 
			hSplitContainer.Panel1.Controls.Add(this._templateSelect);
			// 
			// hSplitContainer.Panel2
			// 
			hSplitContainer.Panel2.Controls.Add(vSplitContainer);
			hSplitContainer.Size = new System.Drawing.Size(571, 280);
			hSplitContainer.SplitterDistance = 94;
			hSplitContainer.TabIndex = 103;
			// 
			// _templateSelect
			// 
			this._templateSelect.AutoScroll = true;
			this._templateSelect.Dock = System.Windows.Forms.DockStyle.Fill;
			this._templateSelect.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this._templateSelect.Location = new System.Drawing.Point(0, 0);
			this._templateSelect.Name = "_templateSelect";
			this._templateSelect.Size = new System.Drawing.Size(94, 280);
			this._templateSelect.TabIndex = 20;
			this._templateSelect.TabStop = true;
			// 
			// vSplitContainer
			// 
			vSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			vSplitContainer.Location = new System.Drawing.Point(0, 0);
			vSplitContainer.Name = "vSplitContainer";
			// 
			// vSplitContainer.Panel1
			// 
			vSplitContainer.Panel1.Controls.Add(this._tableSelect);
			// 
			// vSplitContainer.Panel2
			// 
			vSplitContainer.Panel2.Controls.Add(this._execStatusMsg);
			vSplitContainer.Size = new System.Drawing.Size(473, 280);
			vSplitContainer.SplitterDistance = 221;
			vSplitContainer.TabIndex = 0;
			// 
			// _tableSelect
			// 
			this._tableSelect.CheckOnClick = true;
			this._tableSelect.Cursor = System.Windows.Forms.Cursors.Default;
			this._tableSelect.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableSelect.FormattingEnabled = true;
			this._tableSelect.HorizontalScrollbar = true;
			this._tableSelect.Location = new System.Drawing.Point(0, 0);
			this._tableSelect.Name = "_tableSelect";
			this._tableSelect.ScrollAlwaysVisible = true;
			this._tableSelect.Size = new System.Drawing.Size(221, 280);
			this._tableSelect.TabIndex = 51;
			// 
			// _execStatusMsg
			// 
			this._execStatusMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this._execStatusMsg.Location = new System.Drawing.Point(0, 0);
			this._execStatusMsg.Multiline = true;
			this._execStatusMsg.Name = "_execStatusMsg";
			this._execStatusMsg.ReadOnly = true;
			this._execStatusMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._execStatusMsg.Size = new System.Drawing.Size(248, 280);
			this._execStatusMsg.TabIndex = 0;
			this._execStatusMsg.TabStop = false;
			this._execStatusMsg.WordWrap = false;
			// 
			// _cntStringBox
			// 
			this._cntStringBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._cntStringBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodeGenerateByDatabase.Properties.Settings.Default, "CntString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._cntStringBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cntStringBox.FormattingEnabled = true;
			this._cntStringBox.Location = new System.Drawing.Point(12, 12);
			this._cntStringBox.Name = "_cntStringBox";
			this._cntStringBox.Size = new System.Drawing.Size(484, 20);
			this._cntStringBox.TabIndex = 11;
			this._cntStringBox.Text = global::CodeGenerateByDatabase.Properties.Settings.Default.CntString;
			this._cntStringBox.TextChanged += new System.EventHandler(this.cntStringBox_TextChanged);
			this._cntStringBox.Validating += new System.ComponentModel.CancelEventHandler(this._cntStringBox_Validating);
			// 
			// _cntStringBtn
			// 
			this._cntStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._cntStringBtn.Location = new System.Drawing.Point(507, 10);
			this._cntStringBtn.Name = "_cntStringBtn";
			this._cntStringBtn.Size = new System.Drawing.Size(75, 23);
			this._cntStringBtn.TabIndex = 12;
			this._cntStringBtn.Text = "選擇連線";
			this._cntStringBtn.UseVisualStyleBackColor = true;
			this._cntStringBtn.Click += new System.EventHandler(this._cntStringBtn_Click);
			// 
			// _solutionBox
			// 
			this._solutionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._solutionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodeGenerateByDatabase.Properties.Settings.Default, "Solution", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._solutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._solutionBox.FormattingEnabled = true;
			this._solutionBox.Location = new System.Drawing.Point(12, 43);
			this._solutionBox.Name = "_solutionBox";
			this._solutionBox.Size = new System.Drawing.Size(484, 20);
			this._solutionBox.TabIndex = 13;
			this._solutionBox.Text = global::CodeGenerateByDatabase.Properties.Settings.Default.Solution;
			this._solutionBox.Validating += new System.ComponentModel.CancelEventHandler(this._solutionBox_Validating);
			// 
			// _solutionBtn
			// 
			this._solutionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._solutionBtn.Location = new System.Drawing.Point(507, 41);
			this._solutionBtn.Name = "_solutionBtn";
			this._solutionBtn.Size = new System.Drawing.Size(75, 23);
			this._solutionBtn.TabIndex = 14;
			this._solutionBtn.Text = "方案選擇";
			this._solutionBtn.UseVisualStyleBackColor = true;
			this._solutionBtn.Click += new System.EventHandler(this.solutionBtn_Click);
			// 
			// _isOverride
			// 
			this._isOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._isOverride.AutoSize = true;
			this._isOverride.Font = new System.Drawing.Font("新細明體", 9.75F);
			this._isOverride.Location = new System.Drawing.Point(314, 425);
			this._isOverride.Name = "_isOverride";
			this._isOverride.Size = new System.Drawing.Size(78, 17);
			this._isOverride.TabIndex = 61;
			this._isOverride.Text = "強制覆蓋";
			this._isOverride.UseVisualStyleBackColor = true;
			// 
			// _errorProvider
			// 
			this._errorProvider.ContainerControl = this;
			this._errorProvider.Icon = global::CodeGenerateByDatabase.Properties.Resources.error;
			// 
			// _nameSpaceBox
			// 
			this._nameSpaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._nameSpaceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodeGenerateByDatabase.Properties.Settings.Default, "ClassNameSpace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._nameSpaceBox.Location = new System.Drawing.Point(112, 72);
			this._nameSpaceBox.Name = "_nameSpaceBox";
			this._nameSpaceBox.Size = new System.Drawing.Size(384, 22);
			this._nameSpaceBox.TabIndex = 15;
			this._nameSpaceBox.Text = global::CodeGenerateByDatabase.Properties.Settings.Default.ClassNameSpace;
			this._toolTip.SetToolTip(this._nameSpaceBox, "WCF 則 PAHSCO.WMS\r\n產生:\r\n  PAHSCO.WMS.Domain\r\n  PAHSCO.WMS.Service\r\n\r\n-------------" +
        "------------\r\nMVC 則 PAHSCO.WMS.WebApp\r\n產生:\r\n  PAHSCO.WMS.WebApp.Controllers\r\n  P" +
        "AHSCO.WMS.WebApp.Models");
			this._nameSpaceBox.Validating += new System.ComponentModel.CancelEventHandler(this._nameSpaceBox_Validating);
			// 
			// _dcNameBox
			// 
			this._dcNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._dcNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodeGenerateByDatabase.Properties.Settings.Default, "DataContextName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._dcNameBox.Location = new System.Drawing.Point(112, 104);
			this._dcNameBox.Name = "_dcNameBox";
			this._dcNameBox.Size = new System.Drawing.Size(384, 22);
			this._dcNameBox.TabIndex = 16;
			this._dcNameBox.Text = global::CodeGenerateByDatabase.Properties.Settings.Default.DataContextName;
			this._toolTip.SetToolTip(this._dcNameBox, "Dao 需要的 DataContext 類型名稱 ");
			this._dcNameBox.Validating += new System.ComponentModel.CancelEventHandler(this._dcNameBox_Validating);
			// 
			// _solitionDialog
			// 
			this._solitionDialog.Filter = "Visual Studio Solition|*.sln";
			this._solitionDialog.RestoreDirectory = true;
			this._solitionDialog.Title = "選擇 Solition";
			// 
			// _execBtn
			// 
			this._execBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._execBtn.Font = new System.Drawing.Font("新細明體", 9.75F);
			this._execBtn.Image = global::CodeGenerateByDatabase.Properties.Resources.execute;
			this._execBtn.Location = new System.Drawing.Point(415, 419);
			this._execBtn.Name = "_execBtn";
			this._execBtn.Size = new System.Drawing.Size(70, 27);
			this._execBtn.TabIndex = 62;
			this._execBtn.Text = "產生";
			this._execBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._execBtn.UseVisualStyleBackColor = true;
			this._execBtn.Click += new System.EventHandler(this.execBtn_Click);
			// 
			// _closeBtn
			// 
			this._closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeBtn.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._closeBtn.Image = global::CodeGenerateByDatabase.Properties.Resources.close;
			this._closeBtn.Location = new System.Drawing.Point(505, 419);
			this._closeBtn.Name = "_closeBtn";
			this._closeBtn.Size = new System.Drawing.Size(70, 27);
			this._closeBtn.TabIndex = 63;
			this._closeBtn.Text = "關閉";
			this._closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._closeBtn.UseVisualStyleBackColor = true;
			this._closeBtn.Click += new System.EventHandler(this._closeBtn_Click);
			// 
			// CodeGenerateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 453);
			this.Controls.Add(hSplitContainer);
			this.Controls.Add(this._cntStringBox);
			this.Controls.Add(this._cntStringBtn);
			this.Controls.Add(this._solutionBox);
			this.Controls.Add(this._solutionBtn);
			this.Controls.Add(dcNameLabel);
			this.Controls.Add(this._dcNameBox);
			this.Controls.Add(nameSpaceLabel);
			this.Controls.Add(this._nameSpaceBox);
			this.Controls.Add(this._isOverride);
			this.Controls.Add(this._execBtn);
			this.Controls.Add(this._closeBtn);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Size", global::CodeGenerateByDatabase.Properties.Settings.Default, "FormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Icon = global::CodeGenerateByDatabase.Properties.Resources.logo;
			this.MinimumSize = new System.Drawing.Size(400, 380);
			this.Name = "CodeGenerateForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "從 DB 結構產生程式";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeGenerateForm_FormClosing);
			hSplitContainer.Panel1.ResumeLayout(false);
			hSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(hSplitContainer)).EndInit();
			hSplitContainer.ResumeLayout(false);
			vSplitContainer.Panel1.ResumeLayout(false);
			vSplitContainer.Panel2.ResumeLayout(false);
			vSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(vSplitContainer)).EndInit();
			vSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _cntStringBox;
		private System.Windows.Forms.Button _cntStringBtn;
		private System.Windows.Forms.ComboBox _solutionBox;
		private System.Windows.Forms.Button _solutionBtn;
		private System.Windows.Forms.TextBox _nameSpaceBox;
		private System.Windows.Forms.TextBox _dcNameBox;
		private System.Windows.Forms.FlowLayoutPanel _templateSelect;
		private System.Windows.Forms.CheckedListBox _tableSelect;
		private System.Windows.Forms.TextBox _execStatusMsg;
		private System.Windows.Forms.CheckBox _isOverride;
		private System.Windows.Forms.Button _execBtn;
		private System.Windows.Forms.Button _closeBtn;
		private System.Windows.Forms.OpenFileDialog _solitionDialog;
		private System.Windows.Forms.ErrorProvider _errorProvider;
		private System.Windows.Forms.ToolTip _toolTip;
    }
}


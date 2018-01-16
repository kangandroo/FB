namespace ipost.groups
{
    partial class group_invite
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupGroups = new System.Windows.Forms.GroupBox();
            this.gridGroups = new DevExpress.XtraGrid.GridControl();
            this.grGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.group_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.group_url = new DevExpress.XtraGrid.Columns.GridColumn();
            this.group_result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.group_tick = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInvite = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInviteName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupGroups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 319);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupGroups
            // 
            this.groupGroups.Controls.Add(this.gridGroups);
            this.groupGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGroups.Location = new System.Drawing.Point(303, 3);
            this.groupGroups.Name = "groupGroups";
            this.groupGroups.Size = new System.Drawing.Size(630, 313);
            this.groupGroups.TabIndex = 0;
            this.groupGroups.TabStop = false;
            this.groupGroups.Text = "Danh sách nhóm";
            // 
            // gridGroups
            // 
            this.gridGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridGroups.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridGroups.Location = new System.Drawing.Point(3, 16);
            this.gridGroups.MainView = this.grGroups;
            this.gridGroups.Name = "gridGroups";
            this.gridGroups.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemMRUEdit1,
            this.repositoryItemProgressBar1,
            this.repositoryItemTextEdit1,
            this.repositoryItemProgressBar2});
            this.gridGroups.Size = new System.Drawing.Size(624, 294);
            this.gridGroups.TabIndex = 12;
            this.gridGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grGroups});
            // 
            // grGroups
            // 
            this.grGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.group_name,
            this.group_url,
            this.group_result,
            this.group_tick});
            this.grGroups.GridControl = this.gridGroups;
            this.grGroups.Name = "grGroups";
            this.grGroups.OptionsSelection.MultiSelect = true;
            this.grGroups.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grGroups.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.grGroups.OptionsView.ShowGroupPanel = false;
            this.grGroups.RowCountChanged += new System.EventHandler(this.grGroups_RowCountChanged);
            // 
            // group_name
            // 
            this.group_name.Caption = "Tên nhóm";
            this.group_name.FieldName = "group_name";
            this.group_name.Name = "group_name";
            this.group_name.OptionsColumn.AllowEdit = false;
            this.group_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.group_name.OptionsColumn.ReadOnly = true;
            this.group_name.Visible = true;
            this.group_name.VisibleIndex = 0;
            this.group_name.Width = 133;
            // 
            // group_url
            // 
            this.group_url.Caption = "URL";
            this.group_url.CustomizationCaption = "URL";
            this.group_url.FieldName = "group_url";
            this.group_url.Name = "group_url";
            this.group_url.OptionsColumn.AllowEdit = false;
            this.group_url.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.group_url.OptionsColumn.ReadOnly = true;
            this.group_url.Visible = true;
            this.group_url.VisibleIndex = 1;
            this.group_url.Width = 133;
            // 
            // group_result
            // 
            this.group_result.Caption = "Kết quả";
            this.group_result.FieldName = "group_result";
            this.group_result.Name = "group_result";
            this.group_result.OptionsColumn.AllowEdit = false;
            this.group_result.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.group_result.OptionsColumn.ReadOnly = true;
            this.group_result.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.group_result.Visible = true;
            this.group_result.VisibleIndex = 2;
            this.group_result.Width = 133;
            // 
            // group_tick
            // 
            this.group_tick.Caption = "Đăng";
            this.group_tick.ColumnEdit = this.repositoryItemCheckEdit1;
            this.group_tick.FieldName = "group_tick";
            this.group_tick.Name = "group_tick";
            this.group_tick.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.group_tick.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.group_tick.Visible = true;
            this.group_tick.VisibleIndex = 3;
            this.group_tick.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemMRUEdit1
            // 
            this.repositoryItemMRUEdit1.AutoHeight = false;
            this.repositoryItemMRUEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMRUEdit1.Name = "repositoryItemMRUEdit1";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemProgressBar2
            // 
            this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInvite);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDelay);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtInviteName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(177, 153);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(112, 23);
            this.btnInvite.TabIndex = 23;
            this.btnInvite.Text = "Mời tham gia nhóm";
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bí quyết tăng nhanh số lượng nhóm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(6, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "*Tên hiển thị bình thường. Ví dụ: Đào Tuấn Anh";
            // 
            // txtDelay
            // 
            this.txtDelay.ForeColor = System.Drawing.Color.Black;
            this.txtDelay.Location = new System.Drawing.Point(77, 155);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(42, 20);
            this.txtDelay.TabIndex = 20;
            this.txtDelay.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Delay: (giây)";
            // 
            // txtInviteName
            // 
            this.txtInviteName.ForeColor = System.Drawing.Color.Black;
            this.txtInviteName.Location = new System.Drawing.Point(102, 100);
            this.txtInviteName.Name = "txtInviteName";
            this.txtInviteName.Size = new System.Drawing.Size(187, 20);
            this.txtInviteName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tên muốn mời (*):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(82, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "MỜI THAM GIA NHÓM";
            // 
            // group_invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "group_invite";
            this.Text = "Mời nhóm";
            this.Shown += new System.EventHandler(this.group_invite_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupGroups;
        private DevExpress.XtraGrid.GridControl gridGroups;
        public DevExpress.XtraGrid.Views.Grid.GridView grGroups;
        private DevExpress.XtraGrid.Columns.GridColumn group_name;
        private DevExpress.XtraGrid.Columns.GridColumn group_url;
        private DevExpress.XtraGrid.Columns.GridColumn group_result;
        private DevExpress.XtraGrid.Columns.GridColumn group_tick;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnInvite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtInviteName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

    }
}
namespace ipost.groups
{
    partial class group_join
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJoin = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGroupSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGroupSearchMin = new System.Windows.Forms.TextBox();
            this.txtGroupSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupGroups.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupGroups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupGroups
            // 
            this.groupGroups.Controls.Add(this.panel1);
            this.groupGroups.Controls.Add(this.gridGroups);
            this.groupGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGroups.Location = new System.Drawing.Point(303, 3);
            this.groupGroups.Name = "groupGroups";
            this.groupGroups.Size = new System.Drawing.Size(455, 337);
            this.groupGroups.TabIndex = 0;
            this.groupGroups.TabStop = false;
            this.groupGroups.Text = "Danh sách nhóm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDelay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnJoin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 23);
            this.panel1.TabIndex = 14;
            // 
            // txtDelay
            // 
            this.txtDelay.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDelay.Location = new System.Drawing.Point(43, 0);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(45, 20);
            this.txtDelay.TabIndex = 1;
            this.txtDelay.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay:";
            // 
            // btnJoin
            // 
            this.btnJoin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnJoin.Image = global::ipost.Properties.Resources.number2;
            this.btnJoin.Location = new System.Drawing.Point(317, 0);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(132, 23);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Gia nhập nhóm";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
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
            this.gridGroups.Size = new System.Drawing.Size(449, 318);
            this.gridGroups.TabIndex = 13;
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
            this.group_result.Caption = "SL Thành viên";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGroupSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtGroupSearchMin);
            this.groupBox1.Controls.Add(this.txtGroupSearch);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnGroupSearch
            // 
            this.btnGroupSearch.Image = global::ipost.Properties.Resources.number1;
            this.btnGroupSearch.Location = new System.Drawing.Point(142, 198);
            this.btnGroupSearch.Name = "btnGroupSearch";
            this.btnGroupSearch.Size = new System.Drawing.Size(122, 23);
            this.btnGroupSearch.TabIndex = 24;
            this.btnGroupSearch.Text = "Tìm kiếm nhóm";
            this.btnGroupSearch.Click += new System.EventHandler(this.btnGroupSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nâng cao độ tiếp cận nhờ chất lượng nhóm tốt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(65, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "TỰ ĐỘNG GIA NHẬP NHÓM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(18, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Số lượng thành viên tối thiểu:";
            // 
            // txtGroupSearchMin
            // 
            this.txtGroupSearchMin.ForeColor = System.Drawing.Color.Black;
            this.txtGroupSearchMin.Location = new System.Drawing.Point(21, 159);
            this.txtGroupSearchMin.Name = "txtGroupSearchMin";
            this.txtGroupSearchMin.Size = new System.Drawing.Size(243, 20);
            this.txtGroupSearchMin.TabIndex = 9;
            this.txtGroupSearchMin.Text = "1000";
            // 
            // txtGroupSearch
            // 
            this.txtGroupSearch.ForeColor = System.Drawing.Color.Black;
            this.txtGroupSearch.Location = new System.Drawing.Point(21, 112);
            this.txtGroupSearch.Name = "txtGroupSearch";
            this.txtGroupSearch.Size = new System.Drawing.Size(243, 20);
            this.txtGroupSearch.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(18, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Từ khóa tìm kiếm:";
            // 
            // group_join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "group_join";
            this.Text = "Tự động gia nhập";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupGroups.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnJoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtGroupSearchMin;
        public System.Windows.Forms.TextBox txtGroupSearch;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnGroupSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label2;
    }
}
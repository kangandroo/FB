namespace ipost.events
{
    partial class events
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.xtraTabEvents = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pbEventInvite = new System.Windows.Forms.PictureBox();
            this.btnEventsInvite = new DevExpress.XtraEditors.SimpleButton();
            this.btnEventsGetLink = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.gridFriends = new DevExpress.XtraGrid.GridControl();
            this.grFriends = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.user_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.groupFriends = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEvents)).BeginInit();
            this.xtraTabEvents.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventInvite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.groupFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabEvents
            // 
            this.xtraTabEvents.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabEvents.Location = new System.Drawing.Point(5, 5);
            this.xtraTabEvents.Name = "xtraTabEvents";
            this.xtraTabEvents.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabEvents.Size = new System.Drawing.Size(300, 381);
            this.xtraTabEvents.TabIndex = 0;
            this.xtraTabEvents.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pbEventInvite);
            this.xtraTabPage1.Controls.Add(this.btnEventsInvite);
            this.xtraTabPage1.Controls.Add(this.btnEventsGetLink);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.cbEvents);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(294, 353);
            this.xtraTabPage1.Text = "Chia sẻ sự kiện";
            // 
            // pbEventInvite
            // 
            this.pbEventInvite.Image = global::ipost.Properties.Resources.loader;
            this.pbEventInvite.Location = new System.Drawing.Point(168, 75);
            this.pbEventInvite.Name = "pbEventInvite";
            this.pbEventInvite.Size = new System.Drawing.Size(20, 20);
            this.pbEventInvite.TabIndex = 4;
            this.pbEventInvite.TabStop = false;
            this.pbEventInvite.Visible = false;
            // 
            // btnEventsInvite
            // 
            this.btnEventsInvite.Location = new System.Drawing.Point(192, 74);
            this.btnEventsInvite.Name = "btnEventsInvite";
            this.btnEventsInvite.Size = new System.Drawing.Size(88, 23);
            this.btnEventsInvite.TabIndex = 2;
            this.btnEventsInvite.Text = "Mời bạn bè";
            this.btnEventsInvite.Click += new System.EventHandler(this.btnEventsInvite_Click);
            // 
            // btnEventsGetLink
            // 
            this.btnEventsGetLink.Location = new System.Drawing.Point(11, 74);
            this.btnEventsGetLink.Name = "btnEventsGetLink";
            this.btnEventsGetLink.Size = new System.Drawing.Size(131, 23);
            this.btnEventsGetLink.TabIndex = 2;
            this.btnEventsGetLink.Text = "Lấy Link chia sẻ";
            this.btnEventsGetLink.Click += new System.EventHandler(this.btnEventsGetLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn sự kiện:";
            // 
            // cbEvents
            // 
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(11, 47);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(269, 21);
            this.cbEvents.TabIndex = 0;
            // 
            // gridFriends
            // 
            this.gridFriends.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridFriends.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridFriends.Location = new System.Drawing.Point(3, 16);
            this.gridFriends.MainView = this.grFriends;
            this.gridFriends.Name = "gridFriends";
            this.gridFriends.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemMRUEdit1,
            this.repositoryItemProgressBar1,
            this.repositoryItemTextEdit1,
            this.repositoryItemProgressBar2});
            this.gridFriends.Size = new System.Drawing.Size(689, 362);
            this.gridFriends.TabIndex = 13;
            this.gridFriends.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grFriends});
            // 
            // grFriends
            // 
            this.grFriends.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.user_name});
            this.grFriends.GridControl = this.gridFriends;
            this.grFriends.Name = "grFriends";
            this.grFriends.OptionsSelection.MultiSelect = true;
            this.grFriends.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grFriends.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.grFriends.OptionsView.ShowGroupPanel = false;
            this.grFriends.RowCountChanged += new System.EventHandler(this.grFriends_RowCountChanged);
            // 
            // user_name
            // 
            this.user_name.Caption = "Tên";
            this.user_name.FieldName = "user_name";
            this.user_name.Name = "user_name";
            this.user_name.OptionsColumn.AllowEdit = false;
            this.user_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.user_name.OptionsColumn.ReadOnly = true;
            this.user_name.Visible = true;
            this.user_name.VisibleIndex = 0;
            this.user_name.Width = 133;
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
            // groupFriends
            // 
            this.groupFriends.Controls.Add(this.gridFriends);
            this.groupFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFriends.Location = new System.Drawing.Point(305, 5);
            this.groupFriends.Name = "groupFriends";
            this.groupFriends.Size = new System.Drawing.Size(695, 381);
            this.groupFriends.TabIndex = 14;
            this.groupFriends.TabStop = false;
            this.groupFriends.Text = "Danh sách mời";
            // 
            // events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 391);
            this.Controls.Add(this.groupFriends);
            this.Controls.Add(this.xtraTabEvents);
            this.Name = "events";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Sự kiện";
            this.Shown += new System.EventHandler(this.events_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEvents)).EndInit();
            this.xtraTabEvents.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventInvite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.groupFriends.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridFriends;
        public DevExpress.XtraGrid.Views.Grid.GridView grFriends;
        private DevExpress.XtraGrid.Columns.GridColumn user_name;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnEventsGetLink;
        public DevExpress.XtraTab.XtraTabControl xtraTabEvents;
        private DevExpress.XtraEditors.SimpleButton btnEventsInvite;
        private System.Windows.Forms.PictureBox pbEventInvite;
        private System.Windows.Forms.GroupBox groupFriends;
    }
}
namespace ipost.fanpage_share
{
    partial class fanpage_share
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridFanpageShare = new DevExpress.XtraGrid.GridControl();
            this.grFanpageShare = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.target_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.target_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.target_result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.target_tick = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFriends = new System.Windows.Forms.CheckBox();
            this.cbGroups = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabShare = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFanpageShareDelay = new System.Windows.Forms.TextBox();
            this.btnFanpageShare = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFanpageLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFanpageContent = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pbFanpageInvite = new System.Windows.Forms.PictureBox();
            this.btnFanpageInvite = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPages = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFanpageShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grFanpageShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabShare)).BeginInit();
            this.xtraTabShare.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanpageInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridFanpageShare);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(597, 330);
            this.panel1.TabIndex = 1;
            // 
            // gridFanpageShare
            // 
            this.gridFanpageShare.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridFanpageShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFanpageShare.Location = new System.Drawing.Point(5, 47);
            this.gridFanpageShare.MainView = this.grFanpageShare;
            this.gridFanpageShare.Name = "gridFanpageShare";
            this.gridFanpageShare.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemProgressBar1});
            this.gridFanpageShare.Size = new System.Drawing.Size(587, 254);
            this.gridFanpageShare.TabIndex = 2;
            this.gridFanpageShare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grFanpageShare});
            // 
            // grFanpageShare
            // 
            this.grFanpageShare.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.target_id,
            this.target_name,
            this.target_result,
            this.target_tick});
            this.grFanpageShare.GridControl = this.gridFanpageShare;
            this.grFanpageShare.Name = "grFanpageShare";
            this.grFanpageShare.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grFanpageShare.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.grFanpageShare.OptionsView.ShowGroupPanel = false;
            this.grFanpageShare.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // target_id
            // 
            this.target_id.Caption = "ID";
            this.target_id.FieldName = "target_id";
            this.target_id.Name = "target_id";
            this.target_id.OptionsColumn.AllowEdit = false;
            this.target_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.target_id.Visible = true;
            this.target_id.VisibleIndex = 0;
            this.target_id.Width = 109;
            // 
            // target_name
            // 
            this.target_name.Caption = "Tên";
            this.target_name.FieldName = "target_name";
            this.target_name.Name = "target_name";
            this.target_name.OptionsColumn.AllowEdit = false;
            this.target_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.target_name.Visible = true;
            this.target_name.VisibleIndex = 1;
            this.target_name.Width = 109;
            // 
            // target_result
            // 
            this.target_result.Caption = "Bài đăng";
            this.target_result.ColumnEdit = this.repositoryItemProgressBar1;
            this.target_result.FieldName = "target_result";
            this.target_result.Name = "target_result";
            this.target_result.OptionsColumn.AllowEdit = false;
            this.target_result.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.target_result.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.target_result.Visible = true;
            this.target_result.VisibleIndex = 2;
            this.target_result.Width = 109;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // target_tick
            // 
            this.target_tick.Caption = "Đăng?";
            this.target_tick.ColumnEdit = this.repositoryItemCheckEdit1;
            this.target_tick.FieldName = "target_tick";
            this.target_tick.Name = "target_tick";
            this.target_tick.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.target_tick.Visible = true;
            this.target_tick.VisibleIndex = 3;
            this.target_tick.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbFriends);
            this.panel2.Controls.Add(this.cbGroups);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 42);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nơi bạn muốn đặt quảng cáo?";
            // 
            // cbFriends
            // 
            this.cbFriends.AutoSize = true;
            this.cbFriends.ForeColor = System.Drawing.Color.Black;
            this.cbFriends.Location = new System.Drawing.Point(317, 17);
            this.cbFriends.Name = "cbFriends";
            this.cbFriends.Size = new System.Drawing.Size(83, 17);
            this.cbFriends.TabIndex = 0;
            this.cbFriends.Text = "Wall bạn bè";
            this.cbFriends.UseVisualStyleBackColor = true;
            this.cbFriends.CheckedChanged += new System.EventHandler(this.cbFriends_CheckedChanged);
            // 
            // cbGroups
            // 
            this.cbGroups.AutoSize = true;
            this.cbGroups.Checked = true;
            this.cbGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGroups.ForeColor = System.Drawing.Color.Black;
            this.cbGroups.Location = new System.Drawing.Point(201, 17);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(97, 17);
            this.cbGroups.TabIndex = 0;
            this.cbGroups.Text = "Nhóm (Groups)";
            this.cbGroups.UseVisualStyleBackColor = true;
            this.cbGroups.CheckedChanged += new System.EventHandler(this.cbGroups_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 301);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel3.Size = new System.Drawing.Size(587, 24);
            this.panel3.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(470, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 20);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Xuất kết quả đăng";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // xtraTabShare
            // 
            this.xtraTabShare.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabShare.Location = new System.Drawing.Point(5, 5);
            this.xtraTabShare.Name = "xtraTabShare";
            this.xtraTabShare.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabShare.Size = new System.Drawing.Size(300, 330);
            this.xtraTabShare.TabIndex = 2;
            this.xtraTabShare.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtFanpageShareDelay);
            this.xtraTabPage1.Controls.Add(this.btnFanpageShare);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtFanpageLink);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtFanpageContent);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(294, 302);
            this.xtraTabPage1.Text = "Quảng cáo đường dẫn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delay:";
            // 
            // txtFanpageShareDelay
            // 
            this.txtFanpageShareDelay.Location = new System.Drawing.Point(49, 208);
            this.txtFanpageShareDelay.Name = "txtFanpageShareDelay";
            this.txtFanpageShareDelay.Size = new System.Drawing.Size(31, 20);
            this.txtFanpageShareDelay.TabIndex = 8;
            this.txtFanpageShareDelay.Text = "30";
            this.txtFanpageShareDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFanpageShare
            // 
            this.btnFanpageShare.Location = new System.Drawing.Point(176, 206);
            this.btnFanpageShare.Name = "btnFanpageShare";
            this.btnFanpageShare.Size = new System.Drawing.Size(104, 23);
            this.btnFanpageShare.TabIndex = 7;
            this.btnFanpageShare.Text = "Đăng bài";
            this.btnFanpageShare.Click += new System.EventHandler(this.btnFanpageShare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link:";
            // 
            // txtFanpageLink
            // 
            this.txtFanpageLink.Location = new System.Drawing.Point(11, 86);
            this.txtFanpageLink.Name = "txtFanpageLink";
            this.txtFanpageLink.Size = new System.Drawing.Size(269, 20);
            this.txtFanpageLink.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập link (đường dẫn) bài viết/ảnh trên Page của bạn hoặc một đường dẫn tùy ý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kèm nội dung:";
            // 
            // txtFanpageContent
            // 
            this.txtFanpageContent.Location = new System.Drawing.Point(11, 147);
            this.txtFanpageContent.Multiline = true;
            this.txtFanpageContent.Name = "txtFanpageContent";
            this.txtFanpageContent.Size = new System.Drawing.Size(269, 41);
            this.txtFanpageContent.TabIndex = 2;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pbFanpageInvite);
            this.xtraTabPage2.Controls.Add(this.btnFanpageInvite);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.cbPages);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(294, 312);
            this.xtraTabPage2.Text = "Mời Like Fanpage";
            // 
            // pbFanpageInvite
            // 
            this.pbFanpageInvite.Image = global::ipost.Properties.Resources.loader;
            this.pbFanpageInvite.Location = new System.Drawing.Point(134, 73);
            this.pbFanpageInvite.Name = "pbFanpageInvite";
            this.pbFanpageInvite.Size = new System.Drawing.Size(20, 20);
            this.pbFanpageInvite.TabIndex = 3;
            this.pbFanpageInvite.TabStop = false;
            this.pbFanpageInvite.Visible = false;
            // 
            // btnFanpageInvite
            // 
            this.btnFanpageInvite.Location = new System.Drawing.Point(160, 71);
            this.btnFanpageInvite.Name = "btnFanpageInvite";
            this.btnFanpageInvite.Size = new System.Drawing.Size(119, 23);
            this.btnFanpageInvite.TabIndex = 2;
            this.btnFanpageInvite.Text = "Mời Like Fanpage";
            this.btnFanpageInvite.Click += new System.EventHandler(this.btnLikeInvite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn Fanpage:";
            // 
            // cbPages
            // 
            this.cbPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPages.FormattingEnabled = true;
            this.cbPages.Location = new System.Drawing.Point(11, 44);
            this.cbPages.Name = "cbPages";
            this.cbPages.Size = new System.Drawing.Size(268, 21);
            this.cbPages.TabIndex = 0;
            // 
            // fanpage_share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xtraTabShare);
            this.Name = "fanpage_share";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "QC Fanpage/Link";
            this.Shown += new System.EventHandler(this.fanpage_share_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFanpageShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grFanpageShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabShare)).EndInit();
            this.xtraTabShare.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanpageInvite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridFanpageShare;
        private DevExpress.XtraGrid.Views.Grid.GridView grFanpageShare;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn target_id;
        private DevExpress.XtraGrid.Columns.GridColumn target_name;
        private DevExpress.XtraGrid.Columns.GridColumn target_tick;
        private DevExpress.XtraGrid.Columns.GridColumn target_result;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraTab.XtraTabControl xtraTabShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbGroups;
        private System.Windows.Forms.CheckBox cbFriends;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFanpageContent;
        private DevExpress.XtraEditors.SimpleButton btnFanpageShare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFanpageShareDelay;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPages;
        private DevExpress.XtraEditors.SimpleButton btnFanpageInvite;
        private System.Windows.Forms.PictureBox pbFanpageInvite;
        public System.Windows.Forms.TextBox txtFanpageLink;
    }
}
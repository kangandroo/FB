namespace ipost.comment
{
    partial class comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comment));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cbOnlyMe = new System.Windows.Forms.CheckBox();
            this.btnComment = new DevExpress.XtraEditors.SimpleButton();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radPage = new System.Windows.Forms.RadioButton();
            this.radFile = new System.Windows.Forms.RadioButton();
            this.radScan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComments = new System.Windows.Forms.GroupBox();
            this.gridComments = new DevExpress.XtraGrid.GridControl();
            this.grComments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comment_content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comment_url = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupComments, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.cbOnlyMe);
            this.panel1.Controls.Add(this.btnComment);
            this.panel1.Controls.Add(this.txtDelay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radPage);
            this.panel1.Controls.Add(this.radFile);
            this.panel1.Controls.Add(this.radScan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 433);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bình luận vào các Page bạn đã \"Thích\"";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFile.ForeColor = System.Drawing.Color.Black;
            this.btnFile.Location = new System.Drawing.Point(205, 219);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 22);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Chọn File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.ForeColor = System.Drawing.Color.Black;
            this.txtFile.Location = new System.Drawing.Point(36, 220);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(169, 20);
            this.txtFile.TabIndex = 0;
            this.txtFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // cbOnlyMe
            // 
            this.cbOnlyMe.AutoSize = true;
            this.cbOnlyMe.ForeColor = System.Drawing.Color.Black;
            this.cbOnlyMe.Location = new System.Drawing.Point(40, 163);
            this.cbOnlyMe.Name = "cbOnlyMe";
            this.cbOnlyMe.Size = new System.Drawing.Size(139, 17);
            this.cbOnlyMe.TabIndex = 0;
            this.cbOnlyMe.Text = "Chỉ bình luận bài của tôi";
            this.cbOnlyMe.UseVisualStyleBackColor = true;
            this.cbOnlyMe.Click += new System.EventHandler(this.cbOnlyMe_Click);
            // 
            // btnComment
            // 
            this.btnComment.Image = ((System.Drawing.Image)(resources.GetObject("btnComment.Image")));
            this.btnComment.Location = new System.Drawing.Point(196, 320);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(90, 23);
            this.btnComment.TabIndex = 17;
            this.btnComment.Text = "Bình luận";
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.ForeColor = System.Drawing.Color.Black;
            this.txtDelay.Location = new System.Drawing.Point(137, 322);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(40, 20);
            this.txtDelay.TabIndex = 16;
            this.txtDelay.Text = "30";
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delay:";
            // 
            // radPage
            // 
            this.radPage.AutoSize = true;
            this.radPage.ForeColor = System.Drawing.Color.Black;
            this.radPage.Location = new System.Drawing.Point(18, 265);
            this.radPage.Name = "radPage";
            this.radPage.Size = new System.Drawing.Size(181, 17);
            this.radPage.TabIndex = 14;
            this.radPage.Text = "Bình luận Top bài đăng Fanpage";
            this.radPage.UseVisualStyleBackColor = true;
            // 
            // radFile
            // 
            this.radFile.AutoSize = true;
            this.radFile.ForeColor = System.Drawing.Color.Black;
            this.radFile.Location = new System.Drawing.Point(18, 202);
            this.radFile.Name = "radFile";
            this.radFile.Size = new System.Drawing.Size(179, 17);
            this.radFile.TabIndex = 12;
            this.radFile.Text = "Bình luận từ danh sách bài đăng";
            this.radFile.UseVisualStyleBackColor = true;
            // 
            // radScan
            // 
            this.radScan.AutoSize = true;
            this.radScan.Checked = true;
            this.radScan.ForeColor = System.Drawing.Color.Black;
            this.radScan.Location = new System.Drawing.Point(18, 143);
            this.radScan.Name = "radScan";
            this.radScan.Size = new System.Drawing.Size(201, 17);
            this.radScan.TabIndex = 10;
            this.radScan.TabStop = true;
            this.radScan.Text = "Tự động quét và bình luận trên nhóm";
            this.radScan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cách thức:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(88, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "TỰ ĐỘNG BÌNH LUẬN";
            // 
            // txtComment
            // 
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.Location = new System.Drawing.Point(7, 61);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(279, 41);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung bình luận:";
            // 
            // groupComments
            // 
            this.groupComments.Controls.Add(this.gridComments);
            this.groupComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupComments.Location = new System.Drawing.Point(303, 3);
            this.groupComments.Name = "groupComments";
            this.groupComments.Size = new System.Drawing.Size(502, 433);
            this.groupComments.TabIndex = 1;
            this.groupComments.TabStop = false;
            this.groupComments.Text = "Danh sách bình luận";
            // 
            // gridComments
            // 
            this.gridComments.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridComments.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridComments.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridComments.Location = new System.Drawing.Point(3, 16);
            this.gridComments.MainView = this.grComments;
            this.gridComments.Name = "gridComments";
            this.gridComments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemMRUEdit1,
            this.repositoryItemProgressBar1,
            this.repositoryItemTextEdit1,
            this.repositoryItemProgressBar2});
            this.gridComments.Size = new System.Drawing.Size(496, 414);
            this.gridComments.TabIndex = 15;
            this.gridComments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grComments});
            // 
            // grComments
            // 
            this.grComments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.comment_content,
            this.comment_url});
            this.grComments.GridControl = this.gridComments;
            this.grComments.Name = "grComments";
            this.grComments.OptionsSelection.MultiSelect = true;
            this.grComments.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grComments.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.grComments.OptionsView.ShowGroupPanel = false;
            this.grComments.RowCountChanged += new System.EventHandler(this.grComments_RowCountChanged);
            // 
            // comment_content
            // 
            this.comment_content.Caption = "Nội dung";
            this.comment_content.FieldName = "comment_content";
            this.comment_content.Name = "comment_content";
            this.comment_content.OptionsColumn.AllowEdit = false;
            this.comment_content.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.comment_content.OptionsColumn.ReadOnly = true;
            this.comment_content.Visible = true;
            this.comment_content.VisibleIndex = 0;
            this.comment_content.Width = 338;
            // 
            // comment_url
            // 
            this.comment_url.Caption = "URL";
            this.comment_url.FieldName = "comment_url";
            this.comment_url.Name = "comment_url";
            this.comment_url.OptionsColumn.AllowEdit = false;
            this.comment_url.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.comment_url.Visible = true;
            this.comment_url.VisibleIndex = 1;
            this.comment_url.Width = 309;
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
            // comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "comment";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Tự động bình luận";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RadioButton radFile;
        private System.Windows.Forms.CheckBox cbOnlyMe;
        private System.Windows.Forms.RadioButton radPage;
        private DevExpress.XtraEditors.SimpleButton btnComment;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupComments;
        private DevExpress.XtraGrid.GridControl gridComments;
        public DevExpress.XtraGrid.Views.Grid.GridView grComments;
        private DevExpress.XtraGrid.Columns.GridColumn comment_content;
        private DevExpress.XtraGrid.Columns.GridColumn comment_url;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
    }
}
namespace ipost.interactions
{
    partial class interactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interactions));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupInteractionsInput = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInteractionsClear = new DevExpress.XtraEditors.SimpleButton();
            this.gridInteractions = new DevExpress.XtraGrid.GridControl();
            this.grInteractions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user_action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInteractionsInput = new System.Windows.Forms.TextBox();
            this.btnInteractionsInput = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabInteractions = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPM = new DevExpress.XtraEditors.SimpleButton();
            this.btnPMInsertName = new System.Windows.Forms.Button();
            this.txtPMDelay = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPM = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPokeDelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPoke = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLikeDelay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLikeNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLike = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddDelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupInteractionsInput.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInteractions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInteractions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabInteractions)).BeginInit();
            this.xtraTabInteractions.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.groupInteractionsInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xtraTabInteractions, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 340);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupInteractionsInput
            // 
            this.groupInteractionsInput.Controls.Add(this.gridInteractions);
            this.groupInteractionsInput.Controls.Add(this.panel2);
            this.groupInteractionsInput.Controls.Add(this.panel1);
            this.groupInteractionsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInteractionsInput.Location = new System.Drawing.Point(3, 3);
            this.groupInteractionsInput.Name = "groupInteractionsInput";
            this.groupInteractionsInput.Size = new System.Drawing.Size(465, 334);
            this.groupInteractionsInput.TabIndex = 0;
            this.groupInteractionsInput.TabStop = false;
            this.groupInteractionsInput.Text = "Khách hàng mục tiêu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInteractionsClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 27);
            this.panel2.TabIndex = 2;
            // 
            // btnInteractionsClear
            // 
            this.btnInteractionsClear.Location = new System.Drawing.Point(3, 4);
            this.btnInteractionsClear.Name = "btnInteractionsClear";
            this.btnInteractionsClear.Size = new System.Drawing.Size(75, 20);
            this.btnInteractionsClear.TabIndex = 0;
            this.btnInteractionsClear.Text = "Xóa hết";
            this.btnInteractionsClear.Click += new System.EventHandler(this.btnInteractionsClear_Click);
            // 
            // gridInteractions
            // 
            this.gridInteractions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridInteractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInteractions.Location = new System.Drawing.Point(3, 48);
            this.gridInteractions.MainView = this.grInteractions;
            this.gridInteractions.Name = "gridInteractions";
            this.gridInteractions.Size = new System.Drawing.Size(459, 256);
            this.gridInteractions.TabIndex = 0;
            this.gridInteractions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInteractions});
            this.gridInteractions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridInteractions_KeyDown);
            // 
            // grInteractions
            // 
            this.grInteractions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.user_id,
            this.user_name,
            this.user_action});
            this.grInteractions.GridControl = this.gridInteractions;
            this.grInteractions.Name = "grInteractions";
            this.grInteractions.OptionsView.ShowGroupPanel = false;
            this.grInteractions.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grInteractions.RowCountChanged += new System.EventHandler(this.grInteractions_RowCountChanged);
            // 
            // user_id
            // 
            this.user_id.Caption = "ID";
            this.user_id.FieldName = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.OptionsColumn.AllowEdit = false;
            this.user_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.user_id.Visible = true;
            this.user_id.VisibleIndex = 0;
            // 
            // user_name
            // 
            this.user_name.Caption = "Tên";
            this.user_name.FieldName = "user_name";
            this.user_name.Name = "user_name";
            this.user_name.OptionsColumn.AllowEdit = false;
            this.user_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.user_name.Visible = true;
            this.user_name.VisibleIndex = 1;
            // 
            // user_action
            // 
            this.user_action.Caption = "Tương tác";
            this.user_action.FieldName = "user_action";
            this.user_action.Name = "user_action";
            this.user_action.OptionsColumn.AllowEdit = false;
            this.user_action.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.user_action.Visible = true;
            this.user_action.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInteractionsInput);
            this.panel1.Controls.Add(this.btnInteractionsInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 32);
            this.panel1.TabIndex = 1;
            // 
            // txtInteractionsInput
            // 
            this.txtInteractionsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInteractionsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInteractionsInput.Location = new System.Drawing.Point(3, 6);
            this.txtInteractionsInput.Name = "txtInteractionsInput";
            this.txtInteractionsInput.ReadOnly = true;
            this.txtInteractionsInput.Size = new System.Drawing.Size(309, 20);
            this.txtInteractionsInput.TabIndex = 2;
            // 
            // btnInteractionsInput
            // 
            this.btnInteractionsInput.Location = new System.Drawing.Point(318, 4);
            this.btnInteractionsInput.Name = "btnInteractionsInput";
            this.btnInteractionsInput.Size = new System.Drawing.Size(110, 22);
            this.btnInteractionsInput.TabIndex = 1;
            this.btnInteractionsInput.Text = "Nhập File UID";
            this.btnInteractionsInput.Click += new System.EventHandler(this.btnInteractionsInput_Click);
            // 
            // xtraTabInteractions
            // 
            this.xtraTabInteractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabInteractions.Location = new System.Drawing.Point(474, 3);
            this.xtraTabInteractions.Name = "xtraTabInteractions";
            this.xtraTabInteractions.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabInteractions.Size = new System.Drawing.Size(394, 334);
            this.xtraTabInteractions.TabIndex = 1;
            this.xtraTabInteractions.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnPM);
            this.xtraTabPage1.Controls.Add(this.btnPMInsertName);
            this.xtraTabPage1.Controls.Add(this.txtPMDelay);
            this.xtraTabPage1.Controls.Add(this.label20);
            this.xtraTabPage1.Controls.Add(this.label29);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtPM);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(388, 306);
            this.xtraTabPage1.Text = "Inbox";
            // 
            // btnPM
            // 
            this.btnPM.Image = ((System.Drawing.Image)(resources.GetObject("btnPM.Image")));
            this.btnPM.Location = new System.Drawing.Point(252, 155);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(117, 23);
            this.btnPM.TabIndex = 18;
            this.btnPM.Text = "Gửi hàng loạt";
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnPMInsertName
            // 
            this.btnPMInsertName.Location = new System.Drawing.Point(48, 126);
            this.btnPMInsertName.Name = "btnPMInsertName";
            this.btnPMInsertName.Size = new System.Drawing.Size(50, 23);
            this.btnPMInsertName.TabIndex = 17;
            this.btnPMInsertName.Text = "{Tên}";
            this.btnPMInsertName.UseVisualStyleBackColor = true;
            this.btnPMInsertName.Click += new System.EventHandler(this.btnPMInsertName_Click);
            // 
            // txtPMDelay
            // 
            this.txtPMDelay.Location = new System.Drawing.Point(327, 128);
            this.txtPMDelay.Name = "txtPMDelay";
            this.txtPMDelay.Size = new System.Drawing.Size(42, 20);
            this.txtPMDelay.TabIndex = 14;
            this.txtPMDelay.Text = "10";
            this.txtPMDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(284, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Delay:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 131);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "Chèn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soạn tin nhắn:";
            // 
            // txtPM
            // 
            this.txtPM.Location = new System.Drawing.Point(13, 47);
            this.txtPM.Multiline = true;
            this.txtPM.Name = "txtPM";
            this.txtPM.Size = new System.Drawing.Size(356, 73);
            this.txtPM.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupBox3);
            this.xtraTabPage2.Controls.Add(this.groupBox2);
            this.xtraTabPage2.Controls.Add(this.groupBox1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(388, 306);
            this.xtraTabPage2.Text = "Tương tác khác";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPokeDelay);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnPoke);
            this.groupBox3.Location = new System.Drawing.Point(9, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 43);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtPokeDelay
            // 
            this.txtPokeDelay.Location = new System.Drawing.Point(326, 15);
            this.txtPokeDelay.Name = "txtPokeDelay";
            this.txtPokeDelay.Size = new System.Drawing.Size(33, 20);
            this.txtPokeDelay.TabIndex = 2;
            this.txtPokeDelay.Text = "10";
            this.txtPokeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Delay:";
            // 
            // btnPoke
            // 
            this.btnPoke.Image = ((System.Drawing.Image)(resources.GetObject("btnPoke.Image")));
            this.btnPoke.Location = new System.Drawing.Point(46, 13);
            this.btnPoke.Name = "btnPoke";
            this.btnPoke.Size = new System.Drawing.Size(182, 23);
            this.btnPoke.TabIndex = 0;
            this.btnPoke.Text = "Chọc (Poke)";
            this.btnPoke.Click += new System.EventHandler(this.btnPoke_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLikeDelay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLikeNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnLike);
            this.groupBox2.Location = new System.Drawing.Point(9, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtLikeDelay
            // 
            this.txtLikeDelay.Location = new System.Drawing.Point(326, 37);
            this.txtLikeDelay.Name = "txtLikeDelay";
            this.txtLikeDelay.Size = new System.Drawing.Size(33, 20);
            this.txtLikeDelay.TabIndex = 2;
            this.txtLikeDelay.Text = "10";
            this.txtLikeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Delay:";
            // 
            // txtLikeNum
            // 
            this.txtLikeNum.Location = new System.Drawing.Point(326, 13);
            this.txtLikeNum.Name = "txtLikeNum";
            this.txtLikeNum.Size = new System.Drawing.Size(33, 20);
            this.txtLikeNum.TabIndex = 2;
            this.txtLikeNum.Text = "1";
            this.txtLikeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số bài/Profile:";
            // 
            // btnLike
            // 
            this.btnLike.Image = global::ipost.Properties.Resources._32_Facebook_Like_21;
            this.btnLike.Location = new System.Drawing.Point(46, 23);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(182, 23);
            this.btnLike.TabIndex = 0;
            this.btnLike.Text = "Like bài trên tường";
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddDelay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtAddDelay
            // 
            this.txtAddDelay.Location = new System.Drawing.Point(326, 37);
            this.txtAddDelay.Name = "txtAddDelay";
            this.txtAddDelay.Size = new System.Drawing.Size(33, 20);
            this.txtAddDelay.TabIndex = 2;
            this.txtAddDelay.Text = "15";
            this.txtAddDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delay:";
            // 
            // txtAddNum
            // 
            this.txtAddNum.Location = new System.Drawing.Point(326, 13);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(33, 20);
            this.txtAddNum.TabIndex = 2;
            this.txtAddNum.Text = "10";
            this.txtAddNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(46, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Tự động kết bạn";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // interactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "interactions";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Tương tác khách hàng";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupInteractionsInput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInteractions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInteractions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabInteractions)).EndInit();
            this.xtraTabInteractions.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupInteractionsInput;
        private DevExpress.XtraGrid.GridControl gridInteractions;
        private DevExpress.XtraGrid.Views.Grid.GridView grInteractions;
        private DevExpress.XtraGrid.Columns.GridColumn user_id;
        private DevExpress.XtraGrid.Columns.GridColumn user_name;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        public DevExpress.XtraTab.XtraTabControl xtraTabInteractions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInteractionsInput;
        private DevExpress.XtraEditors.SimpleButton btnInteractionsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPM;
        private DevExpress.XtraGrid.Columns.GridColumn user_action;
        private System.Windows.Forms.Button btnPMInsertName;
        public System.Windows.Forms.TextBox txtPMDelay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label29;
        private DevExpress.XtraEditors.SimpleButton btnPM;
        private DevExpress.XtraEditors.SimpleButton btnPoke;
        private DevExpress.XtraEditors.SimpleButton btnLike;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLikeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPokeDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLikeDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnInteractionsClear;
    }
}
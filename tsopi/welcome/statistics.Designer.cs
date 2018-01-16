namespace ipost.welcome
{
    partial class statistics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbAcceptLoading = new System.Windows.Forms.PictureBox();
            this.pbAvatarLoading = new System.Windows.Forms.PictureBox();
            this.btnSaveAvatars = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcceptRequests = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGroupNum = new System.Windows.Forms.Label();
            this.lblFanpageNum = new System.Windows.Forms.Label();
            this.lblFriendNum = new System.Windows.Forms.Label();
            this.lblValuation = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblVerified = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcceptLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLoading)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(433, 333);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 69);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(423, 259);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbAcceptLoading);
            this.panel5.Controls.Add(this.pbAvatarLoading);
            this.panel5.Controls.Add(this.btnSaveAvatars);
            this.panel5.Controls.Add(this.btnAcceptRequests);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 192);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel5.Size = new System.Drawing.Size(413, 31);
            this.panel5.TabIndex = 3;
            // 
            // pbAcceptLoading
            // 
            this.pbAcceptLoading.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAcceptLoading.Image = global::ipost.Properties.Resources.loader;
            this.pbAcceptLoading.Location = new System.Drawing.Point(207, 5);
            this.pbAcceptLoading.Name = "pbAcceptLoading";
            this.pbAcceptLoading.Size = new System.Drawing.Size(20, 21);
            this.pbAcceptLoading.TabIndex = 4;
            this.pbAcceptLoading.TabStop = false;
            this.pbAcceptLoading.Visible = false;
            // 
            // pbAvatarLoading
            // 
            this.pbAvatarLoading.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAvatarLoading.Image = global::ipost.Properties.Resources.loader;
            this.pbAvatarLoading.Location = new System.Drawing.Point(135, 5);
            this.pbAvatarLoading.Name = "pbAvatarLoading";
            this.pbAvatarLoading.Size = new System.Drawing.Size(20, 21);
            this.pbAvatarLoading.TabIndex = 3;
            this.pbAvatarLoading.TabStop = false;
            this.pbAvatarLoading.Visible = false;
            // 
            // btnSaveAvatars
            // 
            this.btnSaveAvatars.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveAvatars.Enabled = false;
            this.btnSaveAvatars.Location = new System.Drawing.Point(0, 5);
            this.btnSaveAvatars.Name = "btnSaveAvatars";
            this.btnSaveAvatars.Size = new System.Drawing.Size(135, 21);
            this.btnSaveAvatars.TabIndex = 2;
            this.btnSaveAvatars.Text = "Lưu Avatar Friendlist";
            // 
            // btnAcceptRequests
            // 
            this.btnAcceptRequests.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcceptRequests.Enabled = false;
            this.btnAcceptRequests.Location = new System.Drawing.Point(227, 5);
            this.btnAcceptRequests.Name = "btnAcceptRequests";
            this.btnAcceptRequests.Size = new System.Drawing.Size(186, 21);
            this.btnAcceptRequests.TabIndex = 1;
            this.btnAcceptRequests.Text = "Chấp nhận tất cả lời mời kết bạn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblGroupNum, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFanpageNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFriendNum, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblValuation, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblConnectionStatus, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblVerified, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 187);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng Nhóm (Group):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Fanpage đã Like:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng Bạn bè:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xác nhận điện thoại:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chất lượng đường truyền hiện tại:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(4, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Định giá TK: (Tham khảo giá US)";
            // 
            // lblGroupNum
            // 
            this.lblGroupNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGroupNum.AutoSize = true;
            this.lblGroupNum.Location = new System.Drawing.Point(396, 9);
            this.lblGroupNum.Name = "lblGroupNum";
            this.lblGroupNum.Size = new System.Drawing.Size(13, 13);
            this.lblGroupNum.TabIndex = 0;
            this.lblGroupNum.Text = "0";
            // 
            // lblFanpageNum
            // 
            this.lblFanpageNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFanpageNum.AutoSize = true;
            this.lblFanpageNum.Location = new System.Drawing.Point(396, 40);
            this.lblFanpageNum.Name = "lblFanpageNum";
            this.lblFanpageNum.Size = new System.Drawing.Size(13, 13);
            this.lblFanpageNum.TabIndex = 0;
            this.lblFanpageNum.Text = "0";
            // 
            // lblFriendNum
            // 
            this.lblFriendNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFriendNum.AutoSize = true;
            this.lblFriendNum.Location = new System.Drawing.Point(396, 71);
            this.lblFriendNum.Name = "lblFriendNum";
            this.lblFriendNum.Size = new System.Drawing.Size(13, 13);
            this.lblFriendNum.TabIndex = 0;
            this.lblFriendNum.Text = "0";
            // 
            // lblValuation
            // 
            this.lblValuation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValuation.AutoSize = true;
            this.lblValuation.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuation.Location = new System.Drawing.Point(365, 133);
            this.lblValuation.Name = "lblValuation";
            this.lblValuation.Size = new System.Drawing.Size(44, 14);
            this.lblValuation.TabIndex = 0;
            this.lblValuation.Text = "$0.00";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(386, 164);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(23, 13);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "Tốt";
            // 
            // lblVerified
            // 
            this.lblVerified.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVerified.AutoSize = true;
            this.lblVerified.Location = new System.Drawing.Point(327, 102);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(82, 13);
            this.lblVerified.TabIndex = 0;
            this.lblVerified.Text = "Đang kiểm tra...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.pbAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 64);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(151, 34);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(206, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "#UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(151, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(206, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "#UserName";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::ipost.Properties.Resources.avatar;
            this.pbAvatar.Location = new System.Drawing.Point(18, 6);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(50, 50);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(442, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 333);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Chưa có nội dung nào cả...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "MẸO HAY CHO BẠN";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "statistics";
            this.Text = "Phân tích tài khoản";
            this.Load += new System.EventHandler(this.statistics_Load);
            this.Shown += new System.EventHandler(this.statistics_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAcceptLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLoading)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGroupNum;
        private System.Windows.Forms.Label lblFanpageNum;
        private System.Windows.Forms.Label lblFriendNum;
        private System.Windows.Forms.Label lblValuation;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnSaveAvatars;
        private DevExpress.XtraEditors.SimpleButton btnAcceptRequests;
        private System.Windows.Forms.PictureBox pbAcceptLoading;
        private System.Windows.Forms.PictureBox pbAvatarLoading;
    }
}
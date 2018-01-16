using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ipost
{
    public partial class f002_login : DevExpress.XtraEditors.XtraForm
    {
        public Panel loadingPanel;
        public ProgressBarControl loadingbar;
        public Label loadingLabel;

        bool driver_init;

        public f002_login(bool driver_init = true)
        {
            InitializeComponent();
            this.driver_init = driver_init;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            this.loadingPanel.Visible = true;
            this.loadingLabel.Text = "Kiểm tra thông tin đăng nhập...";
            this.loadingbar.EditValue = 20;

            int login_status = await f001_main.SE.mLoginTask(txtUser.Text, txtPass.Text);
            if (login_status == 1)
            {
                // Đăng nhập thành công
                f001_main.SE2.LoginTask(txtUser.Text, txtPass.Text);

                this.loadingLabel.Text = "Đăng nhập thành công! Lấy thông tin tài khoản...";
                await f001_main.SE.mGetFbDtsg();
                await f001_main.SE.mGetUserSlug();
                //string user_name = await f001_main.SE.mGetUserName();
                //Program.f001.barUserName.Caption = user_name;
                this.loadingbar.Increment(10);

                SeleniumControl.access_token = await f001_main.SE.getAccessToken();
                string[] me = await f001_main.SE.graphGetMe();
                f001_main.SE.user_name = me[1];
                Program.f001.barUserName.Caption = me[1];
                f001_main.SE.user_id = me[0];
                Program.f001.barUserID.Caption = "ID: #" + me[0];
                await f001_main.SE.graphGetMeFriends();
                //this.loadingLabel.Text = "Quét Facebook ID... (1/2)";
                //string user_id = await f001_main.SE.mGetUserID();
                //Program.f001.barUserID.Caption = "ID: #" + user_id;
                this.loadingbar.Increment(5);


                //this.loadingLabel.Text = "Quét Facebook ID... (2/2)";
                this.loadingbar.Increment(5);
                /*
                PictureBox tempic = new PictureBox();
                tempic.Visible = false;
                tempic.WaitOnLoad = true;
                tempic.LoadAsync("https://graph.facebook.com/" + user_id + "/picture");

                Program.f001.barUserInfo.Glyph = tempic.Image;
                Program.f001.barUserName.Glyph = tempic.Image;*/

                this.loadingLabel.Text = "Xin chào " + me[1] + "! Quét Nhóm...";
                //await f001_main.SE.mGetGroups();
                await f001_main.SE.graphGetGroups();
                await f001_main.SE.graphGetEvents();
                this.loadingbar.Increment(30);

                this.loadingLabel.Text = "Quét danh sách Fanpages...";
                //await f001_main.SE.mGetPages();
                await f001_main.SE.graphGetPages();
                this.loadingbar.Increment(30);

                Program.f001.FrmStatistics = new welcome.statistics();
                Program.f001.FrmStatistics.MdiParent = Program.f001;
                Program.f001.FrmStatistics.Show();

                this.Dispose();
            }
            else
            {
                // Đăng nhập thất bại
                if (login_status == 0) MessageBox.Show("Hãy nhập đầy đủ thông tin Tên đăng nhập & Mật khẩu");
                if (login_status == 2) MessageBox.Show("Facebook đang yêu cầu xác nhận thiết bị! Hãy đăng nhập tài khoản FB này theo cách thông thường và xác nhận với Facebook! Sau đó bạn có thể tiếp tục với cửa sổ này!");
                if (login_status == 3) MessageBox.Show("Sai Tên đăng nhập/Mật khẩu. Hãy kiểm tra lại!");
            }

            loadingPanel.Visible = false;
        }

        private void f002_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn cần đăng nhập tài khoản Facebook để sử dụng phần mềm.\r\nNhấn YES để đóng lại, NO để tiếp tục đăng nhập.", "Đóng chương trình???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Dispose();
                    Application.Exit();
                }
            }
            else
            {
                if (ceRemember.Checked)
                {
                    Properties.Settings.Default.user = txtUser.Text;
                    Properties.Settings.Default.pass = txtPass.Text;
                }
                else
                {
                    Properties.Settings.Default.user = "";
                    Properties.Settings.Default.pass = "";
                }
                Properties.Settings.Default.Save();
            }
        }

        private async void f002_login_Shown(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.user;
            txtPass.Text = Properties.Settings.Default.pass;


            loadingPanel = new Panel();
            loadingPanel.Parent = this;
            loadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            loadingPanel.BringToFront();

            loadingbar = new ProgressBarControl();
            loadingbar.Parent = loadingPanel;
            loadingbar.Location = new Point(10, loadingPanel.Height / 2 - 20);
            loadingbar.Size = new System.Drawing.Size(loadingPanel.Width - 20, 20);
            loadingbar.EditValue = 60;

            loadingLabel = new Label();
            loadingLabel.Parent = loadingPanel;
            loadingLabel.AutoSize = false;
            loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            loadingLabel.Size = new System.Drawing.Size(loadingPanel.Width - 20, 20);
            loadingLabel.Location = new Point(10, loadingPanel.Height / 2);
            loadingLabel.Text = "Đang nạp tài nguyên...";

            if (!driver_init)
                this.loadingPanel.Visible = false;
            for (int i = 0; i < 40; i++)
            {
                await Task.Delay(100);
                loadingLabel.Text = "Đang nạp tài nguyên... (" + i + "/40)";
                loadingbar.Increment(1);
            }
        }
    }
}
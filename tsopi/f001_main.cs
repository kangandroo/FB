using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost
{
    public partial class f001_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static SeleniumControl SE;
        public static SeleniumControl SE2;

        // forms in tabs
        ipost.auto_post.post_2_group FrmPost2Group;
        ipost.IDScraper.scraper FrmScraper;
        ipost.interactions.interactions FrmInteractions;
        public ipost.fanpage_share.fanpage_share FrmFanpageShare;
        ipost.wall_friends.wall_friends FrmWallFriends;
        public ipost.events.events FrmEvents;
        ipost.comment.comment FrmComment;
        public groups.group_join FrmGroupJoin;
        groups.group_invite FrmGroupInvite;
        public welcome.statistics FrmStatistics;

        public f001_main()
        {
            InitializeComponent();
        }

        private void f001_main_Load(object sender, EventArgs e)
        {
            Program.f002 = new f002_login();

            SE = new SeleniumControl();
            SE2 = new SeleniumControl(false);

            ping();

            //checkLicense();

            Program.f002.ShowDialog();
        }

        public async void checkLicense()
        {
            string machine_id = await Task.Factory.StartNew(() => others.FingerPrint.Value());
            Properties.Settings.Default.machine_id = machine_id;
            Properties.Settings.Default.Save();

            string result = await checkLicense_Task(machine_id);
            string[] _results = result.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            
            if (result == "error")
            {
                Program.f001.Visible = false;
                Program.f002.Visible = false;
                MessageBox.Show("Đường truyền của bạn quá chậm." + System.Environment.NewLine + "Hãy tìm 1 đường truyền mạng tốt hơn!");
                Application.Exit();
                return;
            }

            if (result == "trial?" || result == "DENIED")
            {
                if (result == "DENIED")
                {
                    Properties.Settings.Default.license_status = "Bản quyền đã hết hạn";
                }
                else
                {
                    Properties.Settings.Default.license_status = "Chưa kích hoạt";
                }
                Properties.Settings.Default.Save();
                others.F502_license activation = new others.F502_license();
                try
                {
                    activation.ShowDialog(Program.f002);
                }
                catch
                {
                    activation.ShowDialog(this);
                }
            }
            else
            {
                if (_results.Length != 3 || others.FingerPrint.GenHash(machine_id + "kstn321") != _results[0])
                {
                    Program.f001.Visible = false;
                    Program.f002.Visible = false;
                    MessageBox.Show("Rất xin lỗi bạn. Có vấn đề xảy ra với Server của chúng tôi. Xin hãy thử lại sau.");
                    Application.Exit();
                    return;
                }

                if(Application.ProductVersion != _results[1])
                {
                    Program.f001.Visible = false;
                    Program.f002.Visible = false;
                    if(MessageBox.Show("Có phiên bản mới hơn của phần mềm FB Marketing iPOST. Cập nhật?", "Cập nhật phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Diagnostics.Process update_exe = new System.Diagnostics.Process();
                        update_exe.StartInfo.FileName = "autoupdate.exe";
                        update_exe.StartInfo.Arguments = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
                        update_exe.Start();

                        Application.Exit();
                        return;
                    }
                    else
                    {
                        Program.f001.Visible = true;
                        Program.f002.Visible = true;
                    }
                }

                Properties.Settings.Default.license_status = _results[2];
                Properties.Settings.Default.Save();
            }
        }

        public async Task<string> checkLicense_Task(string machine_id)
        {
            string lic_status = "error";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(@"http://ipostfb.com/v4_check.php?id=" + machine_id);
            myRequest.Method = "GET";
            await Task.Factory.StartNew(() =>
            {
                try
                {
                    WebResponse myResponse = myRequest.GetResponse();
                    StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                    lic_status = sr.ReadToEnd();
                    sr.Close();
                    myResponse.Close();
                }
                catch
                {
                    lic_status = "error";
                }
            });
            return lic_status;
        }

        private async void ping()
        {
            try
            {
                Ping sender = new Ping();
                PingReply reply;

                reply = sender.Send("facebook.com");

                if (reply.Status == IPStatus.Success)
                {
                    lblPing.Text = "Ping: " + reply.RoundtripTime;
                }
            }
            catch { }

            await Task.Delay(60000);
            ping();
        }

        private void f001_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
        }

        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }

        #region MENU CLICK BEHAVIOR
        private void barPost2Group_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmPost2Group == null || !IsFormOpen(FrmPost2Group))
            {
                FrmPost2Group = new auto_post.post_2_group();
                FrmPost2Group.MdiParent = this;
                FrmPost2Group.Show();
            }
            else
            {
                FrmPost2Group.Focus();
            }
        }

        private void barScraperGraphSearch_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmScraper == null || !IsFormOpen(FrmScraper))
            {
                FrmScraper = new IDScraper.scraper();
                FrmScraper.MdiParent = this;
                FrmScraper.Show();
            }
            else
            {
                FrmScraper.Focus();
            }

            FrmScraper.xtraTabScraper.SelectedTabPageIndex = 3;
        }

        private void barScraperFile_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmScraper == null || !IsFormOpen(FrmScraper))
            {
                FrmScraper = new IDScraper.scraper();
                FrmScraper.MdiParent = this;
                FrmScraper.Show();
            }
            else
            {
                FrmScraper.Focus();
            }

            FrmScraper.btnScraperImport_Click(sender, e);
        }

        private void barScraperGroup_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmScraper == null || !IsFormOpen(FrmScraper))
            {
                FrmScraper = new IDScraper.scraper();
                FrmScraper.MdiParent = this;
                FrmScraper.Show();
            }
            else
            {
                FrmScraper.Focus();
            }

            FrmScraper.xtraTabScraper.SelectedTabPageIndex = 1;
        }

        private void barScraperFriends_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmScraper == null || !IsFormOpen(FrmScraper))
            {
                FrmScraper = new IDScraper.scraper();
                FrmScraper.MdiParent = this;
                FrmScraper.Show();
            }
            else
            {
                FrmScraper.Focus();
            }

            FrmScraper.xtraTabScraper.SelectedTabPageIndex = 0;
        }

        private void barScraperLikeComment_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmScraper == null || !IsFormOpen(FrmScraper))
            {
                FrmScraper = new IDScraper.scraper();
                FrmScraper.MdiParent = this;
                FrmScraper.Show();
            }
            else
            {
                FrmScraper.Focus();
            }
            FrmScraper.xtraTabScraper.SelectedTabPageIndex = 2;
        }

        private void barLicense_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            others.F502_license activation = new others.F502_license(false);
            activation.ShowDialog();
        }

        private void barInteractionsInbox_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmInteractions == null || !IsFormOpen(FrmInteractions))
            {
                FrmInteractions = new interactions.interactions();
                FrmInteractions.MdiParent = this;
                FrmInteractions.Show();
            }
            else
            {
                FrmInteractions.Focus();
            }
            FrmInteractions.xtraTabInteractions.SelectedTabPageIndex = 0;
        }

        private void barInteractionsAdd_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmInteractions == null || !IsFormOpen(FrmInteractions))
            {
                FrmInteractions = new interactions.interactions();
                FrmInteractions.MdiParent = this;
                FrmInteractions.Show();
            }
            else
            {
                FrmInteractions.Focus();
            }
            FrmInteractions.xtraTabInteractions.SelectedTabPageIndex = 1;
        }

        private void barFanpageShare_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmFanpageShare == null || !IsFormOpen(FrmFanpageShare))
            {
                FrmFanpageShare = new fanpage_share.fanpage_share();
                FrmFanpageShare.MdiParent = this;
                FrmFanpageShare.Show();
            }
            else
            {
                FrmFanpageShare.Focus();
            }
            FrmFanpageShare.xtraTabShare.SelectedTabPageIndex = 0;
        }

        private void barFanpageLink_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmFanpageShare == null || !IsFormOpen(FrmFanpageShare))
            {
                FrmFanpageShare = new fanpage_share.fanpage_share();
                FrmFanpageShare.MdiParent = this;
                FrmFanpageShare.Show();
            }
            else
            {
                FrmFanpageShare.Focus();
            }
            FrmFanpageShare.xtraTabShare.SelectedTabPageIndex = 0;
        }

        private void barFanpageInvite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmFanpageShare == null || !IsFormOpen(FrmFanpageShare))
            {
                FrmFanpageShare = new fanpage_share.fanpage_share();
                FrmFanpageShare.MdiParent = this;
                FrmFanpageShare.Show();
            }
            else
            {
                FrmFanpageShare.Focus();
            }
            FrmFanpageShare.xtraTabShare.SelectedTabPageIndex = 1;
        }

        private void barPost2Friends_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmWallFriends == null || !IsFormOpen(FrmWallFriends))
            {
                FrmWallFriends = new wall_friends.wall_friends();
                FrmWallFriends.MdiParent = this;
                FrmWallFriends.Show();
            }
            else
            {
                FrmWallFriends.Focus();
            }
            FrmWallFriends.xtraTabFriends.SelectedTabPageIndex = 0;
        }
        #endregion

        private void barEvents_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmEvents == null || !IsFormOpen(FrmEvents))
            {
                FrmEvents = new events.events();
                FrmEvents.MdiParent = this;
                FrmEvents.Show();
            }
            else
            {
                FrmEvents.Focus();
            }
            FrmEvents.xtraTabEvents.SelectedTabPageIndex = 0;
        }

        private void barEventsInvite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmEvents == null || !IsFormOpen(FrmEvents))
            {
                FrmEvents = new events.events();
                FrmEvents.MdiParent = this;
                FrmEvents.Show();
            }
            else
            {
                FrmEvents.Focus();
            }
            FrmEvents.xtraTabEvents.SelectedTabPageIndex = 0;
        }

        private void barComment_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmComment == null || !IsFormOpen(FrmComment))
            {
                FrmComment = new comment.comment();
                FrmComment.MdiParent = this;
                FrmComment.Show();
            }
            else
            {
                FrmComment.Focus();
            }
        }

        private void barGroupJoin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmGroupJoin == null || !IsFormOpen(FrmGroupJoin))
            {
                FrmGroupJoin = new groups.group_join();
                FrmGroupJoin.MdiParent = this;
                FrmGroupJoin.Show();
            }
            else
            {
                FrmGroupJoin.Focus();
            }
        }

        private void barGroupInvite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmGroupInvite == null || !IsFormOpen(FrmGroupInvite))
            {
                FrmGroupInvite = new groups.group_invite();
                FrmGroupInvite.MdiParent = this;
                FrmGroupInvite.Show();
            }
            else
            {
                FrmGroupInvite.Focus();
            }
        }

        private void barLogout_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SE.LogoutTask();
            SE2.LogoutTask();

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            Program.f002 = new f002_login(false);
            Program.f002.ShowDialog();
        }
    }
}

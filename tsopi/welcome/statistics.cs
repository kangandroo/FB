using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ipost.welcome
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Shown(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            pbAvatar.WaitOnLoad = false;
            pbAvatar.LoadAsync("https://graph.facebook.com/" + f001_main.SE.user_id + "/picture");

            lblUsername.Text = f001_main.SE.user_name;
            lblUserID.Text = f001_main.SE.user_id;

            int group_count = f001_main.SE.groups.Count;
            lblGroupNum.Text = group_count.ToString();
            int page_count = f001_main.SE.pages.Count;
            lblFanpageNum.Text = page_count.ToString();
            int friend_count = f001_main.SE.friends.Count;
            lblFriendNum.Text = friend_count.ToString();

            int ping = int.Parse(Program.f001.lblPing.Text.Split(' ')[1]);
            if (ping < 100)
            {
                lblConnectionStatus.Text = "Rất tốt (" + ping + ")";
            }
            else if (ping < 200)
            {
                lblConnectionStatus.Text = "Tốt (" + ping + ")";
            }
            else if (ping < 300)
            {
                lblConnectionStatus.Text = "Hơi chậm (" + ping + ")";
            }
            else if (ping < 600)
            {
                lblConnectionStatus.Text = "Chậm (" + ping + ")";
            }
            else
            {
                lblConnectionStatus.Text = "Quá chậm (" + ping + ")";
            }

            double valuation = 0.01 * friend_count + 0.008 * group_count + 0.001 * page_count;

            if (f001_main.SE.user_verified)
            {
                lblVerified.Text = "Đã xác nhận";
                lblVerified.ForeColor = Color.Green;
                valuation *= 2;
            }
            else
            {
                lblVerified.Text = "Chưa xác nhận(!)";
                lblVerified.ForeColor = Color.Red;
            }

            lblValuation.Text = String.Format("{0:C}", valuation);
        }

        private void statistics_Load(object sender, EventArgs e)
        {

        }
    }
}

using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.fanpage_share
{
    public partial class fanpage_share : Form
    {
        DataTable fanpage_share_dt;
        SE_fanpage_share cSE;

        bool pause_flag = true;
        int current_progress = 0;

        public fanpage_share()
        {
            InitializeComponent();

            fanpage_share_dt = new DataTable();
            fanpage_share_dt.Columns.Add("target_id", typeof(string));
            fanpage_share_dt.Columns.Add("target_name", typeof(string));
            fanpage_share_dt.Columns.Add("target_result", typeof(string));
            fanpage_share_dt.Columns.Add("target_tick", typeof(bool));
            fanpage_share_dt.Columns.Add("target_type", typeof(int));

            gridFanpageShare.DataSource = fanpage_share_dt;

            cSE = new SE_fanpage_share();

            repositoryItemProgressBar1.ShowTitle = true;
            repositoryItemProgressBar1.PercentView = false;
            repositoryItemProgressBar1.CustomDisplayText += progress_custom_text;
        }

        private void progress_custom_text(object sender, CustomDisplayTextEventArgs e)
        {
            int temp;
            if (int.TryParse(e.DisplayText, out temp))
            {
                e.DisplayText = "Đang đăng bài: " + e.DisplayText + "%";
            }
        }

        private void fanpage_share_Shown(object sender, EventArgs e)
        {
            if (f001_main.SE.groups.Count > 0)
            {
                foreach (var group in f001_main.SE.groups)
                {
                    fanpage_share_dt.Rows.Add(group.Item2, group.Item1, "", true, 0);
                }
            }

            if (f001_main.SE.friends.Count > 0)
            {
                foreach (var friend in f001_main.SE.friends)
                {
                    fanpage_share_dt.Rows.Add(friend.Item1, friend.Item2, "", false, 1);
                }
            }

            if (f001_main.SE.pages.Count > 0)
            {
                foreach (var page in f001_main.SE.pages)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Value = page.Item2;
                    item.Text = page.Item1;
                    cbPages.Items.Add(item);
                }
                cbPages.SelectedIndex = 0;
            }
        }

        private void cbGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGroups.Checked)
            {
                foreach (DataRow row in fanpage_share_dt.Rows)
                {
                    if (row.Field<int>("target_type") == 0)
                        row.SetField("target_tick", true);
                }
            }
            else
            {
                foreach (DataRow row in fanpage_share_dt.Rows)
                {
                    if (row.Field<int>("target_type") == 0)
                        row.SetField("target_tick", false);
                }
            }
        }

        private void cbFriends_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFriends.Checked)
            {
                foreach (DataRow row in fanpage_share_dt.Rows)
                {
                    if (row.Field<int>("target_type") == 1)
                        row.SetField("target_tick", true);
                }
            }
            else
            {
                foreach (DataRow row in fanpage_share_dt.Rows)
                {
                    if (row.Field<int>("target_type") == 1)
                        row.SetField("target_tick", false);
                }
            }
        }

        private async void btnFanpageShare_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnFanpageShare.Text = "|| Dừng";

                for (int i = current_progress; i < fanpage_share_dt.Rows.Count; i++)
                {
                    if (pause_flag) break;

                    if (grFanpageShare.GetRowCellValue(i, "target_tick").ToString() == "True")
                    {
                        int delay;

                        if (!int.TryParse(txtFanpageShareDelay.Text, out delay) || delay < 0)
                        {
                            delay = 30;
                        }
                        grFanpageShare.SetRowCellValue(i, "target_result", "Đang đăng bài...");
                        string target_url = fanpage_share_dt.Rows[i].Field<string>("target_id");
                        /*
                        if (fanpage_share_dt.Rows[i].Field<int>("target_type") == 0)
                            target_url = "https://www.facebook.com/groups/" + target_url;
                        else
                            target_url = "https://www.facebook.com/profile.php?id=" + target_url;*/
                        string result = await cSE.graph_LinkShare(target_url, txtFanpageLink.Text, txtFanpageContent.Text);
                        current_progress = i + 1;

                        string result_str = result;

                        if (result == "1")
                            result_str = "Mục tiêu chặn đăng bài";
                        else if (result == "2")
                            result_str = "Lỗi xảy ra";
                        else
                        {
                            for (int d = 0; d < delay; d++)
                            {
                                if (pause_flag) break;
                                grFanpageShare.SetRowCellValue(i, "target_result", ((int)(d * 100 / delay)).ToString());
                                await Task.Delay(1000);
                            }
                        }

                        grFanpageShare.SetRowCellValue(i, "target_result", result_str);
                    }
                }
                if (!pause_flag)
                {
                    MessageBox.Show("Hoàn thành Quảng cáo Link!");
                    btnFanpageShare.Text = "Đăng bài";
                    current_progress = 0;
                }

                if (current_progress > 0)
                {
                    if (MessageBox.Show("Bạn có muốn LƯU LẠI danh sách bài đã đăng không?" + System.Environment.NewLine + "Bạn có thể lưu lại bất cứ lúc nào bằng cách nhấn nút dưới khung Danh sách Nhóm", "Lưu lại danh sách bài đăng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        save_posts();
                    }
                }
            }
            else
            {
                btnFanpageShare.Text = "Tiếp tục";
            }
        }

        private void save_posts()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "TXT files (*.txt)|*.txt";
            saveFile.FileName = "POSTS_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + grFanpageShare.RowCount + ".txt";
            saveFile.ShowDialog();

            using (StreamWriter sw = new StreamWriter(saveFile.FileName, false))
            {
                if (grFanpageShare.RowCount > 0)
                {
                    for (int i = 0; i < grFanpageShare.RowCount; i++)
                    {
                        string result_url = grFanpageShare.GetRowCellValue(i, "target_result").ToString();
                        if (result_url.Contains("facebook.com"))
                            sw.WriteLine(result_url);
                    }
                }
                sw.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            save_posts();
        }

        private async void btnLikeInvite_Click(object sender, EventArgs e)
        {
            btnFanpageInvite.Enabled = false;
            pbFanpageInvite.Visible = true;

            await cSE.FanpageInvite("https://m.facebook.com/" + (cbPages.SelectedItem as ComboboxItem).Value.ToString());

            pbFanpageInvite.Visible = false;
            MessageBox.Show("Hoàn tất mời like Page");
            btnFanpageInvite.Enabled = true;
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

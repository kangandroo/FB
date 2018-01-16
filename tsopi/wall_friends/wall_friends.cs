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

namespace ipost.wall_friends
{
    public partial class wall_friends : Form
    {
        private int current_progress = 0;
        private bool pause_flag = true;
        private DataTable users_dt;
        SE_wall_friends cSE = new SE_wall_friends();

        public wall_friends()
        {
            InitializeComponent();

            repositoryItemProgressBar2.ShowTitle = true;
            repositoryItemProgressBar2.PercentView = false;
            repositoryItemProgressBar2.CustomDisplayText += progress_custom_text;

            users_dt = new DataTable();
            users_dt.Columns.Add("user_name", typeof(string));
            users_dt.Columns.Add("user_url", typeof(string));
            users_dt.Columns.Add("user_result", typeof(string));
            users_dt.Columns.Add("user_tick", typeof(bool));

            gridFriends.DataSource = users_dt;
        }

        private void progress_custom_text(object sender, CustomDisplayTextEventArgs e)
        {
            int temp;
            if (int.TryParse(e.DisplayText, out temp))
            {
                e.DisplayText = "Đang đăng bài: " + e.DisplayText + "%";
            }  
        }

        private void save_posts()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "TXT files (*.txt)|*.txt";
            saveFile.FileName = "POSTS_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + grFriends.RowCount + ".txt";
            saveFile.ShowDialog();

            using (StreamWriter sw = new StreamWriter(saveFile.FileName, false))
            {
                if (grFriends.RowCount > 0)
                {
                    for (int i = 0; i < grFriends.RowCount; i++)
                    {
                        string result_url = grFriends.GetRowCellValue(i, "user_result").ToString();
                        if (result_url.Contains("facebook.com"))
                            sw.WriteLine(result_url);
                    }
                }
                sw.Close();
            }
        }

        private void btnFriendsExport_Click(object sender, EventArgs e)
        {
            save_posts();
        }

        private void update_friends_grid()
        {
            if (f001_main.SE.groups.Count > 0)
            {
                foreach (var friend in f001_main.SE.friends)
                {
                    users_dt.Rows.Add(friend.Item1, friend.Item2, "", true);
                }
            }
        }

        private async void btnPost2Friends_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnPost2Friends.Text = "|| Dừng";

                for (int i = current_progress; i < grFriends.RowCount; i++)
                {
                    if (pause_flag) break;

                    if (grFriends.GetRowCellValue(i, "user_tick").ToString() == "True")
                    {
                        int delay;

                        if (!int.TryParse(txtPost2GroupDelay.Text, out delay) || delay < 0)
                        {
                            delay = 30;
                        }
                        grFriends.SetRowCellValue(i, "user_result", "40");
                        string result = await cSE.auto_post(grFriends.GetRowCellValue(i, "user_url").ToString(), txtPost2GroupContent.Text, new string[] { txtPost2GroupBrowse1.Text, txtPost2GroupBrowse2.Text, txtPost2GroupBrowse3.Text });
                        current_progress = i + 1;
                        int result_code;

                        if (int.TryParse(result, out result_code))
                        {
                            if (result_code == 0)
                                result = "Vui lòng điền nội dung đăng bài";
                            if (result_code == 2)
                                result = "Nhóm không cho đăng bài";
                        }
                        else
                        {
                            for (int d = 0; d < delay; d++)
                            {
                                if (pause_flag) break;
                                grFriends.SetRowCellValue(i, "user_result", ((int)(d * 60 / delay) + 40).ToString());
                                await Task.Delay(1000);
                            }
                        }

                        grFriends.SetRowCellValue(i, "user_result", result);
                    }
                }
                if (!pause_flag)
                {
                    MessageBox.Show("Hoàn thành đăng bài lên tường!");
                    btnPost2Friends.Text = "Đăng bài";
                    current_progress = 0;
                }
            }
            else
            {
                btnPost2Friends.Text = "Tiếp tục";
            }

            if (current_progress > 0)
            {
                if (MessageBox.Show("Bạn có muốn LƯU LẠI danh sách bài đã đăng không?" + System.Environment.NewLine + "Bạn có thể lưu lại bất cứ lúc nào bằng cách nhấn nút dưới khung Danh sách bạn", "Lưu lại danh sách bài đăng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    save_posts();
                }
            }
        }

        private void wall_friends_Shown(object sender, EventArgs e)
        {
            if (f001_main.SE.friends.Count > 0)
            {
                foreach (var friend in f001_main.SE.friends)
                {
                    users_dt.Rows.Add(friend.Item1, "https://www.facebook.com/profile.php?id=" + friend.Item2, "", true);
                }
            }
        }
    }
}

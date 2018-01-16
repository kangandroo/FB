using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.groups
{
    public partial class group_join : Form
    {
        public DataTable groups_dt;
        SE_groups cSE = new SE_groups();
        bool pause_flag = true;
        int current_progress = 0;

        bool search_pause_flag = true;

        public group_join()
        {
            InitializeComponent();

            groups_dt = new DataTable();
            groups_dt.Columns.Add("group_name", typeof(string));
            groups_dt.Columns.Add("group_url", typeof(string));
            groups_dt.Columns.Add("group_result", typeof(string));
            groups_dt.Columns.Add("group_tick", typeof(bool));

            gridGroups.DataSource = groups_dt;
        }

        private void grGroups_RowCountChanged(object sender, EventArgs e)
        {
            groupGroups.Text = "Danh sách nhóm (" + grGroups.DataRowCount + ")";
        }

        private async void btnGroupSearch_Click(object sender, EventArgs e)
        {
            search_pause_flag = !search_pause_flag;
            if (!search_pause_flag)
            {
                btnGroupSearch.Text = "|| Dừng";

                grGroups.ShowLoadingPanel();

                groups_dt.Rows.Clear();
                current_progress = 0;

                int min;

                if (!int.TryParse(txtGroupSearchMin.Text, out min) || min < 0)
                {
                    min = 1000;
                }

                int skip = 0;

                while (groups_dt.Rows.Count < 10)
                {
                    if (search_pause_flag) break;
                    List<Group_Search> results = await cSE.groupSearch(txtGroupSearch.Text, min, skip);
                    foreach (Group_Search result in results)
                    {
                        if (search_pause_flag) break;
                        if (await cSE.groupJoinable(result.group_url))
                            groups_dt.Rows.Add(result.group_name, result.group_url, result.group_count, true);
                    }
                    skip += 10;
                }

                grGroups.HideLoadingPanel();
            }
            else
            {
                btnGroupSearch.Text = "Tìm kiếm nhóm";
            }
        }

        private async void btnJoin_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnJoin.Text = "|| Dừng";

                for (int i = current_progress; i < grGroups.RowCount; i++)
                {
                    if (pause_flag) break;

                    if (grGroups.GetRowCellValue(i, "group_tick").ToString() == "True")
                    {
                        int delay;

                        if (!int.TryParse(txtDelay.Text, out delay) || delay < 0)
                        {
                            delay = 30;
                        }

                        int result = await cSE.groupJoin(grGroups.GetRowCellValue(i, "group_url").ToString());
                        grGroups.SetRowCellValue(i, "group_url", "Đang gia nhập");
                        current_progress = i + 1;
                        string result_str = "Gia nhập thành công";


                        if (result == 1)
                            result_str = "Không cho phép gia nhập";
                        else
                        {
                            for (int d = 0; d < delay; d++)
                            {
                                if (pause_flag) break;
                                grGroups.SetRowCellValue(i, "group_url", result_str + ". Chờ (" + (delay - d).ToString() + ")");
                                await Task.Delay(1000);
                            }
                        }

                        grGroups.SetRowCellValue(i, "group_url", result_str);
                    }
                }
                if (!pause_flag)
                {
                    MessageBox.Show("Hoàn thành Tự động gia nhập!");
                    btnJoin.Text = "Gia nhập nhóm";
                    current_progress = 0;
                }
            }
            else
            {
                btnJoin.Text = "Tiếp tục";
            }
        }
    }
}

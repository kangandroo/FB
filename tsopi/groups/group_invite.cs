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
    public partial class group_invite : Form
    {
        public DataTable groups_dt;
        bool pause_flag = true;
        int current_progress = 0;
        SE_groups cSE = new SE_groups();

        public group_invite()
        {
            InitializeComponent();

            groups_dt = new DataTable();
            groups_dt.Columns.Add("group_name", typeof(string));
            groups_dt.Columns.Add("group_url", typeof(string));
            groups_dt.Columns.Add("group_result", typeof(string));
            groups_dt.Columns.Add("group_tick", typeof(bool));

            gridGroups.DataSource = groups_dt;
        }

        private void group_invite_Shown(object sender, EventArgs e)
        {
            if (f001_main.SE.groups.Count > 0)
            {
                foreach (var group in f001_main.SE.groups)
                {
                    groups_dt.Rows.Add(group.Item1, "https://www.facebook.com/groups/" + group.Item2, "", true);
                }
            }
        }

        private async void btnInvite_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnInvite.Text = "|| Dừng";

                for (int i = current_progress; i < grGroups.RowCount; i++)
                {
                    if (pause_flag) break;

                    if (grGroups.GetRowCellValue(i, "group_tick").ToString() == "True")
                    {
                        grGroups.SetRowCellValue(i, "group_result", "Đang mời...");

                        int delay;

                        if (!int.TryParse(txtDelay.Text, out delay) || delay < 0)
                        {
                            delay = 30;
                        }
                        int result = await cSE.groupInvite(grGroups.GetRowCellValue(i, "group_url").ToString(), txtInviteName.Text);
                        current_progress = i + 1;

                        string result_str = "Đã mời " + txtInviteName.Text;

                        if (result == 1)
                            result_str = "Đã gia nhập hoặc Nhóm không cho phép";
                        else if (result == 2)
                            result_str = "Lỗi xảy ra";
                        else
                        {
                            for (int d = 0; d < delay; d++)
                            {
                                if (pause_flag) break;
                                grGroups.SetRowCellValue(i, "group_result", result_str + ". Chờ (" + (delay-d).ToString() + ")");
                                await Task.Delay(1000);
                            }
                        }

                        grGroups.SetRowCellValue(i, "group_result", result_str);
                    }
                }
                if (!pause_flag)
                {
                    MessageBox.Show("Hoàn thành mời nhóm!");
                    btnInvite.Text = "Mời tham gia nhóm";
                    current_progress = 0;
                }
            }
            else
            {
                btnInvite.Text = "Tiếp tục";
            }
        }

        private void grGroups_RowCountChanged(object sender, EventArgs e)
        {
            groupGroups.Text = "Danh sách nhóm (" + grGroups.DataRowCount + ")";
        }


    }
}

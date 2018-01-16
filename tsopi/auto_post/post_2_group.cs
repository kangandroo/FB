using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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

namespace ipost.auto_post
{
    public partial class post_2_group : Form
    {
        private int current_progress = 0;
        private bool pause_flag = true;
        private DataTable groups_dt;

        public post_2_group()
        {
            InitializeComponent();
            repositoryItemProgressBar2.ShowTitle = true;
            repositoryItemProgressBar2.PercentView = false;
            //gridPost2Group.CustomRowCellEdit += gridPost2Group_CustomRowCellEdit;
            repositoryItemProgressBar2.CustomDisplayText += progress_custom_text;

            groups_dt = new DataTable();
            groups_dt.Columns.Add("group_name", typeof(string));
            groups_dt.Columns.Add("group_url", typeof(string));
            groups_dt.Columns.Add("group_result", typeof(string));
            groups_dt.Columns.Add("group_tick", typeof(bool));

            gridPost2Group.DataSource = groups_dt;
        }

        private void gridPost2Group_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "group_result")
            {

            }
        }

        private void progress_custom_text(object sender, CustomDisplayTextEventArgs e)
        {
            int temp;
            if (int.TryParse(e.DisplayText, out temp))
            {
                e.DisplayText = "Đang đăng bài: " + e.DisplayText + "%";
            }  
        }

        private void post_2_group_Shown(object sender, EventArgs e)
        {
            update_group_grid();
        }

        private async void btnPost2Group_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnPost2Group.Text = "|| Dừng";
                SE_post_2_group cSE = new SE_post_2_group();

                for (int i = current_progress; i < grPost2Group.RowCount; i++)
                {
                    if (pause_flag) break;

                    if (grPost2Group.GetRowCellValue(i, "group_tick").ToString() == "True")
                    {
                        int delay;

                        if (!int.TryParse(txtPost2GroupDelay.Text, out delay) || delay < 0)
                        {
                            delay = 30;
                        }
                        grPost2Group.SetRowCellValue(i, "group_result", "40");
                        string result = await cSE.auto_post(grPost2Group.GetRowCellValue(i, "group_url").ToString(), txtPost2GroupContent.Text, new string[] { txtPost2GroupBrowse1.Text, txtPost2GroupBrowse2.Text, txtPost2GroupBrowse3.Text });
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
                                grPost2Group.SetRowCellValue(i, "group_result", ((int)(d * 60 / delay) + 40).ToString());
                                await Task.Delay(1000);
                            }
                        }

                        grPost2Group.SetRowCellValue(i, "group_result", result);
                    }
                }
                if (!pause_flag)
                {
                    MessageBox.Show("Hoàn thành Tự động đăng bài!");
                    btnPost2Group.Text = "Đăng bài";
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
                btnPost2Group.Text = "Tiếp tục";
            }
        }

        private void btnPost2GroupBrowse1_Click(object sender, EventArgs e)
        {
            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Chọn ảnh cho bài đăng";
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //fDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;
                txtPost2GroupBrowse1.Text = file;
            }
            else
            {
                txtPost2GroupBrowse1.Text = "";
            }
        }

        private void btnPost2GroupBrowse2_Click(object sender, EventArgs e)
        {
            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Chọn ảnh cho bài đăng";
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //fDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;
                txtPost2GroupBrowse2.Text = file;
            }
            else
            {
                txtPost2GroupBrowse2.Text = "";
            }
        }

        private void btnPost2GroupBrowse3_Click(object sender, EventArgs e)
        {
            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Chọn ảnh cho bài đăng";
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //fDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;
                txtPost2GroupBrowse3.Text = file;
            }
            else
            {
                txtPost2GroupBrowse3.Text = "";
            }
        }

        private void save_posts()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "TXT files (*.txt)|*.txt";
            saveFile.FileName = "POSTS_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + grPost2Group.RowCount + ".txt";
            saveFile.ShowDialog();

            using (StreamWriter sw = new StreamWriter(saveFile.FileName, false))
            {
                if (grPost2Group.RowCount > 0)
                {
                    for (int i = 0; i < grPost2Group.RowCount; i++)
                    {
                        string result_url = grPost2Group.GetRowCellValue(i, "group_result").ToString();
                        if (result_url.Contains("facebook.com"))
                            sw.WriteLine(result_url);
                    }
                }
                sw.Close();
            }
        }

        private void update_group_grid()
        {
            if (f001_main.SE.groups.Count > 0)
            {
                foreach (var group in f001_main.SE.groups)
                {
                    groups_dt.Rows.Add(group.Item1, "https://www.facebook.com/groups/" + group.Item2, "", true);
                }
            }
        }

        private void btnGroupExport_Click(object sender, EventArgs e)
        {
            save_posts();
        }

        private void gridPost2Group_RowCountChanged(object sender, EventArgs e)
        {
            groupPost2GroupList.Text = "Danh sách nhóm (" + grPost2Group.DataRowCount + ")";
        }

        private void gridPost2Group_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(grPost2Group.GetFocusedDisplayText());
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.comment
{
    public partial class comment : Form
    {
        int scan_current_progress = 0;
        int file_current_progress = 0;
        int page_current_progress = 0;
        private bool pause_flag = true;
        private DataTable comments_dt;
        List<string> file_inputs = new List<string>();

        SE_comment cSE = new SE_comment();

        public comment()
        {
            InitializeComponent();

            comments_dt = new DataTable();
            comments_dt.Columns.Add("comment_content", typeof(string));
            comments_dt.Columns.Add("comment_url", typeof(string));

            gridComments.DataSource = comments_dt;
        }

        private void grComments_RowCountChanged(object sender, EventArgs e)
        {
            groupComments.Text = "Danh sách bình luận (" + grComments.DataRowCount + ")";
        }

        private async void btnComment_Click(object sender, EventArgs e)
        {
            pause_flag = !pause_flag;
            if (!pause_flag)
            {
                btnComment.Text = "|| Dừng";

                int delay;

                if (!int.TryParse(txtDelay.Text, out delay) || delay < 0)
                {
                    delay = 30;
                }

                if (radScan.Checked)
                {
                    if (f001_main.SE.groups.Count > 0)
                    {
                        for (int j = scan_current_progress; j < f001_main.SE.groups.Count; j++)
                        {
                            if (pause_flag) break;
                            var _group = f001_main.SE.groups[j];

                            CommentResult result = await cSE.ScanComment(_group.Item2, txtComment.Text, cbOnlyMe.Checked);
                            comments_dt.Rows.Add(result.content, result.url);
                            scan_current_progress = j + 1;

                            DataRow new_row = comments_dt.Rows.Add();
                            for (int i = delay; i > 0; i--)
                            {
                                if (pause_flag) break;
                                new_row.SetField("comment_content", "Chờ (" + i + ")");
                                await Task.Delay(1000);
                            }
                            comments_dt.Rows.Remove(new_row);
                        }
                    }

                    if (!pause_flag)
                    {
                        scan_current_progress = 0;
                        MessageBox.Show("Hoàn thành Scan bài!");
                        btnComment.Text = "Bình luận";
                    }
                }
                else if (radFile.Checked)
                {
                    if (file_inputs.Count > 0)
                    {
                        for (int j = file_current_progress; j < file_inputs.Count; j++)
                        {
                            if (pause_flag) break;
                            var target = file_inputs[j];

                            CommentResult result = await cSE.FileComment(target, txtComment.Text);
                            comments_dt.Rows.Add(result.content, result.url);
                            file_current_progress = j + 1;

                            DataRow new_row = comments_dt.Rows.Add();
                            for (int i = delay; i > 0; i--)
                            {
                                if (pause_flag) break;
                                new_row.SetField("comment_content", "Chờ (" + i + ")");
                                await Task.Delay(1000);
                            }
                            comments_dt.Rows.Remove(new_row);
                        }
                    }

                    if (!pause_flag)
                    {
                        file_current_progress = 0;
                        MessageBox.Show("Hoàn thành bình luận!");
                        btnComment.Text = "Bình luận";
                    }
                }
                else if (radPage.Checked)
                {
                    if (f001_main.SE.pages.Count > 0)
                    {
                        for (int j = page_current_progress; j < f001_main.SE.pages.Count; j++)
                        {
                            if (pause_flag) break;
                            var _page = f001_main.SE.pages[j];

                            CommentResult result = await cSE.PageComment(_page.Item2, txtComment.Text);
                            comments_dt.Rows.Add(result.content, result.url);
                            page_current_progress = j + 1;

                            DataRow new_row = comments_dt.Rows.Add();
                            for (int i = delay; i > 0; i--)
                            {
                                if (pause_flag) break;
                                new_row.SetField("comment_content", "Chờ (" + i + ")");
                                await Task.Delay(1000);
                            }
                            comments_dt.Rows.Remove(new_row);
                        }
                    }

                    if (!pause_flag)
                    {
                        page_current_progress = 0;
                        MessageBox.Show("Hoàn thành bình luận Page!");
                        btnComment.Text = "Bình luận";
                    }
                }
            }
            else
            {
                btnComment.Text = "Tiếp tục";
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            radFile.Checked = true;

            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Open Posts File";
            fDialog.Filter = "TXT Files (*.txt) | *.txt";

            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;
                txtFile.Text = file;

                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader fileStr = new System.IO.StreamReader(file);
                while ((line = fileStr.ReadLine()) != null)
                {
                    file_inputs.Add(line);
                    counter++;
                }

                fileStr.Close();
                file_current_progress = 0;
                MessageBox.Show("Đọc thành công: " + counter + " UID");
            }
            else
            {
                txtFile.Text = "";
            }
        }

        private void cbOnlyMe_Click(object sender, EventArgs e)
        {
            radScan.Checked = true;
        }
    }
}

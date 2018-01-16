using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.interactions
{
    public partial class interactions : Form
    {
        DataTable interactions_dt;
        SE_interactions cSE;

        bool pm_pause_flag = true;
        int pm_current_progress = 0;

        bool add_pause_flag = true;
        int add_current_progress = 0;

        bool like_pause_flag = true;
        int like_current_progress = 0;

        bool poke_pause_flag = true;
        int poke_current_progress = 0;

        public interactions()
        {
            InitializeComponent();

            interactions_dt = new DataTable();
            interactions_dt.Columns.Add("user_id", typeof(string));
            interactions_dt.Columns.Add("user_name", typeof(string));
            interactions_dt.Columns.Add("user_action", typeof(string));
            gridInteractions.DataSource = interactions_dt;

            cSE = new SE_interactions();
        }

        private void btnInteractionsInput_Click(object sender, EventArgs e)
        {
            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Open Groups File";
            fDialog.Filter = "TXT Files (*.txt) | *.txt";

            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;
                txtInteractionsInput.Text = file;

                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader fileStr = new System.IO.StreamReader(file);
                while ((line = fileStr.ReadLine()) != null)
                {
                    string[] _line = line.Split('|');
                    if (_line.Length > 1)
                        interactions_dt.Rows.Add(_line[0], _line[1]);
                    else
                        interactions_dt.Rows.Add(_line[0], "");

                    counter++;
                }

                fileStr.Close();

                MessageBox.Show("Đọc thành công: " + counter + " UID");
            }
            else
            {
                txtInteractionsInput.Text = "";
            }
        }

        private void grInteractions_RowCountChanged(object sender, EventArgs e)
        {
            groupInteractionsInput.Text = "Danh sách UID (" + grInteractions.DataRowCount + ")";
        }

        private async void btnPM_Click(object sender, EventArgs e)
        {
            pm_pause_flag = !pm_pause_flag;
            if (!pm_pause_flag)
            {
                btnPM.Text = "|| Dừng";

                for (int i = pm_current_progress; i < interactions_dt.Rows.Count; i++)
                {
                    if (pm_pause_flag) break;

                    int delay;

                    if (!int.TryParse(txtPMDelay.Text, out delay) || delay < 0)
                    {
                        delay = 10;
                    }

                    delay += (new Random()).Next(0, 5);

                    interactions_dt.Rows[i].SetField("user_action", "Đang Inbox...");
                    int result = await cSE.httpSendMessage(interactions_dt.Rows[i].Field<string>("user_id"), txtPM.Text, interactions_dt.Rows[i].Field<string>("user_name"));
                    pm_current_progress = i + 1;
                    string result_str = "Gửi thành công";

                    if (result == 1)
                        result_str = "Profile chặn tin nhắn";
                    else
                        if (result == 2)
                            result_str = "Lỗi xảy ra";
                        else
                        {
                            for (int d = 0; d < delay; d++)
                            {
                                if (pm_pause_flag) break;
                                interactions_dt.Rows[i].SetField("user_action", result_str + ". Chờ (" + (delay - d) + ")");
                                await Task.Delay(1000);
                            }
                        }

                    interactions_dt.Rows[i].SetField("user_action", result_str);
                }
                if (!pm_pause_flag)
                {
                    btnPM.Text = "Gửi hàng loạt";
                    pm_current_progress = 0;
                    MessageBox.Show("Hoàn thành gửi tin nhắn!");
                }
            }
            else
            {
                btnPM.Text = "Tiếp tục";
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            add_pause_flag = !add_pause_flag;
            if (!add_pause_flag)
            {
                btnAdd.Text = "|| Dừng";

                int num;

                if (!int.TryParse(txtAddNum.Text, out num) || num < 0)
                {
                    num = 10;
                }

                for (int i = add_current_progress; i < interactions_dt.Rows.Count; i++)
                {
                    if (add_pause_flag) break;
                    if (i > num) break;

                    int delay;

                    if (!int.TryParse(txtAddDelay.Text, out delay) || delay < 0)
                    {
                        delay = 15;
                    }

                    interactions_dt.Rows[i].SetField("user_action", "Đang kết bạn...");
                    int result = await cSE.addFriend(interactions_dt.Rows[i].Field<string>("user_id"));
                    add_current_progress = i + 1;
                    string result_str = "Kết bạn thành công";

                    if (result == 1)
                        result_str = "Đã kết bạn";
                    else
                    {
                        for (int d = 0; d < delay; d++)
                        {
                            if (add_pause_flag) break;
                            interactions_dt.Rows[i].SetField("user_action", result_str + ". Chờ (" + (delay - d) + ")");
                            await Task.Delay(1000);
                        }
                    }

                    interactions_dt.Rows[i].SetField("user_action", result_str);
                }

                if (!add_pause_flag)
                {
                    btnAdd.Text = "Tự động kết bạn";
                    add_current_progress = 0;
                    MessageBox.Show("Hoàn thành kết bạn");
                }
            }
            else
            {
                btnAdd.Text = "Tiếp tục";
            }
        }

        private void btnPMInsertName_Click(object sender, EventArgs e)
        {
            txtPM.AppendText("{username}");
            txtPM.Focus();
        }

        private async void btnLike_Click(object sender, EventArgs e)
        {
            like_pause_flag = !like_pause_flag;
            if (!like_pause_flag)
            {
                btnLike.Text = "|| Dừng";

                for (int i = like_current_progress; i < interactions_dt.Rows.Count; i++)
                {
                    if (like_pause_flag) break;

                    int delay;

                    if (!int.TryParse(txtLikeDelay.Text, out delay) || delay < 0)
                    {
                        delay = 10;
                    }

                    int num;

                    if (!int.TryParse(txtLikeNum.Text, out num) || num < 0)
                    {
                        num = 1;
                    }

                    interactions_dt.Rows[i].SetField("user_action", "Đang like...");
                    int result = await cSE.likeWall(interactions_dt.Rows[i].Field<string>("user_id"), num);
                    like_current_progress = i + 1;
                    string result_str = "Like thành công";

                    if (result == 1)
                        result_str = "Profile chặn Wall";
                    else
                    {
                        for (int d = 0; d < delay; d++)
                        {
                            if (like_pause_flag) break;
                            interactions_dt.Rows[i].SetField("user_action", result_str + ". Chờ (" + (delay - d) + ")");
                            await Task.Delay(1000);
                        }
                    }

                    interactions_dt.Rows[i].SetField("user_action", result_str);
                }
                if (!like_pause_flag)
                {
                    btnLike.Text = "Like bài trên tường";
                    like_current_progress = 0;
                    MessageBox.Show("Hoàn thành like bài trên tường");
                }
            }
            else
            {
                btnLike.Text = "Tiếp tục";
            }
        }

        private void gridInteractions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(grInteractions.GetFocusedDisplayText());
                e.Handled = true;
            }
        }

        private void btnInteractionsClear_Click(object sender, EventArgs e)
        {
            pm_current_progress = 0;
            add_current_progress = 0;
            like_current_progress = 0;
            poke_current_progress = 0;
            interactions_dt.Rows.Clear();
        }

        private async void btnPoke_Click(object sender, EventArgs e)
        {
            poke_pause_flag = !poke_pause_flag;
            if (!poke_pause_flag)
            {
                btnPoke.Text = "|| Dừng";

                for (int i = poke_current_progress; i < interactions_dt.Rows.Count; i++)
                {
                    if (poke_pause_flag) break;

                    int delay;

                    if (!int.TryParse(txtPokeDelay.Text, out delay) || delay < 0)
                    {
                        delay = 10;
                    }

                    interactions_dt.Rows[i].SetField("user_action", "Đang Poke...");
                    int result = await cSE.Poke(interactions_dt.Rows[i].Field<string>("user_id"));
                    poke_current_progress = i + 1;
                    string result_str = "Poke thành công";

                    if (result == 1)
                        result_str = "Chặn Poke";
                    else
                    {
                        for (int d = 0; d < delay; d++)
                        {
                            if (poke_pause_flag) break;
                            interactions_dt.Rows[i].SetField("user_action", result_str + ". Chờ (" + (delay - d) + ")");
                            await Task.Delay(1000);
                        }
                    }

                    interactions_dt.Rows[i].SetField("user_action", result_str);
                }
                if (!poke_pause_flag)
                {
                    btnPoke.Text = "Chọc (Poke)";
                    poke_current_progress = 0;
                    MessageBox.Show("Hoàn thành Poke");
                }
            }
            else
            {
                btnAdd.Text = "Tiếp tục";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.events
{
    public partial class events : Form
    {
        SE_events cSE = new SE_events();
        public DataTable events_dt;

        public events()
        {
            InitializeComponent();

            events_dt = new DataTable();
            events_dt.Columns.Add("user_name", typeof(string));

            gridFriends.DataSource = events_dt;
        }

        private void events_Shown(object sender, EventArgs e)
        {
            if (f001_main.SE.events.Count > 0)
            {
                foreach (var _event in f001_main.SE.events)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Value = _event.Item2;
                    item.Text = _event.Item1;
                    cbEvents.Items.Add(item);
                }
                cbEvents.SelectedIndex = 0;
            }
        }

        private void btnEventsGetLink_Click(object sender, EventArgs e)
        {
            if (Program.f001.FrmFanpageShare == null || !Program.f001.IsFormOpen(Program.f001.FrmFanpageShare))
            {
                Program.f001.FrmFanpageShare = new fanpage_share.fanpage_share();
                Program.f001.FrmFanpageShare.MdiParent = Program.f001;
                Program.f001.FrmFanpageShare.Show();
            }
            else
            {
                Program.f001.FrmFanpageShare.Focus();
            }
            Program.f001.FrmFanpageShare.xtraTabShare.SelectedTabPageIndex = 0;
            if (cbEvents.SelectedItem != null)
            Program.f001.FrmFanpageShare.txtFanpageLink.Text = "https://www.facebook.com/events/" + (cbEvents.SelectedItem as ComboboxItem).Value.ToString();
        }

        private async void btnEventsInvite_Click(object sender, EventArgs e)
        {
            btnEventsInvite.Enabled = false;
            pbEventInvite.Visible = true;

            while (true)
            {
                List<string> results = await cSE.invite((cbEvents.SelectedItem as ComboboxItem).Value.ToString());
                if (results.Count > 0)
                {
                    foreach (string result in results)
                    {
                        events_dt.Rows.Add(result);
                    }
                }
                else
                {
                    break;
                }
            }
            

            pbEventInvite.Visible = false;
            MessageBox.Show("Hoàn tất mời tham gia sự kiện");
            btnEventsInvite.Enabled = true;
        }

        private void grFriends_RowCountChanged(object sender, EventArgs e)
        {
            groupFriends.Text = "Danh sách mời (" + grFriends.DataRowCount + ")";
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

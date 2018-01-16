using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ipost.others
{
    public partial class F502_license : Form
    {
        bool strict;
        public F502_license(bool strict = true)
        {
            InitializeComponent();
            this.strict = strict;
        }

        private void F502_license_Shown(object sender, EventArgs e)
        {
            lblLicenseStatus.Text = Properties.Settings.Default.license_status;
            txtLicense.Text = Properties.Settings.Default.machine_id;

            if (Properties.Settings.Default.license_status != "Chưa kích hoạt")
            {
                if (Properties.Settings.Default.license_status == "Bản quyền phần mềm vĩnh viễn")
                {
                    btnActivate.Enabled = false;
                }
                btnTrial.Enabled = false;
            }
        }

        private void F502_license_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (strict) Application.Exit();
        }

        private async void btnTrial_Click(object sender, EventArgs e)
        {
            picLoading.Visible = true;
            btnActivate.Enabled = false;
            btnTrial.Enabled = false;
            if (MessageBox.Show("Kích hoạt bản dùng thử 03 ngày? Mỗi máy tính chỉ có duy nhất 1 lần dùng thử.", "Kích hoạt bản dùng thử", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://ipostfb.com/v4_check.php?id=" + Properties.Settings.Default.machine_id + "&trial=1&name=" + HttpUtility.UrlEncode(txtCompany.Text) + "&email=" + HttpUtility.UrlEncode(txtEmail.Text) + "&sdt=" + HttpUtility.UrlEncode(txtSDT.Text));
                WebResponse myResponse = await myRequest.GetResponseAsync();
                myResponse.Close();
                MessageBox.Show("Kích hoạt dùng thử thành công!");
                this.Visible = false;
                await Task.Delay(2000);
                Program.f001.checkLicense();
            }
            btnTrial.Enabled = true;
            btnActivate.Enabled = true;
            picLoading.Visible = false;
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            picLoading.Visible = true;
            btnActivate.Enabled = false;
            btnTrial.Enabled = false;
            if (txtKey.Text == "")
            {
                MessageBox.Show("Vui lòng điền Key bản quyền để kích hoạt. Hoặc sử dụng bản dùng thử đầy đủ tính năng.");
            }
            else
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://ipostfb.com/v4_activation.php?id=" + Properties.Settings.Default.machine_id + "&key=" + HttpUtility.UrlEncode(txtKey.Text) + "&name=" + HttpUtility.UrlEncode(txtCompany.Text) + "&email=" + HttpUtility.UrlEncode(txtEmail.Text) + "&sdt=" + HttpUtility.UrlEncode(txtSDT.Text));
                WebResponse myResponse = await myRequest.GetResponseAsync();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                myResponse.Close();
                if (result == "successful")
                {
                    MessageBox.Show("Kích hoạt bản quyền thành công!");
                    this.Visible = false;
                    await Task.Delay(2000);
                    Program.f001.checkLicense();
                }
                else if (result == "wrong")
                {
                    MessageBox.Show("Key bản quyền không chính xác. Hãy kiểm tra lại 1 lần nữa.");
                }
                else if (result == "used")
                {
                    MessageBox.Show("Key này đã được sử dụng cho 1 máy tính khác." + System.Environment.NewLine + "Nếu bạn muốn chuyển máy, hãy liên lạc với chúng tôi để được xử lý trong vòng 24 giờ.");
                }
            }
            btnTrial.Enabled = true;
            btnActivate.Enabled = true;
            picLoading.Visible = false;
        }
    }
}

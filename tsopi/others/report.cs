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
using System.Windows.Forms;

namespace ipost.others
{
    public partial class report : Form
    {
        bool critical; // Có buộc đóng chương trình
        string exception;

        public report(string _exception, string user_warning = "", bool _critical = true)
        {
            InitializeComponent();
            this.critical = _critical;

            if (user_warning != "")
            {
                //MessageBox.Show(user_warning);
            }
            this.exception = _exception;
            this.ShowDialog();
        }

        public static void send_error_logs(string error_logs, string report = "", string email = "")
        {
            string error_log_php = "http://ipostfb.com/v4_error_log.php?l=" + error_logs;
            if (email != "")
                error_log_php += "&email=" + email;
            if (report != "")
                error_log_php += "&report=" + report;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(error_log_php);
            myRequest.Method = "GET";
            myRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

            try
            {
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            }
            catch { }
        }

        private void report_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (critical)
            {
                //Application.Exit();
            }
        }

        private void btnSendError_Click(object sender, EventArgs e)
        {
            send_error_logs(this.exception, txtReport.Text, txtEmail.Text);

            if (critical)
            {
                //Application.Exit();
            }
        }
    }
}

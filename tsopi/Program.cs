using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost
{
    static class Program
    {
        public static f001_main f001;
        public static f002_login f002;

        [STAThread]
        static void Main()
        {
            // Bắt nốt các Exception chưa catch được (Unhandled Exceptions)
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Đặt tên và để static global scope cho biến main để có thể truy cập từ các form khác nếu cần
            f001 = new f001_main();
            try
            {
                Application.Run(f001);
            }
            catch (Exception ex)
            {
                Exceptions_Handler(ex.ToString());
            }
            // Sự kiện Đóng chương trình
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            /*
             * Sự kiện đóng chương trình: đóng chrome driver
             */
            if (f001_main.SE.driver!=null) f001_main.SE.driver.Quit();
            if (f001_main.SE2.driver!= null) f001_main.SE2.driver.Quit();
        }

        public static void Exceptions_Handler(string exception, string user_warning = "")
        {
            /*
             * Bắt nốt các Exception chưa catch được (Unhandled Exceptions)
             */

            // Bật cửa sổ report lỗi
            others.report FrmReport = new others.report(exception, user_warning);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Unhandled Thread Exception
            Exceptions_Handler(e.Exception.Message + System.Environment.NewLine + e.Exception.ToString());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Unhandled UI Exception
            Exceptions_Handler((e.ExceptionObject as Exception).Message + System.Environment.NewLine + (e.ExceptionObject as Exception).ToString());
        }
    }
}

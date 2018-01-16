using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using System.Net;
using System.Web.Script.Serialization;

namespace ipost
{
    public class SeleniumControl
    {
        public ChromeDriver driver;
        public bool ready = false;
        private bool mobile;

        public string user_id = "";
        public string user_name = "";
        public string user_slug = "";
        public bool user_verified = false;
        public static string access_token = "";
        public static string fb_dtsg = "";
        public List<Tuple<string, string>> groups;
        public List<Tuple<string, string>> pages;
        public List<Tuple<string, string>> friends;
        public List<Tuple<string, string>> events;

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        private const int SW_RESTORE = 9;

        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("User32")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        IEnumerable<int> newChromePids;

        public SeleniumControl(bool mobile = true)
        {
            driver_init(mobile);
            this.mobile = mobile;
        }

        #region BASIC CONTROLS (NO NEED FLAG)
        public Task Navigate(string url)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (mobile)
                        driver.Url = url.Replace("www.facebook", "m.facebook");
                    else
                        driver.Url = url.Replace("m.facebook", "www.facebook");
                }
                catch { }
            });
        }

        public Task Click(string element_name)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    OpenQA.Selenium.IWebElement iElement = driver.FindElementByName(element_name);
                    iElement.Click();
                    Thread.Sleep(100);
                }
                catch { }
            });
        }

        public Task ClickElement(IWebElement e)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    e.Click();
                    Thread.Sleep(100);
                }
                catch { }
            });
        }

        public Task InputFileAdd(string element_name, string localpath)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    OpenQA.Selenium.IWebElement iElement = driver.FindElement(By.Name(element_name));
                    driver.ExecuteScript(@"document.getElementsByName('" + element_name + "')[0].focus();");
                    iElement.SendKeys(localpath);
                }
                catch { }
            });
        }

        public Task InputValueAdd(string input_name, string value)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    OpenQA.Selenium.IWebElement iElement = driver.FindElementByName(input_name);
                    iElement.Clear();
                    iElement.SendKeys(value);
                }
                catch { }
            });
        }

        public Task InputTextAdd(string element_name, string content)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    driver.ExecuteScript(@"document.getElementsByName('" + element_name + "')[0].innerHTML = '" + System.Web.HttpUtility.JavaScriptStringEncode(content) + "';");
                }
                catch { }
            });
        }

        public Task RunScript(string script)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    driver.ExecuteScript(script);
                }
                catch { }
            });
        }

        private void Exceptions_Handler(string exception, string user_warning = "") // Gửi lỗi lên server
        {
            /*
             * Bắt các lỗi nghiêm trọng liên quan đến selenium (buộc phải đóng app)
             */

            // Bật cửa sổ report lỗi
            others.report FrmReport = new others.report(exception, user_warning);
        }

        private async void driver_init(bool mobile)
        {
            // Để khởi tạo trình duyệt
            // Thoát khi gặp lỗi
            if (driver == null)
            {
                IEnumerable<int> pidsBefore = Process.GetProcessesByName("chrome").Select(p => p.Id);
				string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\App";
				var chromeDriverService = ChromeDriverService.CreateDefaultService(path);
                chromeDriverService.HideCommandPromptWindow = true;
				ChromeOptions chromeDriverOptions = new ChromeOptions();
                if (mobile) chromeDriverOptions.AddArgument("--user-agent=NokiaC5-00/061.005 (SymbianOS/9.3; U; Series60/3.2 Mozilla/5.0; Profile/MIDP-2.1 Configuration/CLDC-1.1) AppleWebKit/525 (KHTML, like Gecko) Version/3.0 Safari/525 3gpp-gba"); //Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0
                chromeDriverOptions.AddArgument("ignore-certificate-errors");
                chromeDriverOptions.AddArgument("no-sandbox");
                path = Path.GetDirectoryName(Application.ExecutablePath) + @"\App\block.crx";
                chromeDriverOptions.AddExtension(path);
                //Program.f001.TopMost = true;
                //Program.f002.TopMost = true;
                await Task.Factory.StartNew(() =>
                {
                    try
                    {
                        driver = new ChromeDriver(chromeDriverService, chromeDriverOptions);
                    }
                    catch (Exception ex)
                    {
                        Exceptions_Handler(ex.ToString(), "Hãy tải về trình duyệt Chrome mới nhất tại http://google.com/chrome");
                    }
                });
                try
                {
                    Application.OpenForms[Program.f002.Name].Activate();
                }
                catch { }
                //Program.f001.TopMost = false;
                //Program.f002.TopMost = false;

                IEnumerable<int> pidsAfter = Process.GetProcessesByName("chrome").Select(p => p.Id);
                newChromePids = pidsAfter.Except(pidsBefore);

                try
                {
                    foreach (int pid in newChromePids)
                    {
                        int hWnd = Process.GetProcessById(pid).MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                }
                catch (Exception ex)
                {
                    Exceptions_Handler(ex.ToString(), "Không tìm thấy cửa sổ Trình duyệt!");
                }

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
                driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

                if (f001_main.SE.driver != null && f001_main.SE2.driver != null)
                    Program.f002.loadingPanel.Visible = false;

                await set_flag(true);
            }
        }
        #endregion

        #region COMMON TASKS (NEED FLAG)
        public async Task<int> mLoginTask(string user, string pass)
        {
            // Trả về mã lỗi
            // 0: rỗng user hoặc pass, 1: thành công, 2: checkpoint, 3: sai user/pass
            if (user == "" || pass == "")
                return 0;

            await set_flag(false);

            int response_status = 1;

            await Navigate("https://m.facebook.com");
            await InputValueAdd("email", user);
            await InputValueAdd("pass", pass);
            await Click("login");

            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(300));
            string after_login_url = await Task.Factory.StartNew(() => driver.Url);
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

            if (after_login_url.Contains("home.php") || after_login_url.Contains("phoneacquire"))
            {
                response_status = 1;
            }
            else
            {
                if (after_login_url.Contains("checkpoint"))
                {
                    response_status = 2;
                }
                else
                {
                    response_status = 3;
                }
            }
            response_status = 1;
            await set_flag(true);
            return response_status;
        }

        public async void LoginTask(string user, string pass)
        {
            await set_flag(false);
            // Chỉ chạy hàm này khi đã xác nhận thông tin đăng nhập là chính xác => khỏi kiểm tra
            await Navigate("https://www.facebook.com/");

            await RunScript(@"document.getElementsByName('email')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(user) + "';");
            await RunScript(@"document.getElementsByName('pass')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(pass) + "';");
            await RunScript(@"document.getElementById('loginbutton').click();");
            await set_flag(true);
            //await InputValueAdd("email", user);
            //await InputValueAdd("pass", pass);
            //IWebElement login_button = driver.FindElementById("loginbutton");
            //await ClickElement(login_button);
        }

        public async Task<string> mGetUserID()
        {
            await set_flag(false);
            string _user_id = "";

            await Task.Factory.StartNew(() =>
            {
                try
                {
                    _user_id = driver.FindElementByName("target").GetAttribute("value");
                }
                catch { }
            });

            this.user_id = _user_id;

            await set_flag(true);
            return user_id;
        }

        public async Task<string> mGetUserSlug()
        {
            await set_flag(false);

            string _user_slug = "";

            var photos = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//a[contains(@href, '?v=photos')]"));
            if (photos.Count > 0)
            {
                String href = photos[0].GetAttribute("href");
                Match match = Regex.Match(href, @".com\/([A-Za-z0-9\-\.]+)\?v\=photos", RegexOptions.None);
                if (match.Success)
                {
                    _user_slug = match.Groups[1].Value;
                }
            }

            this.user_slug = _user_slug;

            await set_flag(true);
            return _user_slug;
        }

        public async Task<string> mGetUserName()
        {
            await set_flag(false);
            string user_name = "";

            await Task.Factory.StartNew(() =>
            {
                try
                {
                    var nodes = driver.FindElementsByXPath("//img[contains(@src, 'profile.ak') or contains(@src, 'fbcdn-profile-a.akamaihd.net')]");

                    if (nodes.Count > 0)
                    {
                        user_name = nodes[0].GetAttribute("alt");
                    }
                }
                catch (Exception ex)
                {
                    Exceptions_Handler(ex.ToString(), "Không thể quét được ID Facebook!");
                }
            });

            this.user_name = user_name;
            await set_flag(true);
            return user_name;
        }

        public async Task<List<Tuple<string, string>>> mGetGroups()
        {
            await set_flag(false);
            List<Tuple<string, string>> _groups = new List<Tuple<string, string>>();

            await Navigate("https://m.facebook.com/groups/?s&refid=27");

            var td = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//div[@id='root']//table//tbody//tr//td"));
            var e2 = await Task.Factory.StartNew(() => td[0].FindElements(By.XPath("./div")));
            if (e2.Count > 1)
            {
                var e = await Task.Factory.StartNew(() => e2[1].FindElements(By.XPath(".//li//table//tbody//tr//td//a")));

                if (e.Count > 0)
                    await Task.Factory.StartNew(() =>
                    {
                        foreach (IWebElement k in e)
                        {
                            _groups.Add(Tuple.Create(k.GetAttribute("innerHTML"), k.GetAttribute("href")));
                        }
                    });
            }

            var see_more_btns = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//a[contains(@href, '?seemore')]"));

            if (see_more_btns.Count > 0)
            {
                await ClickElement(see_more_btns[0]);

                td = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//div[@id='root']//table//tbody//tr//td"));
                e2 = await Task.Factory.StartNew(() => td[0].FindElements(By.XPath("./div")));

                if (e2.Count > 1)
                {
                    var e = await Task.Factory.StartNew(() => e2[1].FindElements(By.XPath(".//li//table//tbody//tr//td//a")));
                    if (e.Count > 0)
                        await Task.Factory.StartNew(() =>
                        {
                            foreach (IWebElement k in e)
                            {
                                _groups.Add(Tuple.Create(k.GetAttribute("innerHTML"), k.GetAttribute("href")));
                            }
                        });
                }
            }

            this.groups = _groups;

            await set_flag(true);
            return _groups;
        }

        public async Task<List<Tuple<string, string>>> mGetPages()
        {
            await set_flag(false);

            List<Tuple<string, string>> _pages = new List<Tuple<string, string>>();
            await Navigate("https://m.facebook.com/" + user_slug + "?v=likes&refid=17");

            while (true)
            {
                var afrefs = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//a[contains(@href, 'fref=none')]"));

                if (afrefs.Count > 0)
                {
                    await Task.Factory.StartNew(() =>
                    {
                        foreach (IWebElement afref in afrefs)
                        {
                            _pages.Add(Tuple.Create(afref.Text, afref.GetAttribute("href")));
                        }
                    });
                }
                else
                {
                    break;
                }

                var next = await Task.Factory.StartNew(() => driver.FindElementsByXPath("//a[contains(@href, 'v=likes&sectionid=9999')]"));
                if (next.Count > 0)
                {
                    await ClickElement(next[0]);
                }
                else
                {
                    break;
                }
            }

            this.pages = _pages;

            await set_flag(true);
            return _pages;
        }

        public async Task<string> mGetFbDtsg()
        {
            await set_flag(false);

            //await Navigate("http://m.facebook.com");

            string _fb_dtsg = "";

            var dtsg = await Task.Factory.StartNew(() => driver.FindElementsByName("fb_dtsg"));

            if (dtsg.Count > 0)
            {
                _fb_dtsg = dtsg[0].GetAttribute("value");
            }

            await set_flag(true);
            fb_dtsg = _fb_dtsg;
            return fb_dtsg;
        }

        public async Task<string[]> graphGetMe()
        {
            string json_response = await getGraphResponse("/me?fields=id,name,verified&");

            JavaScriptSerializer js = new JavaScriptSerializer();
            welcome.api_me_statistics me = js.Deserialize<welcome.api_me_statistics>(json_response);

            user_verified = me.verified;
            return new string[] { me.id, me.name };
        }

        public async Task<List<Tuple<string, string>>> graphGetMeFriends()
        {
            List<Tuple<string, string>> _friends = new List<Tuple<string, string>>();
            string json_response = await SeleniumControl.getGraphResponse("/me/friends?");

            if (json_response != "")
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                api_group_members _members = js.Deserialize<api_group_members>(json_response);

                if (_members.data.Length > 0)
                {
                    foreach (api_group_member _member in _members.data)
                    {
                        _friends.Add(Tuple.Create(_member.id, _member.name));
                    }
                }
            }
            this.friends = _friends;
            return _friends;
        }

        public async Task<List<Tuple<string, string>>> graphGetGroups()
        {
            List<Tuple<string, string>> _groups = new List<Tuple<string, string>>();

            string json_response = await getGraphResponse("/me/groups?");

            JavaScriptSerializer js = new JavaScriptSerializer();
            api_group_members response_groups = js.Deserialize<api_group_members>(json_response);

            foreach (api_group_member response_group in response_groups.data)
            {
                _groups.Add(Tuple.Create(response_group.name, response_group.id));
            }

            this.groups = _groups;
            return _groups;
        }

        public async Task<List<Tuple<string, string>>> graphGetPages()
        {
            List<Tuple<string, string>> _pages = new List<Tuple<string, string>>();

            string json_response = await getGraphResponse("/me/likes?");

            JavaScriptSerializer js = new JavaScriptSerializer();
            api_group_members response_pages = js.Deserialize<api_group_members>(json_response);

            foreach (api_group_member response_page in response_pages.data)
            {
                _pages.Add(Tuple.Create(response_page.name, response_page.id));
            }

            this.pages = _pages;
            return _pages;
        }

        public async Task<List<Tuple<string, string>>> graphGetEvents()
        {
            List<Tuple<string, string>> _events = new List<Tuple<string, string>>();

            string json_response = await getGraphResponse("/me/events?fields=name,id,rsvp_status&limit=30&");

            JavaScriptSerializer js = new JavaScriptSerializer();
            api_group_members response_pages = js.Deserialize<api_group_members>(json_response);

            foreach (api_group_member response_page in response_pages.data)
            {
                _events.Add(Tuple.Create(response_page.name, response_page.id));
            }

            this.events = _events;
            return _events;
        }

        public async Task<string> getAccessToken()
        {
            await set_flag(false);
            string access_token = "";

            //await Navigate("https://www.facebook.com/v2.4/dialog/oauth?response_type=token&client_id=145634995501895&redirect_uri=https%3A%2F%2Fdevelopers.facebook.com%2Ftools%2Fexplorer%2Fcallback&scope=user_posts%2Cuser_likes%2Cuser_events");
            await Navigate("https://www.facebook.com/login.php?skip_api_login=1&api_key=165907476854626&signed_next=1&next=https%3A%2F%2Fwww.facebook.com%2Fv1.0%2Fdialog%2Foauth%3Fredirect_uri%3Dhttps%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26display%3Dpopup%26scope%3Demail%252Cpublish_stream%252Cuser_likes%252Cfriends_likes%252Cuser_birthday%252Cpublish_actions%26response_type%3Dtoken%26sso_key%3Dcom%26client_id%3D165907476854626%26ret%3Dlogin&cancel_url=https%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror%3Daccess_denied%26error_code%3D200%26error_description%3DPermissions%2Berror%26error_reason%3Duser_denied%23_%3D_&display=popup");
            await Click("__CONFIRM__");

            //access_token = await Task.Factory.StartNew(() => driver.FindElementByXPath("//input[@placeholder and @data-reactid]").GetAttribute("value"));
            do
            {
                access_token = await Task.Factory.StartNew(() => driver.Url);
                await Task.Delay(10);
            } while (access_token.Contains("friends_likes"));

            access_token = access_token.Substring(access_token.IndexOf("access_token") + 13);
            access_token = access_token.Substring(0, access_token.IndexOf("&"));

            await set_flag(true);
            return access_token;
        }

        public async void LogoutTask()
        {
            await Task.Factory.StartNew(() =>
            {
                driver.Manage().Cookies.DeleteAllCookies();
            });
        }
        #endregion

        #region OTHER HELPERS
        public static string m_to_www(string m)
        {
            return m.Replace("https://m.facebook", "https://www.facebook");
        }

        public static string www_to_m(string www)
        {
            return www.Replace("https://www.facebook", "https://m.facebook");
        }

        public static string random_tag()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var rnd = new Random();
            string random_tag = " #" + new string(
                Enumerable.Repeat(chars, rnd.Next(8) + 1)
                          .Select(s => s[rnd.Next(s.Length)])
                          .ToArray());
            return random_tag;
        }

        public async Task set_flag(bool flag)
        {
            while (!flag && !ready)
            {
                // ready == false, flag == false --- BUSY
                await Task.Delay(1000);
            }

            ready = flag;
        }

        public static async Task<string> getGraphResponse(string request)
        {
            return await Task.Factory.StartNew(() => getGraphResponseWait(request));
        }

        public static string getGraphResponseWait(string request)
        {
            if (!request.Contains("https://graph.facebook.com"))
                request = @"https://graph.facebook.com" + request + "access_token=" + access_token;
            string result = "";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(request);
            Console.WriteLine(request);
            myRequest.Method = "GET";
            myRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

            try
            {
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                result = sr.ReadToEnd();
            }
            catch { }

            return result;
        }
        #endregion
    }
}

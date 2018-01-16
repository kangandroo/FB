using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace ipost.fanpage_share
{
    class SE_fanpage_share
    {
        SeleniumControl SE;
        SeleniumControl SE2;

        public SE_fanpage_share()
        {
            this.SE = f001_main.SE;
            this.SE2 = f001_main.SE2;
        }

        public async Task<string> LinkShare(string target, string url, string content)
        {
            /* 0: thành công; 1: không cho đăng; 2: lỗi không rõ*/
            await SE2.set_flag(false);
            string return_status = "0";
            SE2.driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
            SE2.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            WebDriverWait wait = new WebDriverWait(SE2.driver, TimeSpan.FromSeconds(60));

            ((IJavaScriptExecutor)SE2.driver).ExecuteScript("return window.stop()");
            //await Task.Factory.StartNew(() => Navigate2(driver2, post_target));

            await SE2.Navigate(target);

            try
            {
                IAlert alert = SE2.driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch { } //NoAlertPresentException Ex

            try
            {
                wait.Until<Boolean>((d) =>
                {
                    return ((IJavaScriptExecutor)SE2.driver).ExecuteScript("return document.readyState").Equals("complete");
                });
            }
            catch
            {
                ((IJavaScriptExecutor)SE2.driver).ExecuteScript("return window.stop()");
            }

            var xhpc = await Task.Factory.StartNew(() => SE2.driver.FindElementsByXPath("//a[@data-endpoint='/ajax/composerx/attachment/group/post/' or contains(@href, '$status/=1')]"));
            if (xhpc.Count == 0)
            {
                return_status = "1";
            }
            else
            {
                await SE2.ClickElement(xhpc[0]);

                var xhpc_text = await Task.Factory.StartNew(() => SE2.driver.FindElementsByName("xhpc_message_text"));

                if (xhpc_text.Count > 0)
                {
                    await SE2.ClickElement(xhpc_text[0]);

                    await SE2.RunScript(@"document.getElementsByName('xhpc_message_text')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(url) + "';");

                    xhpc_text[0].SendKeys(OpenQA.Selenium.Keys.Enter);

                    await Task.Delay(2000);
                    await SE2.RunScript(@"document.getElementsByName('xhpc_message_text')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(content + System.Environment.NewLine) + SeleniumControl.random_tag() + "';");
                    xhpc_text[0].SendKeys(OpenQA.Selenium.Keys.Enter);
                    await Task.Delay(500);
                    var btn_post = await Task.Factory.StartNew(() => SE2.driver.FindElementsByXPath("//form[contains(@action, 'updatestatus.php') and @class='']//button[@type='submit']"));
                    if (btn_post.Count == 0)
                    {
                        return_status = "2";
                    }
                    else
                    {
                        await Task.Factory.StartNew(() => btn_post[btn_post.Count - 1].Click());
                        await Task.Delay(1000);
                        return_status = target;
                        var group_wall_posts = await Task.Factory.StartNew(() => SE2.driver.FindElementsByXPath("//a[contains(@href, '/permalink/')]"));
                        if (group_wall_posts.Count > 0)
                        {
                            return_status = group_wall_posts[0].GetAttribute("href");
                        }
                    }
                }
            }

            SE2.driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            SE2.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            await SE2.set_flag(true);
            return return_status;
        }

        public async Task<string> graph_LinkShare(string target, string url, string content)
        {
            string return_status = "1";

            string URI = "https://graph.facebook.com/" + target + "/feed?access_token=" + SeleniumControl.access_token;
            string myParameters = "link=" + HttpUtility.UrlEncode(url) + "&message=" + HttpUtility.UrlEncode(content);

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.Headers.Add("user-agent", "--user-agent=NokiaC5-00/061.005 (SymbianOS/9.3; U; Series60/3.2 Mozilla/5.0; Profile/MIDP-2.1 Configuration/CLDC-1.1) AppleWebKit/525 (KHTML, like Gecko) Version/3.0 Safari/525 3gpp-gba");
                await Task.Factory.StartNew(() =>
                {
                    try
                    {
                        string json_response = wc.UploadString(URI, myParameters);
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        api_group_member response = js.Deserialize<api_group_member>(json_response);
                        return_status = "https://www.facebook.com/" + response.id;
                    }
                    catch { }
                });
            }

            return return_status;
        }

        public async Task<int> FanpageInvite(string fanpage_url)
        {
            await SE.set_flag(false);
            int return_status = 0;

            await SE.Navigate(fanpage_url);
            var invite_buttons = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'invite_friends')]"));
            if (invite_buttons.Count == 0)
            {
                var view_more = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'/pages/context/hidden/')]"));
                if (view_more.Count > 0)
                {
                    await Task.Factory.StartNew(() => SE.ClickElement(view_more[0]));
                    invite_buttons = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'invite_friends')]"));
                }
            }
            if (invite_buttons.Count > 0)
            {
                await SE.ClickElement(invite_buttons[0]);

                int success = 0;

                while (true)
                {
                    var send_page_invite = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'/send_page_invite/')]"));
                    if (send_page_invite.Count == 0) break;

                    Match match = Regex.Match(send_page_invite[0].GetAttribute("href"), @"invitee_id\=([0-9]+)\&page_id", RegexOptions.None);
                    if (match.Success)
                    {
                        Program.f001.lblStatus.Text = "Đang mời Like Fanpage: " + match.Groups[1].Value;
                    }

                    await SE.ClickElement(send_page_invite[0]);

                    success++;
                }
            }

            await SE.set_flag(true);
            return return_status;
        }
    }
}

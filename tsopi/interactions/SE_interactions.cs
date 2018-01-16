using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace ipost.interactions
{
    class SE_interactions
    {
        SeleniumControl SE;

        public SE_interactions()
        {
            this.SE = f001_main.SE;
        }

        public async Task<int> sendMessage(string user_id, string message)
        {
            /*
             * 0: thành công; 1: không cho gửi; 2: lỗi không rõ
             */
            await SE.set_flag(false);
            int return_status = 0;

            await SE.Navigate("https://m.facebook.com/profile.php?id=" + user_id + "&refid=17");

            var user_info = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//div[@id='m-timeline-cover-section']//a[contains(@href,'?v=info')]"));
            if (user_info.Count > 0)
                await SE.ClickElement(user_info[0]);

            string message_to_send = message.Replace("{username}", SE.driver.Title);

            string hometown = "HN";
            string current_city = "HN";

            if (message_to_send.Contains("{hometown}") || message_to_send.Contains("{current_city}"))
            {
                var livings = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//div[@id='living']//div[@title]//td[@valign='top']"));
                if (livings.Count == 4)
                {
                    hometown = livings[3].Text;
                    current_city = livings[1].Text;
                }
                message_to_send = message_to_send.Replace("{hometown}", hometown);
                message_to_send = message_to_send.Replace("{current_city}", current_city);
            }

            message_to_send += "\r\n" + SeleniumControl.random_tag();

            var messages = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, '/messages/thread/')]"));
            if (messages.Count == 0)
            {
                return_status = 1;
            }
            else
            {
                await SE.ClickElement(messages[0]);
                var bodies = await Task.Factory.StartNew(() => SE.driver.FindElementsByName("body"));

                if (bodies.Count == 0)
                {
                    return_status = 2;
                }
                else
                {
                    await SE.InputValueAdd("body", message_to_send);

                    var btnSends = await Task.Factory.StartNew(() => SE.driver.FindElementsByName("send"));

                    if (btnSends.Count > 0)
                        await SE.ClickElement(btnSends[0]);
                    else
                    {
                        btnSends = await Task.Factory.StartNew(() => SE.driver.FindElementsByName("Send"));
                        if (btnSends.Count > 0)
                            await SE.ClickElement(btnSends[0]);
                        else
                            return_status = 2;
                    }

                    return_status = 0;
                }
            }

            await SE.set_flag(true);
            return return_status;
        }

        public async Task<int> httpSendMessage(string user_id, string message, string user_name)
        {
            if (user_name == "")
            {
                string json_response = await SeleniumControl.getGraphResponse("/" + user_id + "?");
                JavaScriptSerializer js = new JavaScriptSerializer();
                api_group_member response = js.Deserialize<api_group_member>(json_response);
                user_name = response.name;
            }

            message = message.Replace("{username}", user_name);
            message = message.Replace("http://", "");
            message = message.Replace("https://", "");

            string cookies_str = "";
            var cookies = SE.driver.Manage().Cookies.AllCookies.ToArray();
            foreach (var cookie in cookies)
            {
                cookies_str += cookie.Name + "=" + cookie.Value + ";";
            }

            string URI = "https://mbasic.beta.facebook.com/messages/send/?icm=1";
            string myParameters = "fb_dtsg=" + SeleniumControl.fb_dtsg + "&charset_test:€,´,€,´,水,Д,Є&body=" + HttpUtility.UrlEncode(message) + "&waterfall_source=message&photo_ids[http://d585tldpucybw.cloudfront.net/sfimages/default-source/logos/telerik-progress-logo-reversed.png]=http://d585tldpucybw.cloudfront.net/sfimages/default-source/logos/telerik-progress-logo-reversed.png&ids[&ids[1]=" + user_id + "]=&ids[1]=" + user_id;

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.Headers.Add(HttpRequestHeader.Cookie, cookies_str);
                wc.Headers.Add("user-agent", "--user-agent=NokiaC5-00/061.005 (SymbianOS/9.3; U; Series60/3.2 Mozilla/5.0; Profile/MIDP-2.1 Configuration/CLDC-1.1) AppleWebKit/525 (KHTML, like Gecko) Version/3.0 Safari/525 3gpp-gba");
                await Task.Factory.StartNew(() =>
                {
                    try
                    {
                        wc.UploadString(URI, myParameters);
                    }
                    catch { }
                });
            }

            return 0;
        }

        public async Task<int> addFriend(string user_id)
        {
            int return_status = 0;
            await SE.set_flag(false);

            await SE.Navigate("https://m.facebook.com/profile.php?id=" + user_id);

            var btnAddFriend = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, 'profile_add_friend.php')]"));
            if (btnAddFriend.Count == 1)
            {
                await SE.ClickElement(btnAddFriend[0]);
                return_status = 0;
            }
            else
            {
                return_status = 1;
            }

            await SE.set_flag(true);
            return return_status;
        }

        public async Task<int> Poke(string user_id)
        {
            int return_status = 0;
            await SE.set_flag(false);

            await SE.Navigate("https://m.facebook.com/profile.php?id=" + user_id);

            var btnPokeFriend = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, '/pokes/inline/?poke_target=')]"));
            if (btnPokeFriend.Count == 1)
            {
                await SE.ClickElement(btnPokeFriend[0]);
                return_status = 0;
            }
            else
            {
                return_status = 1;
            }

            await SE.set_flag(true);
            return return_status;
        }

        public async Task<int> likeWall(string user_id, int num)
        {
            int return_status = 0;
            await SE.set_flag(false);

            await SE.Navigate("https://m.facebook.com/profile.php?id=" + user_id);

            var timeline = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'v=timeline')]"));
            if (timeline.Count > 0)
            {
                await SE.ClickElement(timeline[0]);
            }

            for (int j = 0; j < num; j++)
            {
                var like_buttons = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, 'like.php')]"));

                if (like_buttons.Count > j)
                {
                    await SE.ClickElement(like_buttons[j]);
                    await Task.Delay(1000);
                    await Task.Factory.StartNew(() => SE.driver.Navigate().Back());
                }
                else
                {
                    if (like_buttons.Count == 0)
                        return_status = 1;
                    break;
                }
            }

            await SE.set_flag(true);
            return return_status;
        }
    }
}

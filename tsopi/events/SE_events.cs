using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ipost.events
{
    class SE_events
    {
        SeleniumControl SE;

        public SE_events()
        {
            this.SE = f001_main.SE;
        }

        public async Task<List<string>> invite(string event_id)
        {
            await SE.set_flag(false);
            List<string> invites = new List<string>();

            await SE.Navigate("https://m.facebook.com/events/" + event_id);

            var invite_buttons = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'friendselect.php')]"));

            if (invite_buttons.Count > 0)
            {
                await SE.ClickElement(invite_buttons[0]);

                var friends_to_invite = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'friendinvite.php')]"));

                if (friends_to_invite.Count > 0)
                {
                    string invite_url = friends_to_invite[0].GetAttribute("href").Substring(0, friends_to_invite[0].GetAttribute("href").IndexOf("&ids=") + 5);

                    List<string> ids = new List<string>();

                    while (true)
                    {
                        string _ids = "";

                        friends_to_invite = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'friendinvite.php')]"));
                        if (friends_to_invite.Count == 0) break;
                        foreach (IWebElement friend_to_invite in friends_to_invite)
                        {
                            string friend_uid = friend_to_invite.GetAttribute("href").Substring(friend_to_invite.GetAttribute("href").IndexOf("&ids=") + 5);
                            string friend_name = friend_to_invite.FindElement(By.XPath("../..")).Text.Replace(friend_to_invite.Text, "");
                            invites.Add(friend_name);
                            _ids += friend_uid + ",";
                        }

                        ids.Add(_ids.Substring(0, _ids.Length - 1));

                        int _out;
                        var friends_select = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("(//a[contains(@href,'friendselect.php')])[last()]"));
                        if (friends_select.Count == 0 || int.TryParse(friends_select[0].Text, out _out)) break;

                        await SE.ClickElement(friends_select[0]);
                    }

                    foreach (string _id in ids)
                    {
                        await SE.Navigate(invite_url + _id);
                        await SE.ClickElement(SE.driver.FindElementByName("send"));
                    }
                }
            }

            await SE.set_flag(true);
            return invites;
        }
    }
}

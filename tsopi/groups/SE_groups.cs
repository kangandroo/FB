using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ipost.groups
{
    class SE_groups
    {
        SeleniumControl SE;

        public SE_groups()
        {
            this.SE = f001_main.SE;
        }

        public async Task<int> groupInvite(string group_url, string friendname)
        {
            await SE.set_flag(false);

            int result_status = 0;
            /*
             * URL: thành công
             * 2: group không cho post bài
             * 0: rỗng nội dung và ảnh
             */
            await SE.Navigate(group_url.Replace("www.facebook", "m.facebook"));

            var btnAddMembers = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, '/groups/members/search/')]"));

            if (btnAddMembers.Count > 0)
            {
                await SE.ClickElement(btnAddMembers[0]);

                await SE.InputValueAdd("query_term", friendname);
                var btnSearch = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//form[@action='/groups/members/search/']//input[@type='submit']"));

                if (btnSearch.Count > 0)
                {
                    await SE.ClickElement(btnSearch[0]);

                    var add_form = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//form[contains(@action, '/groups/members/add/')]"));

                    if (add_form.Count > 0)
                    {
                        var div = await Task.Factory.StartNew(() => add_form[0].FindElements(By.TagName("div")));
                        if (div.Count > 1)
                        {
                            var inputs = await Task.Factory.StartNew(() => div[1].FindElements(By.TagName("input")));
                            if (inputs.Count > 0)
                            {
                                await SE.ClickElement(inputs[0]);
                                await SE.ClickElement(add_form[0].FindElement(By.XPath(".//input[@type='submit']")));
                            }
                            else
                            {
                                result_status = 1;
                            }
                        }
                        else
                        {
                            result_status = 2;
                        }
                    }
                    else
                    {
                        result_status = 1;
                    }
                }
                else
                {
                    result_status = 2;
                }
            }
            else
            {
                result_status = 1;
            }

            await SE.set_flag(true);
            return result_status;
        }

        public async Task<List<Group_Search>> groupSearch(string search, int min, int skip)
        {
            await SE.set_flag(false);
            List<Group_Search> results = new List<Group_Search>();

            await SE.Navigate("https://m.facebook.com/search/?search=group&ssid=0&o=69&refid=46&pn=2&query=" + HttpUtility.UrlEncode(search) + "&s=" + skip);

            var groups = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//form[@method='post']//tbody//tr"));

            if (groups.Count > 0)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    IWebElement a = await Task.Factory.StartNew(() => groups[i].FindElement(By.TagName("a")));
                    IWebElement div = await Task.Factory.StartNew(() => groups[i].FindElement(By.XPath(".//td//div")));

                    int memnum = 0;
                    string memcount = Regex.Match(div.GetAttribute("innerHTML"), @"\d+\.\d+").Value;
                    if (memcount != "")
                    {
                        memnum = int.Parse(memcount.Replace(".", string.Empty));
                    }
                    else
                    {
                        memcount = Regex.Match(div.GetAttribute("innerHTML"), @"\d+\,\d+").Value;
                        if (memcount != "")
                        {
                            memnum = int.Parse(memcount.Replace(",", string.Empty));
                        }
                        else
                        {
                            memcount = Regex.Match(div.GetAttribute("innerHTML"), @"\d+").Value;
                            memnum = int.Parse(memcount);
                        }
                    }

                    if (memnum >= min)
                    {
                        Group_Search result = new Group_Search();
                        result.group_name = a.GetAttribute("innerHTML");
                        result.group_url = a.GetAttribute("href");
                        result.group_count = memnum.ToString();
                        results.Add(result);
                    }
                }
            }

            await SE.set_flag(true);
            return results;
        }

        public async Task<bool> groupJoinable(string group_url)
        {
            await SE.Navigate(group_url);

            var inputs = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//form[@method='post']//input"));
            if (inputs.Count != 3 || await Task.Factory.StartNew(() => SE.driver.FindElementByXPath("//form[@method='post']").GetAttribute("action").Contains("canceljoin")))
            {
                return false;
            }
            return true;
        }

        public async Task<int> groupJoin(string group_url)
        {
            await SE.set_flag(false);
            int result_status = 0;

            await SE.Navigate(group_url);

            var page_info = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, '?view=info')]"));
            if (page_info.Count > 0)
            {
                await SE.ClickElement(page_info[0]);
                var join_btn = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href,'/group/join/')]"));
                if (join_btn.Count > 0)
                {
                    await SE.ClickElement(join_btn[0]);
                }
                else
                    result_status = 1;
            }
            else
                result_status = 1;

            await SE.set_flag(true);
            return result_status;
        }
    }

    public class Group_Search
    {
        public string group_name { get; set; }
        public string group_url { get; set; }
        public string group_count { get; set; }

        public override string ToString()
        {
            return group_name;
        }
    }
}

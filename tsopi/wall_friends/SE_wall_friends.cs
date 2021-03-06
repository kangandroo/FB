﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ipost.wall_friends
{
    class SE_wall_friends
    {
        SeleniumControl SE;

        public SE_wall_friends()
        {
            this.SE = f001_main.SE;
        }

        public async Task<string> auto_post(string user_url, string text, string[] images)
        {
            await SE.set_flag(false);

            string result_status = "Đăng bài thành công";
            /*
             * URL: thành công
             * 2: group không cho post bài
             * 0: rỗng nội dung và ảnh
             */
            await SE.Navigate(user_url.Replace("www.facebook", "m.facebook"));

            if (images[0] == "" && images[1] == "" && images[2] == "")
            {
                // Trường hợp không ảnh
                if (text != "")
                {
                    // Chỉ post chữ
                    if (SE.driver.FindElementsByName("xc_message").Count == 0)
                    {
                        result_status = "2";
                    }
                    else
                    {
                        await SE.RunScript(@"document.getElementsByName('xc_message')[0].innerHTML = '" + System.Web.HttpUtility.JavaScriptStringEncode(text + System.Environment.NewLine) + SeleniumControl.random_tag() + "';");
                        await SE.Click("view_post");

                        var url_to_comment_a = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, 'view=permalink')]"));
                        string post_url = Uri.UnescapeDataString(SE.driver.Url);
                        if (url_to_comment_a.Count > 0)
                            post_url = url_to_comment_a[0].GetAttribute("href");
                        result_status = post_url;
                    }
                }
                else
                {
                    // Rỗng cả ảnh lẫn nội dung
                    result_status = "0";
                }
            }
            else
            {
                // Trường hợp có ảnh
                if (await Task.Factory.StartNew(() => SE.driver.FindElementsByName("lgc_view_photo").Count) == 0)
                {
                    result_status = "2";
                }
                else
                {
                    await SE.Click("lgc_view_photo");

                    await SE.RunScript(@"document.getElementsByName('xc_message')[0].innerHTML = '" + System.Web.HttpUtility.JavaScriptStringEncode(text + System.Environment.NewLine) + SeleniumControl.random_tag() + "';");

                    await SE.InputFileAdd("file1", images[0]);
                    await SE.InputFileAdd("file2", images[1]);
                    await SE.InputFileAdd("file3", images[2]);

                    await SE.Click("photo_upload");

                    string result_url = "";
                    try
                    {
                        Match match = Regex.Match(SE.driver.Url + "", @"\?photo_id\=([A-Za-z0-9\-]+)\&", RegexOptions.None);
                        if (match.Success)
                        {
                            result_url = "https://www.facebook.com/photo.php?fbid=" + match.Groups[1].Value;
                        }
                        else
                        {
                            match = Regex.Match(Uri.UnescapeDataString(SE.driver.Url) + "", @"\?photo_fbid\=([A-Za-z0-9\-]+)\&", RegexOptions.None);
                            if (match.Success)
                            {
                                result_url = "https://www.facebook.com/photo.php?fbid=" + match.Groups[1].Value;
                            }
                            else
                                result_url = Uri.UnescapeDataString(SE.driver.Url);
                        }
                        result_status = result_url;
                    }
                    catch { }
                }
            }

            await SE.set_flag(true);
            return result_status;
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipost.comment
{
    class SE_comment
    {
        SeleniumControl SE;

        public SE_comment()
        {
            this.SE = f001_main.SE;
        }

        public async Task<CommentResult> ScanComment(string group_id, string comment, bool only_me)
        {
            await SE.set_flag(false);
            CommentResult result = new CommentResult();
            result.url = "Không tìm thấy";
            result.content = "Không tìm thấy";

            await SE.Navigate("https://m.facebook.com/groups/" + group_id);

            string post_xpath = "";
            if (only_me)
                post_xpath = "//div[@id='m_group_stories_container']//a[contains(@href,'__tn__=C') and contains(@href, '" + SE.user_id + "')]";
            else
                post_xpath = "//div[@id='m_group_stories_container']//a[contains(@href,'__tn__=C')]";
            var post_match = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath(post_xpath));

            if (post_match.Count > 0)
            {
                var post_url = await Task.Factory.StartNew(() => post_match[0].FindElements(By.XPath("(.//ancestor::div[@id])[last()]"))); //(.//ancestor::div[@id])[last()]
                if (post_url.Count > 0)
                {
                    if (only_me)
                    {
                        var url_to_comment_a = await Task.Factory.StartNew(() => post_url[0].FindElements(By.XPath(".//a[contains(@href, 'view=permalink')]")));
                        await SE.ClickElement(url_to_comment_a[0]);
                    }
                    else
                    {
                        var url_to_comment_a = await Task.Factory.StartNew(() => SE.driver.FindElements(By.XPath("//a[contains(@href, 'view=permalink')]")));
                        await SE.ClickElement(url_to_comment_a[0]);
                    }

                    result.url = SE.driver.Url;

                    if (await Task.Factory.StartNew(() => SE.driver.FindElementsByName("comment_text").Count) == 0)
                    {
                        result.content = "Chặn bình luận";
                    }
                    else
                    {
                        await Task.Factory.StartNew(() => SE.driver.ExecuteScript(@"document.getElementsByName('comment_text')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(comment + " ") + SeleniumControl.random_tag() + "';"));

                        IWebElement btnSubmit = await Task.Factory.StartNew(() => SE.driver.FindElementByXPath("//form[@method='post']//input[@type='submit']"));
                        await SE.ClickElement(btnSubmit);
                        result.content = "Bình luận thành công";
                        var p = await Task.Factory.StartNew(() => SE.driver.FindElementsByTagName("p"));
                        if (p.Count > 0)
                            result.content = p[0].Text;
                    }
                }
            }
            else
            {
                result.url = "https://www.facebook.com/groups" + group_id;
            }

            await SE.set_flag(true);
            return result;
        }

        public async Task<CommentResult> FileComment(string target_url, string comment)
        {
            await SE.set_flag(false);
            CommentResult result = new CommentResult();
            result.url = target_url;

            await SE.Navigate(target_url);

            if (await Task.Factory.StartNew(() => SE.driver.FindElementsByName("comment_text").Count) == 0)
            {
                result.content = "Chặn bình luận";
            }
            else
            {
                await Task.Factory.StartNew(() => SE.driver.ExecuteScript(@"document.getElementsByName('comment_text')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(comment + " ") + SeleniumControl.random_tag() + "';"));

                IWebElement btnSubmit = await Task.Factory.StartNew(() => SE.driver.FindElementByXPath("//form[@method='post']//input[@type='submit']"));
                await SE.ClickElement(btnSubmit);
                result.content = "Bình luận thành công";
                var p = await Task.Factory.StartNew(() => SE.driver.FindElementsByTagName("p"));
                if (p.Count > 0)
                    result.content = p[0].Text;
            }

            await SE.set_flag(true);
            return result;
        }

        public async Task<CommentResult> PageComment(string page_id, string comment)
        {
            await SE.set_flag(false);
            CommentResult result = new CommentResult();

            await SE.Navigate("https://m.facebook.com/" + page_id);
            result.url = SE.driver.Title;

            var page_posts = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//div[@id='recent']//div[@id]"));

            if (page_posts.Count > 0)
            {
                var post = page_posts[0].FindElements(By.XPath(".//a[contains(@href, 'story.php') or contains(@href, '/photos/')]"));

                if (post.Count > 0)
                {
                    await SE.ClickElement(post[0]);

                    var comments = await Task.Factory.StartNew(() => SE.driver.FindElementsByXPath("//a[contains(@href, '/comment/replies/')]"));

                    if (comments.Count > 0)
                    {
                        await SE.ClickElement(comments[0]);
                    }

                    if (await Task.Factory.StartNew(() => SE.driver.FindElementsByName("comment_text").Count) == 0)
                    {
                        result.content = "Page không cho bình luận";
                    }
                    else
                    {
                        await Task.Factory.StartNew(() => SE.RunScript(@"document.getElementsByName('comment_text')[0].value = '" + System.Web.HttpUtility.JavaScriptStringEncode(comment + " ") + "';"));

                        IWebElement btnSubmit = await Task.Factory.StartNew(() => SE.driver.FindElementByXPath("//form[@method='post']//input[@type='submit']"));

                        await SE.ClickElement(btnSubmit);

                        result.content = "Bình luận thành công";
                        var p = await Task.Factory.StartNew(() => SE.driver.FindElementsByTagName("p"));
                        if (p.Count > 0)
                            result.content = p[0].Text;
                    }
                }
                else
                {
                    result.content = "Không tìm được bài đăng";
                }
            }

            await SE.set_flag(true);
            return result;
        }
    }

    public class CommentResult
    {
        public string content { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return url;
        }
    }
}

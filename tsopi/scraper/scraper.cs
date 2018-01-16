using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipost.IDScraper
{
    public partial class scraper : Form
    {
        /*
         * grScraper.AddNewRow();
                        int newRowHandle = grScraper.FocusedRowHandle;
                        grScraper.SetRowCellValue(newRowHandle, "user_id", result_item_splitted[0]);
                        grScraper.SetRowCellValue(newRowHandle, "user_name", result_item_splitted[0]);
                        grScraper.UpdateCurrentRow();
         * 
         */
        bool graph_search_flag = false;
        DataTable scraper_dt;

        public scraper()
        {
            InitializeComponent();

            scraper_dt = new DataTable();
            scraper_dt.Columns.Add("user_id", typeof(string));
            scraper_dt.Columns.Add("user_name", typeof(string));
            gridScraper.DataSource = scraper_dt;
        }

        public void btnScraperImport_Click(object sender, EventArgs e)
        {
            var fDialog = new System.Windows.Forms.OpenFileDialog();
            fDialog.Title = "Open Groups File";
            fDialog.Filter = "TXT Files (*.txt) | *.txt";

            DialogResult result = fDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fDialog.FileName;

                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader fileStr = new System.IO.StreamReader(file);
                while ((line = fileStr.ReadLine()) != null)
                {
                    string[] _line = line.Split('|');
                    if (_line.Length > 1)
                        scraper_dt.Rows.Add(_line[0], _line[1]);
                    else
                        scraper_dt.Rows.Add(_line[0], "");

                    counter++;
                }

                fileStr.Close();

                MessageBox.Show("Đọc thành công: " + counter + " UID");
            }
        }

        private void scraper_Shown(object sender, EventArgs e)
        {
            // Lấy bạn bè
            List<Tuple<string, string>> _friends = f001_main.SE.friends;

            if (_friends.Count > 0)
            {
                foreach (Tuple<string, string> _friend in _friends)
                {
                    listScraperMeFriends.Items.Add(_friend.Item1 + "|" + _friend.Item2);
                }
            }

            // Nạp dữ liệu vào graph
            Dictionary<string, string> relationships = new Dictionary<string, string>();
            relationships.Add("-- Chọn mối quan hệ --", "");
            relationships.Add("Độc thân", "single");
            relationships.Add("Đang hẹn hò", "engaged");
            relationships.Add("Đã đính hôn", "married");
            relationships.Add("Đang có quan hệ kết hợp dân sự", "in-civil-union");
            relationships.Add("Đang có quan hệ chung sống", "in-domestic-partnership");
            relationships.Add("Đang trong một mối quan hệ mở", "in-open-relationship");
            relationships.Add("Có mối quan hệ phức tạp", "its-complicated");
            relationships.Add("Đã ly thân", "separated");
            relationships.Add("Đã ly hôn", "divorced");
            relationships.Add("Góa", "widowed");

            cbGraphSearchRelationship.DataSource = new BindingSource(relationships, null);
            cbGraphSearchRelationship.DisplayMember = "Key";
            cbGraphSearchRelationship.ValueMember = "Value";

            Dictionary<string, string> genders = new Dictionary<string, string>();
            genders.Add("-- Chọn giới tính --", "");
            genders.Add("Nam", "males");
            genders.Add("Nữ", "females");

            cbGraphSearchGender.DataSource = new BindingSource(genders, null);
            cbGraphSearchGender.DisplayMember = "Key";
            cbGraphSearchGender.ValueMember = "Value";

            Dictionary<string, string> locations = new Dictionary<string, string>();
            locations.Add("-- Chọn địa điểm --", "");
            locations.Add("Hà Nội", "653678611405322");
            locations.Add("Sài Gòn", "108458769184495");
            locations.Add("Hải Phòng", "106480866055537");
            locations.Add("Đà Nẵng", "108680672485750");
            locations.Add("Cần Thơ", "200647606648129");
            locations.Add("Huế", "218845041469665");
            locations.Add("An Giang", "207893272587826");
            locations.Add("Bà Rịa-Vũng Tàu", "230834780261698");
            locations.Add("Bắc Giang", "123356831042645");
            locations.Add("Bắc Kạn", "203910742994900");
            locations.Add("Bạc Liêu", "143723648974763");
            locations.Add("Bắc Ninh", "218692191496704");
            locations.Add("Bến Tre", "127533130662887");
            locations.Add("Bình Định", "179135122143090");
            locations.Add("Bình Dương", "111054738947356");
            locations.Add("Bình Phước", "136822029673918");
            locations.Add("Bình Thuận", "136236749787639");
            locations.Add("Cà Mau", "134734219893898");
            locations.Add("Cao Bằng", "158439030892194");
            locations.Add("Đắk Lắk", "220015058020059");
            locations.Add("Đắk Nông", "145539615474774");
            locations.Add("Điện Biên", "131848836851746");
            locations.Add("Đồng Nai", "226501404045673");
            locations.Add("Đồng Tháp", "229752680369251");
            locations.Add("Gia Lai", "105507146149478");
            locations.Add("Hà Giang", "138384686237015");
            locations.Add("Hà Nam", "181898638532823");
            locations.Add("Hà Tĩnh", "106071772820376");
            locations.Add("Hải Dương", "142497105766535");
            locations.Add("Hậu Giang", "132577670114334");
            locations.Add("Hòa Bình", "157632727638299");
            locations.Add("Hưng Yên", "224057691054284");
            locations.Add("Khánh Hòa", "182187055168754");
            locations.Add("Kiên Giang", "190273344355192");
            locations.Add("Kon Tum", "136085656469482");
            locations.Add("Lai Châu", "106168192809288");
            locations.Add("Lâm Đồng", "181150778610076");
            locations.Add("Lạng Sơn", "219488861407845");
            locations.Add("Lào Cai", "111931488896572");
            locations.Add("Long An", "181188978602467");
            locations.Add("Nam Định", "126680564042557");
            locations.Add("Nghệ An", "218291451525202");
            locations.Add("Ninh Bình", "173433072715815");
            locations.Add("Ninh Thuận", "122698181148149");
            locations.Add("Phú Thọ", "106360619519357");
            locations.Add("Quảng Bình", "219629284735897");
            locations.Add("Quảng Nam", "181233888597247");
            locations.Add("Quảng Ngãi", "229709137040583");
            locations.Add("Quảng Ninh", "236165276400270");
            locations.Add("Quảng Trị", "180792875308959");
            locations.Add("Sóc Trăng", "190882644293799");
            locations.Add("Sơn La", "157307184338304");
            locations.Add("Tây Ninh", "236615026355960");
            locations.Add("Thái Bình", "230768746949790");
            locations.Add("Thái Nguyên", "143702682308507");
            locations.Add("Thanh Hóa", "174392935953406");
            locations.Add("Tiền Giang", "178567655535334");
            locations.Add("Trà Vinh", "169588163105473");
            locations.Add("Tuyên Quang", "191472724236945");
            locations.Add("Vĩnh Long", "232731256737055");
            locations.Add("Vĩnh Phúc", "117389788348928");
            locations.Add("Yên Bái", "111847648907067");
            locations.Add("Phú Yên", "224597557570151");

            cbGraphSearchLocation.DataSource = new BindingSource(locations, null);
            cbGraphSearchLocation.DisplayMember = "Key";
            cbGraphSearchLocation.ValueMember = "Value";
        }

        private void btnScraperClear_Click(object sender, EventArgs e)
        {
            scraper_dt.Rows.Clear();
        }

        private async void btnScraperFriendsUIDInput_Click(object sender, EventArgs e)
        {
            await getUIDFriends(txtScraperUID.Text);
        }

        private async Task getUIDFriends(string UID)
        {
            if (UID != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                List<Tuple<string, string>> _friends = await cSE.graphGetFriends(UID);
                grScraper.HideLoadingPanel();

                if (_friends.Count > 0)
                {
                    foreach (Tuple<string, string> _friend in _friends)
                    {
                        scraper_dt.Rows.Add(_friend.Item1, _friend.Item2);
                    }
                }
            }
        }

        private void ListBox2GridScraper(ListBox list)
        {
            if (list.Items.Count > 0)
            {
                foreach (var list_item in list.Items)
                {
                    string[] data;
                    data = list_item.ToString().Split('|');
                    if (data.Length == 2)
                    {
                        scraper_dt.Rows.Add(data[0], data[1]);
                    }
                }
            }
        }

        private void btnScraperMeFriendsInput_Click(object sender, EventArgs e)
        {
            ListBox2GridScraper(listScraperMeFriends);
        }

        private void updateGridScraperCount()
        {
            groupScraperGrid.Text = "Danh sách UID (" + grScraper.DataRowCount + ")";
        }

        private void grScraper_RowCountChanged(object sender, EventArgs e)
        {
            updateGridScraperCount();
        }

        private async void btnScraperGroupSearch_Click(object sender, EventArgs e)
        {
            if (txtScraperGroupSearch.Text != "")
            {
                listScraperGroupSearch.Items.Clear();

                SE_scraper cSE = new SE_scraper();

                api_group_members _members = await cSE.graphGetMembers("/search?q=" + txtScraperGroupSearch.Text + "&type=group&");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_group_member _member in _members.data)
                        {
                            listScraperGroupSearch.Items.Add(_member.id + "|" + _member.name);
                        }
                    }
                    lblScraperGroupSearch.Text = "Danh sách nhóm (" + listScraperGroupSearch.Items.Count + ")";
                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetMembers(_members.paging.next);
                }
            }
        }

        private async void btnScraperGroupGIDInput_Click(object sender, EventArgs e)
        {
            await getGroupMembers(txtScraperGroupGIDInput.Text);
        }

        private async Task getGroupMembers(string GID)
        {
            if (GID != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                api_group_members _members = await cSE.graphGetMembers("/" + GID + "/members?");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_group_member _member in _members.data)
                        {
                            scraper_dt.Rows.Add(_member.id, _member.name);
                        }
                    }

                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetMembers(_members.paging.next);
                }

                grScraper.HideLoadingPanel();
            }
        }

        private void listScraperGroupSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtScraperGroupGIDInput.Text = listScraperGroupSearch.SelectedItem.ToString().Split('|')[0];
        }

        private void listScraperMeFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtScraperUID.Text = listScraperMeFriends.SelectedItem.ToString().Split('|')[0];
        }

        private async void btnScraperFilter_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = i + 1; j < dt.Rows.Count; j++)
                {
                    string compare = dt.Rows[i].Field<string>(0);
                    if (compare == dt.Rows[j].Field<string>(0))
                    {
                        dt.Rows.RemoveAt(j);
                        j--;
                    }
                }
            }*/
            grScraper.ShowLoadingPanel();
            DataTable dt = await Task.Factory.StartNew(() => scraper_dt.DefaultView.ToTable(true).Copy());
            scraper_dt.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                scraper_dt.ImportRow(row);
            }
            grScraper.HideLoadingPanel();
        }

        private async void btnScraperFriendsInput_Click(object sender, EventArgs e)
        {
            if (listScraperMeFriends.SelectedItems.Count > 0)
            {
                foreach (var selectedUID in listScraperMeFriends.SelectedItems)
                {
                    string[] selectedUID_splitted = selectedUID.ToString().Split('|');
                    if (selectedUID_splitted.Length == 2)
                    {
                        await getUIDFriends(selectedUID_splitted[0]);
                    }
                }
            }
        }

        private async void btnScraperGroupMembersInput_Click(object sender, EventArgs e)
        {
            if (listScraperGroupSearch.SelectedItems.Count > 0)
            {
                foreach (var selectedGID in listScraperGroupSearch.SelectedItems)
                {
                    string[] selectedGID_splitted = selectedGID.ToString().Split('|');
                    if (selectedGID_splitted.Length == 2)
                    {
                        await getGroupMembers(selectedGID_splitted[0]);
                    }
                }
            }
        }

        private async void btnPostLike_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                api_group_members _members = await cSE.graphGetMembers("/" + txtPostID.Text + "/likes?");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_group_member _member in _members.data)
                        {
                            scraper_dt.Rows.Add(_member.id, _member.name);
                        }
                    }

                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetMembers(_members.paging.next);
                }

                grScraper.HideLoadingPanel();
            }
        }

        private async void btnPostComment_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                api_post_comments _members = await cSE.graphGetCommenters("/" + txtPostID.Text + "/comments?fields=from&");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_post_comment _member in _members.data)
                        {
                            scraper_dt.Rows.Add(_member.from.id, _member.from.name);
                        }
                    }

                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetCommenters(_members.paging.next);
                }

                grScraper.HideLoadingPanel();
            }
        }

        private async void btnEventGetInvited_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                api_group_members _members = await cSE.graphGetMembers("/" + txtEventID.Text + "/noreply?fields=name,id&");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_group_member _member in _members.data)
                        {
                            scraper_dt.Rows.Add(_member.id, _member.name);
                        }
                    }

                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetMembers(_members.paging.next);
                }

                grScraper.HideLoadingPanel();
            }
        }

        private async void btnEventGetJoined_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text != "")
            {
                SE_scraper cSE = new SE_scraper();

                grScraper.ShowLoadingPanel();
                api_group_members _members = await cSE.graphGetMembers("/" + txtEventID.Text + "/attending?fields=name,id&");

                while (true)
                {
                    if (_members.data.Length > 0)
                    {
                        foreach (api_group_member _member in _members.data)
                        {
                            scraper_dt.Rows.Add(_member.id, _member.name);
                        }
                    }

                    if (_members.paging == null || _members.paging.next == null) break;
                    _members = await cSE.graphGetMembers(_members.paging.next);
                }

                grScraper.HideLoadingPanel();
            }
        }

        private async void btnGraphSearchURL_Click(object sender, EventArgs e)
        {
            graph_search_flag = !graph_search_flag;
            if (graph_search_flag)
            {
                btnGraphSearchURL.Text = "|| Dừng";
                await getGraphSearchUsers(txtGraphSearchURL.Text);
            }
            else
            {
                btnGraphSearchURL.Text = "Lấy UID >>";
            }
        }

        private async Task getGraphSearchUsers(string URL)
        {
            grScraper.ShowLoadingPanel();
            await f001_main.SE2.set_flag(false);
            if (URL.Contains("https://www.facebook.com/search/"))
            {
                await f001_main.SE2.Navigate(URL);

                var targets = await Task.Factory.StartNew(() => f001_main.SE2.driver.FindElementsByXPath("//div[@id='BrowseResultsContainer']//div[@data-bt and @id and contains(@data-bt,'rank')]"));

                if (targets.Count > 0)
                {
                    // <div id='BrowseResultsContainer'>
                    foreach (IWebElement target in targets)
                    {
                        string sub_header = "";
                        var sub_headers = await Task.Factory.StartNew(() => target.FindElements(By.XPath(".//a[contains(@href,'ref=br_rs')]")));
                        if (sub_headers.Count > 1)
                            sub_header = sub_headers[1].Text;
                        scraper_dt.Rows.Add(target.GetAttribute("data-bt").Replace("{\"id\":", "").Split(',')[0], sub_header);
                    }
                    // <div id='~~~browse_result_below_fold'>
                    var targets_below_fold = await Task.Factory.StartNew(() => f001_main.SE2.driver.FindElementsByXPath("//div[contains(@id,'browse_result_below_fold')]//div[@data-bt and @id and contains(@data-bt,'rank')]"));
                    if (targets_below_fold.Count > 0)
                    {
                        foreach (IWebElement target_below_fold in targets_below_fold)
                        {
                            string sub_header = "";
                            var sub_headers = await Task.Factory.StartNew(() => target_below_fold.FindElements(By.XPath(".//a[contains(@href,'ref=br_rs')]")));
                            if (sub_headers.Count > 1)
                                sub_header = sub_headers[1].Text;
                            scraper_dt.Rows.Add(target_below_fold.GetAttribute("data-bt").Replace("{\"id\":", "").Split(',')[0], sub_header);
                        }
                    }
                    int scraped_page = 0;
                    while (true && graph_search_flag)
                    {
                        f001_main.SE2.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
                        if (await Task.Factory.StartNew(() => f001_main.SE2.driver.FindElementsById("browse_end_of_results_footer").Count) == 1)
                            break;
                        f001_main.SE2.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
                        f001_main.SE2.driver.ExecuteScript(@"window.scrollTo(0,document.body.scrollHeight);");
                        await Task.Delay(1000);
                        var scrolling_pager_container = await Task.Factory.StartNew(() => f001_main.SE2.driver.FindElementsByXPath("//div[contains(@id,'fbBrowseScrollingPagerContainer')]"));
                        while (scrolling_pager_container.Count > scraped_page)
                        {
                            var user_items = await Task.Factory.StartNew(() => scrolling_pager_container[scraped_page].FindElements(By.XPath(".//div[@data-bt and @id and contains(@data-bt,'rank')]")));
                            if (user_items.Count > 0)
                                foreach (IWebElement user_item in user_items)
                                {
                                    string sub_header = "";
                                    var sub_headers = await Task.Factory.StartNew(() => user_item.FindElements(By.XPath(".//a[contains(@href,'ref=br_rs')]")));
                                    if (sub_headers.Count > 1)
                                        sub_header = sub_headers[1].Text;
                                    scraper_dt.Rows.Add(user_item.GetAttribute("data-bt").Replace("{\"id\":", "").Split(',')[0], sub_header);
                                }

                            scraped_page++;
                        }
                    }
                    MessageBox.Show("Hoàn tất tìm kiếm Graph Search.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả nào! Hãy chắc chắn bạn đang dùng ngôn ngữ Tiếng Việt hoặc English(US) cho Tài khoản FB của mình");
                }
            }
            else
            {
                MessageBox.Show("Bạn vừa nhập không phải là Graph URL.");
            }

            btnGraphSearchURL.Text = "Lấy UID >>";
            await f001_main.SE2.set_flag(true);
            grScraper.HideLoadingPanel();
        }

        private async void btnGraphURLGen_Click(object sender, EventArgs e)
        {
            picGraphURLLoading.Visible = true;
            txtGraphSearchURL.Text = "";
            await f001_main.SE.set_flag(false);

            string search_request = "https://www.facebook.com/search";
            if (cbGraphSearchMutual.Checked)
                search_request += "/me/friends/friends";
            string gs_relationship = ((KeyValuePair<string, string>)cbGraphSearchRelationship.SelectedItem).Value;
            if (gs_relationship != "") search_request += "/" + gs_relationship + "/users";
            string gs_location = ((KeyValuePair<string, string>)cbGraphSearchLocation.SelectedItem).Value;
            if (gs_location != "") search_request += "/" + gs_location + "/residents-near/present";
            List<string> gs_pages = new List<string>();
            if (txtGraphSearchPage1.Text.Contains("https://www.facebook.com/"))
            {
                await Task.Factory.StartNew(() => f001_main.SE.Navigate(txtGraphSearchPage1.Text.Replace("www.facebook", "m.facebook")));
                var temp1 = await Task.Factory.StartNew(() => f001_main.SE.driver.FindElementsByXPath("//a[contains(@href,'/pages/more/')]"));
                if (temp1.Count > 0)
                {
                    Match match = Regex.Match(temp1[0].GetAttribute("href"), @"\/pages\/more\/([0-9]+)", RegexOptions.None);
                    if (match.Success)
                    {
                        gs_pages.Add(match.Groups[1].Value);
                    }
                }
            }
            if (txtGraphSearchPage2.Text.Contains("https://www.facebook.com/"))
            {
                await Task.Factory.StartNew(() => f001_main.SE.Navigate(txtGraphSearchPage2.Text.Replace("www.facebook", "m.facebook")));
                var temp1 = await Task.Factory.StartNew(() => f001_main.SE.driver.FindElementsByXPath("//a[contains(@href,'/pages/more/')]"));
                if (temp1.Count > 0)
                {
                    Match match = Regex.Match(temp1[0].GetAttribute("href"), @"\/pages\/more\/([0-9]+)", RegexOptions.None);
                    if (match.Success)
                    {
                        gs_pages.Add(match.Groups[1].Value);
                    }
                }
            }
            if (gs_pages.Count > 0)
            {
                foreach (string gs_page in gs_pages)
                {
                    search_request += "/" + gs_page + "/likers";
                }
            }
            if (txtGraphSearchUsersNamed.Text != "")
                search_request += "/str/" + txtGraphSearchUsersNamed.Text + "/users-named";
            string gs_gender = ((KeyValuePair<string, string>)cbGraphSearchGender.SelectedItem).Value;
            if (gs_gender != "") search_request += "/" + gs_gender;
            int gs_age1, gs_age2;
            if (int.TryParse(txtGraphSearchAge1.Text, out gs_age1) && int.TryParse(txtGraphSearchAge2.Text, out gs_age2) && gs_age2 >= gs_age1)
            {
                search_request += "/" + gs_age1 + "/" + gs_age2 + "/users-age-2";
            }

            int num_of_slash = 0;
            for (int k = 0; k < search_request.Length; k++)
            {
                if (search_request[k] == '/')
                    num_of_slash++;
            }
            if (num_of_slash > 3 || (num_of_slash == 3 && !search_request.Contains("users-age-2") && !search_request.Contains("users-named")))
                search_request += "/intersect";

            txtGraphSearchURL.Text = search_request;

            await f001_main.SE.set_flag(true);
            picGraphURLLoading.Visible = false;
        }

        private async void btnScraperFriendsURLInput_Click(object sender, EventArgs e)
        {
            picScraperFriendsURLLoading.Visible = true;
            string targetUID = txtScraperGetUID.Text;
            if (targetUID.Contains("id="))
            {
                targetUID = targetUID.Substring(targetUID.IndexOf("id=") + 3);
                targetUID = targetUID.Split('&')[0];
            }
            else
            {
                await f001_main.SE.set_flag(false);

                await f001_main.SE.Navigate(targetUID);

                var a_more = await Task.Factory.StartNew(() => f001_main.SE.driver.FindElementsByXPath("//a[contains(@href, 'owner_id')]"));

                if (a_more.Count > 0)
                {
                    targetUID = a_more[0].GetAttribute("href");
                    targetUID = targetUID.Substring(targetUID.IndexOf("owner_id=") + 9);
                    targetUID = targetUID.Split('&')[0];
                }

                await f001_main.SE.set_flag(true);
            }
            if (targetUID == txtScraperGetUID.Text)
            {
                MessageBox.Show("Không thể quét được ID của profile này. Hãy tham khảo cách hướng dẫn lấy ID khác.");
            }
            else
                txtScraperUID.Text = targetUID;
            picScraperFriendsURLLoading.Visible = false;
        }

        private async void btnScraperGroupURLInput_Click(object sender, EventArgs e)
        {
            picScraperGroupURLLoading.Visible = true;

            string targetGID = txtScraperGroupURLInput.Text;

            if (targetGID.Contains("/groups/"))
            {
                targetGID = targetGID.Substring(targetGID.IndexOf("/groups/") + 8);
                targetGID = targetGID.Split('?')[0];
            }

            if (!targetGID.All(char.IsDigit))
            {
                await f001_main.SE.set_flag(false);
                await f001_main.SE.Navigate(txtScraperGroupURLInput.Text);

                var info = await Task.Factory.StartNew(() => f001_main.SE.driver.FindElementsByXPath("//a[contains(@href, '/groups/') and contains(@href, '?view')]"));
                if (info.Count > 0)
                {
                    targetGID = info[0].GetAttribute("href");
                    targetGID = targetGID.Substring(targetGID.IndexOf("/groups/") + 8);
                    targetGID = targetGID.Split('?')[0];
                }
                else
                {
                    targetGID = txtScraperGroupURLInput.Text;
                }
                await f001_main.SE.set_flag(true);
            }

            if (targetGID == txtScraperGroupURLInput.Text)
            {
                MessageBox.Show("Không thể quét được ID của profile này. Hãy tham khảo cách hướng dẫn lấy ID khác.");
            }
            else
                txtScraperGroupGIDInput.Text = targetGID;

            picScraperGroupURLLoading.Visible = false;
        }

        private void btnPostGetID_Click(object sender, EventArgs e)
        {
            txtPostID.Text = "";
            if (txtPostURL.Text.Contains("/posts/"))
            {
                txtPostID.Text = txtPostURL.Text.Substring(txtPostURL.Text.IndexOf("/posts/") + 7);
                txtPostID.Text = txtPostID.Text.Split('?')[0];
            }
            else if (txtPostURL.Text.Contains("fbid="))
            {
                txtPostID.Text = txtPostURL.Text.Substring(txtPostURL.Text.IndexOf("fbid=") + 5);
                txtPostID.Text = txtPostID.Text.Split('&')[0];
            }
            else if (txtPostURL.Text.Contains("/photos/"))
            {
                txtPostID.Text = txtPostURL.Text.Substring(txtPostURL.Text.IndexOf("/photos/") + 8);
                string[] splitted = txtPostID.Text.Split('/');
                if (splitted.Length > 1)
                {
                    txtPostID.Text = splitted[1];
                }
                else
                {
                    txtPostID.Text = "";
                }
            }
            if (txtPostID.Text == "")
            {
                MessageBox.Show("Không thể quét được ID của bài này. Hãy tham khảo cách hướng dẫn lấy ID khác.");
            }
        }

        private void btnEventGetID_Click(object sender, EventArgs e)
        {
            txtEventID.Text = "";

            if (txtEventURL.Text.Contains("/events/"))
            {
                txtEventID.Text = txtEventURL.Text.Substring(txtEventURL.Text.IndexOf("/events/") + 8);
                txtEventID.Text = txtEventID.Text.Split('/')[0];
            }

            if (txtEventID.Text == "")
            {
                MessageBox.Show("Không thể quét được ID của bài này. Hãy tham khảo cách hướng dẫn lấy ID khác.");
            }
        }

        private void btnScraperExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "TXT files (*.txt)|*.txt";
            saveFile.FileName = "UID_" + DateTime.Today.ToString("dd_MM_yyyy") + "_" + grScraper.RowCount + ".txt";
            saveFile.ShowDialog();

            using (StreamWriter sw = new StreamWriter(saveFile.FileName, false))
            {
                if (grScraper.RowCount > 0)
                {
                    for (int i = 0; i < grScraper.RowCount; i++)
                    {
                        string user_id = grScraper.GetRowCellValue(i, "user_id").ToString();
                        string user_name = grScraper.GetRowCellValue(i, "user_name").ToString();
                        sw.WriteLine(user_id + "|" + user_name);
                    }
                }
                sw.Close();
            }
        }

        private void gridScraper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == System.Windows.Forms.Keys.C)
            {
                Clipboard.SetText(grScraper.GetFocusedDisplayText());
                e.Handled = true;
            }
        }
    }
}

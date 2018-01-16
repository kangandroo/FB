using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ipost.IDScraper
{
    class SE_scraper
    {
        SeleniumControl SE;
        SeleniumControl SE2;

        public SE_scraper()
        {
            this.SE = f001_main.SE;
            this.SE2 = f001_main.SE2;
        }

        // graph api
        // https://graph.facebook.com/search?q=QUERY&type=OBJECT_TYPE

        public async Task<List<Tuple<string, string>>> graphGetFriends(string UID)
        {
            List<Tuple<string, string>> _friends = new List<Tuple<string, string>>();
            
            string json_response = await SeleniumControl.getGraphResponse("/" + UID + "/friends?limit=5000&");

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

            return _friends;
        }

        public async Task<api_group_members> graphGetMembers(string graph_url)
        {
            List<Tuple<string, string>> _friends = new List<Tuple<string, string>>();
            string json_response = await SeleniumControl.getGraphResponse(graph_url);
            api_group_members _members;

            if (json_response != "")
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                _members = js.Deserialize<api_group_members>(json_response);
            }
            else
            {
                _members = new api_group_members();
            }

            return _members;
        }

        public async Task<api_post_comments> graphGetCommenters(string graph_url)
        {
            List<Tuple<string, string>> _friends = new List<Tuple<string, string>>();
            string json_response = await SeleniumControl.getGraphResponse(graph_url);
            api_post_comments _members;

            if (json_response != "")
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                _members = js.Deserialize<api_post_comments>(json_response);
            }
            else
            {
                _members = new api_post_comments();
            }

            return _members;
        }
    }
}

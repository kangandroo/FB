using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipost
{
    public class api_group_members
    {
        public api_group_member[] data { get; set; }
        public api_paging paging { get; set; }
        public api_error error { get; set; }
    }

    public class api_paging
    {
        public string next { get; set; }
    }

    public class api_error
    {
        public string message { get; set; }
        public string type { get; set; }
        public int code { get; set; }
    }
}

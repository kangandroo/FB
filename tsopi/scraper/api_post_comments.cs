using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipost
{
    class api_post_comments
    {
        public api_post_comment[] data { get; set; }
        public api_paging paging { get; set; }
        public api_error error { get; set; }
    }
}

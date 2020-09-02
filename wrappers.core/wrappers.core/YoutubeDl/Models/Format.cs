using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;

namespace wrappers.core.YoutubeDl.Models
{
    public class Format
    {
        public string asr { get; set; }
        public string acodec { get; set; }
        public string format { get; set; }
        public string url { get; set; }
        public HttpHeader http_headers { get; set; }
        public string ext { get; set; }
        public int? filesize { get; set; }
        public string vcodec { get; set; }
        public string format_id { get; set; }
        public string manifest_url { get; set; }
        public string language { get; set; }
        public List<Fragment> fragments { get; set; }
        public string fragment_base_url { get; set; }
        public int? fps { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public string format_note { get; set; }
        public decimal? tbr { get; set; }
        public string protocol { get; set; }
        public string container { get; set; }
    
    }
}

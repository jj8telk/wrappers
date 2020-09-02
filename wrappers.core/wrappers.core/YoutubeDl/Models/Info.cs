using System;
using System.Collections.Generic;
using System.Text;

namespace wrappers.core.YoutubeDl.Models
{
    public class Info
    {
        public List<string> tags { get; set; }
        public string webpage_url { get; set; }
        public string format_id { get; set; }
        public string like_count { get; set; }
        public string creator { get; set; }
        public string vcodec { get; set; }
        public string release_date { get; set; }
        public string playlist_index { get; set; }
        public string thumbnail { get; set; }
        public List<Format> requested_formats { get; set; }
        public string track { get; set; }
        public string ext { get; set; }
        public decimal? vbr { get; set; }
        public string description { get; set; }
        public string requested_subtitles { get; set; }
        public string acodec { get; set; }
        public string alt_title { get; set; }
        public string format { get; set; }
        public int? age_limit { get; set; }
        public string artist { get; set; }
        public string uploader_id { get; set; }
        public string upload_date { get; set; }
        public int? height { get; set; }
        public string fulltitle { get; set; }
        public decimal? average_rating { get; set; }
        public string stretch_ratio { get; set; }
        public string title { get; set; }
        public string _filename { get; set; }
        public string channel_url { get; set; }
        public string id { get; set; }
        public int? dislike_count { get; set; }
        public string license { get; set; }
        public dynamic subtitles { get; set; }
        public List<Format> formats { get; set; }
        public string extractor { get; set; }
        public string end_time { get; set; }
        public int? width { get; set; }
        public List<Thumbnail> thumbnails { get; set; }
        public string display_id { get; set; }
        public string series { get; set; }
        public string album { get; set; }
        public string uploader_url { get; set; }
        public string extractor_key { get; set; }
        public int? view_count { get; set; }
        public int? season_number { get; set; }
        public string annotations { get; set; }
        public string chapters { get; set; }
        public string webpage_url_basename { get; set; }
        public int? abr { get; set; }
        public string release_year { get; set; }
        public dynamic automatic_captions { get; set; }
        public string episode_number { get; set; }
        public string channel_id { get; set; }
        public string resolution { get; set; }
        public int? fps { get; set; }
        public string uploader { get; set; }
        public string start_time { get; set; }
        public int? duration { get; set; }
        public List<string> categories { get; set; }
        public string is_live { get; set; }
        public string playlist { get; set; }
    }
}

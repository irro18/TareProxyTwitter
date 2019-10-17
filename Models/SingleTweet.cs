using System;
using System.Collections.Generic;
using System.Text;
using Tweetinvi.Models;

namespace TareaProxy1.Models
{
    public class SingleTweet
    {
        public string FullText;
        public string URL;
        public int? ReplyCount;
        public DateTime CreatedAt;
        public Language? Langu;

        public SingleTweet(string FullT, string Url, int? ReplyC, DateTime Created, Language? Lang)
        {   
            FullText = FullT;
            URL = Url;
            ReplyCount = ReplyC;
            CreatedAt = Created;
            Langu = Lang;
        }
          
    }
}

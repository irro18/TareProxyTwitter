using System;
using System.Collections.Generic;
using System.Text;
using TareaProxy1.Models;
using Tweetinvi;

//implementar IProxy
namespace TareaProxy1.Services
{
   
    public class Proxy : IProxy
    {

        private string APIKey = "tWBlnSW6kPIR6t6nFOH3WICHm";
        private string APISecretKey = "bjuScXt9rR9iiC4Dpl7d3vE7aLDqfCH5dUYhgtLEBFYE1kzLKN";
        private string AccesToken = "809224938183938048-rWg4r0jBiW2CbCQQA1amPJGgGt2DKpn";
        private string AccesTokenSecret = "PsnflOEC4vDPKMKlK6pyDnA9mDkEzVKuQvieVgcifDTqN";

        public SingleTweet[] timeline = new SingleTweet[10];

        public Proxy()
        {
            Auth.SetUserCredentials(APIKey, APISecretKey, AccesToken, AccesTokenSecret);
        }

        public SingleTweet[] timeline10()
        {
            var tenTweets = Timeline.GetHomeTimeline(10);

            int n = 0;
            foreach (var t in tenTweets)
            {
           
                timeline[n] = new SingleTweet(t.FullText, t.Url, t.ReplyCount,  t.CreatedAt, t.Language);
                n++;
            }
            return timeline;
        }
    }
}

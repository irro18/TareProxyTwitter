using System;
using TareaProxy1.Models;
using TareaProxy1.Services;

namespace TareaProxy1
{
    class Program
    {
        static void Main(string[] args)
        {
            IProxy Proxy = new Proxy();
            SingleTweet[] aux = Proxy.timeline10();

            for(int i = 0; i < 10; i++)
            {
                int? a;
                if (aux[i].ReplyCount != null)
                    a = aux[i].ReplyCount;
                else
                    a = 0;
                string str = a.ToString();
                //int? a = aux[i].ReplyCount;
                //string str = "0";
                //if (a.HasValue)
                //{
                //    str = a.Value.ToString();
                //}
                
                Console.WriteLine("\nTweet:" + aux[i].FullText + "\nURL:" + aux[i].URL + "\nCreated At:" + aux[i].CreatedAt.ToString() + "\nReply Count:" + str + "\nLanguage:" + aux[i].Langu.ToString());
            }
        }
    }
}


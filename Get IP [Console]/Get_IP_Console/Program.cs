using System;
using System.Net;

namespace Get_IP_Console
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                var htmlCode = client.DownloadString("https://www.myexternalip.com/raw");
                Console.WriteLine(htmlCode);
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace Xttp
{
    class Example
    {

        public static void Main()
        {
            var client = new Xttp();
            var request = new Request("http://api.lsong.org/ip/all");
            Response response = client.Send(request).Result;
            Console.WriteLine(response.ToString());
            Console.ReadLine();
        }
    }
}

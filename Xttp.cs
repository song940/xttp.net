using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Xttp
{
    /// <summary>
    /// Xttp Client, send data to your web server
    /// </summary>
    public class Xttp
    {
        HttpClient client;

        /// <summary>
        /// Xttp
        /// </summary>
        public Xttp()
        {
            client = new HttpClient();
        }

        /// <summary>
        /// Async Send HTTP Request 
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>response</returns>
        public async Task<Response> Send(Request request)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            switch (request.Method)
            {
                case Request.METHOD.GET:
                    response = await client.GetAsync(request.Url.ToString());
                    break;
                case Request.METHOD.POST:
                    var body = new FormUrlEncodedContent(request.Body);
                    response = await client.PostAsync(request.Url.ToString(), body);
                    break;
            }
            return new Response(response);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Xttp
{
    public class Request
    {
        public enum METHOD
        {
           GET, POST, DELETE, UPDATE
        }

        public UriBuilder Url;
        public METHOD Method;
        public IDictionary<string, string> Body;
        public IDictionary<string, string> Headers;

        public Request(string url)
        {
            this.Url = new UriBuilder(url);
            this.Method = METHOD.GET;
            this.Body = new Dictionary<string, string>();
            this.Headers = new Dictionary<string, string>();
        }

        public void SetHeader(string key, string value)
        {
            this.Headers[key] = value;
        }

        public void SetQuery(string key, string value)
        {
            var qs = HttpUtility.ParseQueryString(this.Url.Query);
            qs.Set(key, value);
            this.Url.Query = qs.ToString();
        }

    }
}
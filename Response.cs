using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Xttp
{
    /// <summary>
    /// Response
    /// </summary>
    public class Response
    {
        private HttpResponseMessage response;
        /// <summary>
        /// Response
        /// </summary>
        /// <param name="response">HttpResponseMessage</param>
        public Response(HttpResponseMessage response)
        {
            this.response = response;
        }

        public HttpResponseHeaders Headers
        {
            get
            {
                return response.Headers;
            }
        }
        /// <summary>
        /// Response Status Code
        /// </summary>
        public int Status
        {
            get
            {
                return (int)response.StatusCode;
            }
        }

        /// <summary>
        /// Response Body
        /// </summary>
        public string Text
        {
            get
            {
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
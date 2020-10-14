using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUS.HTTP
{
    public class HttpRequest
    {
        public HttpRequest(string requestString)
        {
            this.Headers = new List<Header>();
            this.Cookies = new List<Cookie>();
            
            var lines = requestString.Split(new string[] { HttpConstants.NewLine }, StringSplitOptions.None);
            var headerLine = lines[0];
            var heaaderLineParts = headerLine.Split(' ');

            this.Method = (HttpMethod)Enum.Parse(typeof(HttpMethod), heaaderLineParts[0], true);
            this.Path = heaaderLineParts[1];

            int lineIndex = 1;
            bool isInHeaders = true;
            StringBuilder sb = new StringBuilder();

            while (lineIndex < lines.Length)
            {
                var line = lines[lineIndex];
                lineIndex++;

                if (string.IsNullOrEmpty(line))
                {
                    isInHeaders = false;
                    continue;
                }

                if (isInHeaders)
                {
                    var header = new Header(line);
                    this.Headers.Add(header);
                }
                else
                {
                    sb.AppendLine(line);
                }
            }

            if (this.Headers.Any(x => x.Name == HttpConstants.RequestCookieHeader))
            {
                string cookieAsString = this.Headers.FirstOrDefault(x => x.Name == HttpConstants.RequestCookieHeader).Value;

                var cookies = cookieAsString.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var cookie in cookies)
                {
                    Cookie currentCookie = new Cookie(cookie);
                    this.Cookies.Add(currentCookie);
                }
            }

            this.Body = sb.ToString();
        }

        public string Path { get; set; }

        public HttpMethod Method { get; set; }

        public string Body { get; set; }

        public ICollection<Header> Headers { get; set; }

        public ICollection<Cookie> Cookies { get; set; }

        public string RequestBody { get; set; }
    }
}

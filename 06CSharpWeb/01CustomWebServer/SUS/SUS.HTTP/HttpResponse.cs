﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.HTTP
{
    public class HttpResponse
    {
        public HttpResponse(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
            this.Headers = new List<Header>();
            this.Cookies = new List<Cookie>();
        }

        public HttpResponse(string contentType, byte[] body, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            if (body == null)
            {
                //throw new ArgumentNullException(nameof(body));
                body = new byte[0];
            }

            this.StatusCode = statusCode;
            this.Body = body;
            this.Headers = new List<Header>
            {
                new Header("Content-Type", contentType),
                new Header("Content-Length", body.Length.ToString()),
                new Header("Server" , "SUS Server 1.0")
            };

            this.Cookies = new List<Cookie>();
        }

        public HttpStatusCode StatusCode { get; set; }

        public ICollection<Header> Headers { get; set; }

        public ICollection<Cookie> Cookies { get; set; }

        public byte[] Body { get; set; }

        //public string Version { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}" + HttpConstants.NewLine);
            foreach (var header in this.Headers)
            {
                sb.Append(header.ToString() + HttpConstants.NewLine);
            }

            foreach (var cookie in this.Cookies)
            {
                sb.Append($"Set-Cookie: {cookie.ToString()}" + HttpConstants.NewLine);
            }

            sb.Append(HttpConstants.NewLine);

            return sb.ToString();
        }
    }
}
﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickPay.Common.Requests
{
    /// <summary>模拟请求响应结果
    /// </summary>
    public class Response
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Encode { get; set; } = "utf-8";
        public IEnumerable<string> Cookies { get; set; }

        public string CookieString
        {
            get
            {
                if (Cookies == null) return "";
                return Cookies.Any() ? string.Join(";", Cookies) : "";
            }
        }
        public string ContentType { get; set; }
        public string Server { get; set; }
        public byte[] ResponseData { get; set; }
        public string ExceptionMessage { get; set; }

        /// <summary>获取String返回结果
        /// </summary>
        public string GetResponseString()
        {
            return ResponseData == null ? "" : Encoding.GetEncoding(Encode).GetString(ResponseData);
        }

        public override string ToString()
        {
            return $"[Success:{Success}],[StatusCode:{StatusCode}],[Content-Type:{ContentType}],[Server:{Server}]";
        }
    }
}

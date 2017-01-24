﻿namespace QuickPay.Common.Requests
{
    public class RequestConsts
    {
        /// <summary>长连接
        /// </summary>
        public const string KeepAlive = "Keep-alive";
        /// <summary>UserAgent
        /// </summary>
        public const string UserAgent = "User-Agent";
        /// <summary>请求时的Cookie
        /// </summary>
        public const string RequestCookie = "Cookie";
        /// <summary>返回的Cookie
        /// </summary>
        public const string ResponseCookie = "Set-Cookie";
        /// <summary>ContentType
        /// </summary>
        public const string ContentType = "Content-Type";
        /// <summary>Server
        /// </summary>
        public const string Server = "Server";

        /// <summary>
        /// </summary>
        public class AuthenticationSchema
        {
            /// <summary>基础认证
            /// </summary>
            public const string Basic = "basic";

            /// <summary>摘要
            /// </summary>
            public const string Digest = "digest";

            /// <summary>NTLM认证
            /// </summary>
            public const string Ntlm = "ntlm";
            /// <summary>Bearer
            /// </summary>
            public const string Bearer = "bearer";
        }

        public class ContentTypes
        {
            public const string ImageJpeg = "image/jpeg";
        }
    }
}

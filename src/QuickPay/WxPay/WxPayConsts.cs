﻿namespace QuickPay.WxPay
{
    public class WxPayConsts
    {
        /// <summary>微信支付常量
        /// </summary>
        public const string DefaultConfig = "Default";

        /// <summary>
        /// </summary>
        public const string WechatRedirect = "#wechat_redirect";

        /// <summary>Jsapi下单时候,生成的PrepayId名称
        /// </summary>
        public const string PrepayId = "prepay_id";

        /// <summary>认证范围
        /// </summary>
        public class Scope
        {
            public const string Base = "snsapi_base";
            public const string UserInfo = "snsapi_userinfo";
        }

        /// <summary>签名字段
        /// </summary>
        public class SignField
        {
            public const string Sign = "sign";
            public const string PaySign = "paySign";
        }

        /// <summary>交易类型
        /// </summary>
        public class TradeType
        {
            /// <summary>公众号支付
            /// </summary>
            public const string JsApi = "JSAPI";

            /// <summary>Native
            /// </summary>
            public const string Native = "NATIVE";

            /// <summary>App支付
            /// </summary>
            public const string App = "APP";
        }

        public class SignType
        {
            public const string Md5 = "MD5";
        }

        public class ReturnCode
        {
            public const string Success = "SUCCESS";
            public const string Fail = "FAIL";
        }

        public class ResultCode
        {
            public const string Success = "SUCCESS";
            public const string Fail = "FAIL";
        }

        /// <summary>货币类型
        /// </summary>
        public class FeeType
        {
            /// <summary>人民币
            /// </summary>
            public const string Cny = "CNY";
        }

        public class RefundAccount
        {
            /// <summary>未结算资金退款（默认使用未结算资金退款）
            /// </summary>
            public const string Unsettled = "REFUND_SOURCE_UNSETTLED_FUNDS";

            /// <summary>可用余额退款
            /// </summary>
            public const string Recharge = "REFUND_SOURCE_RECHARGE_FUNDS";
        }

        /// <summary>账单类型
        /// </summary>
        public class BillType
        {
            /// <summary>返回当日所有订单信息，默认值
            /// </summary>
            public const string All = "ALL";

            /// <summary>返回当日成功支付的订单
            /// </summary>
            public const string Success = "SUCCESS";

            /// <summary>返回当日退款订单
            /// </summary>
            public const string Refund = "REFUND";
        }

        /// <summary>压缩类型
        /// </summary>
        public class TarType
        {
            public const string Gzip = "GZIP";
        }
    }
}

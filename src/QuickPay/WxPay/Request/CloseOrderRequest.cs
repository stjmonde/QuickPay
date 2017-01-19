﻿using QuickPay.WxPay.Response;

namespace QuickPay.WxPay.Request
{
    public class CloseOrderRequest : BaseRequest<CloseOrderResponse>
    {
        /// <summary>关闭订单地址
        /// </summary>
        public override string Url { get; } = "https://api.mch.weixin.qq.com/pay/closeorder";

        /// <summary>商户系统内部的订单号
        /// </summary>
        [WxPayDataElement("out_trade_no")]
        public string OutTradeNo { get; set; }

    }
}
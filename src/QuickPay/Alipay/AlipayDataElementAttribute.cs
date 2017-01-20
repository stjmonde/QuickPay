﻿using System;

namespace QuickPay.Alipay
{
    /// <summary>支付宝属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class AlipayDataElementAttribute : Attribute
    {
        /// <summary>是否为必须的参数
        /// </summary>
        public bool IsRequired { get; private set; }

        /// <summary>实际的参数名称
        /// </summary>
        public string Name { get; private set; }

        public AlipayDataElementAttribute(string name, bool isRequired = true)
        {
            Name = name;
            IsRequired = isRequired;
        }
    }
}
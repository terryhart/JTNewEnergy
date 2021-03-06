﻿using JTNE.Protocol.Attributes;
using JTNE.Protocol.Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.MessageBody
{
    /// <summary>
    ///  公共平台域名长度N
    /// </summary>
    [JTNEFormatter(typeof(JTNE_0x81_0x0D_Device_Formatter))]
    public class JTNE_0x81_0x0D_Device: JTNE_0x81_Body_Device
    {
        public override byte ParamId { get; set; } = 0x0D;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 1;
        /// <summary>
        ///公共平台域名长度N
        /// </summary>
        public byte ParamValue { get; set; }
    }
}

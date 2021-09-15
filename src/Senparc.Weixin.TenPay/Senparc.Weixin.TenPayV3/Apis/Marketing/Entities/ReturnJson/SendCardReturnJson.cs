﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2021 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2021 Senparc
  
    文件名：SendCardReturnJson.cs
    文件功能描述：发放消费卡返回Json类
    
    
    创建标识：Senparc - 20210915
    
----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senparc.Weixin.TenPayV3.Apis.Entities;

namespace Senparc.Weixin.TenPayV3.Apis.Marketing
{
    /// <summary>
    /// 发放消费卡返回Json类
    /// <para>详细请参考微信支付官方文档 https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_6_1.shtml </para>
    /// </summary>
    public class SendCardReturnJson
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="card_code">消费卡code  <para>发卡成功后，每个用户在每个card_id下会分配一个唯一code。</para><para>示例值：198555211279</para></param>
        public SendCardReturnJson(string card_code)
        {
            this.card_code = card_code;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public SendCardReturnJson()
        {
        }

        /// <summary>
        /// 消费卡code 
        /// <para>发卡成功后，每个用户在每个card_id下会分配一个唯一code。 </para>
        /// <para>示例值：198555211279 </para>
        /// </summary>
        public string card_code { get; set; }

    }
}



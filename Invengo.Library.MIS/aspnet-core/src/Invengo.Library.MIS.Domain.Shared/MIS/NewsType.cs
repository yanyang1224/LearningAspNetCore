using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Invengo.Library.MIS.MIS
{
    public enum NewsType : byte
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0,

        /// <summary>
        /// 新闻
        /// </summary>
        [Description("新闻")]
        News = 1,

        /// <summary>
        /// 公告
        /// </summary>
        [Description("公告")]
        Notice = 2,
    }
}

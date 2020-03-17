using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Invengo.Library.MIS.MIS
{
    public enum AttachmentApplyType : byte
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0,

        /// <summary>
        /// 图片
        /// </summary>
        [Description("图片")]
        Picture = 1,

        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 2,

        /// <summary>
        /// Logo
        /// </summary>
        [Description("Logo")]
        Logo = 3
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Invengo.Library.MIS.MIS
{
    public enum Status : byte
    {
        [Description("草稿")]
        Draft = 0,

        [Description("发布")]
        Release = 1,
    }
}

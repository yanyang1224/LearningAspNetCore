using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class TenantConfigDto : FullAuditedEntityDto<Guid>
    {
        /// <summary>
        /// 图书馆名称
        /// </summary>
        public virtual string LibraryName { get; set; }

        /// <summary>
        /// logo附件
        /// </summary>
        public virtual Guid? Logo { get; set; }

        /// <summary>
        /// 开放时间
        /// </summary>
        public virtual string OpenTime { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        public virtual string City { get; set; }

        /// <summary>
        /// 所在地址
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        /// 所用模板Id
        /// </summary>
        public virtual Guid TemplateId { get; set; }

    }
}

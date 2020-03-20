using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class MediaInfoDto : FullAuditedEntityDto<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public virtual MediaType MediaType { get; set; }

        /// <summary>
        /// 排序代码
        /// </summary>
        public virtual int SortCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }

        public virtual Guid? TenantId { get; set; }
    }
}

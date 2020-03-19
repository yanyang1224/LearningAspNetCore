using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Invengo.Library.MIS.MIS
{
    [Table("MisAttachment")]
    public class Attachment : FullAuditedEntity<Guid>, IMultiTenant
    {
        #region 实体

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(256)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 字节数
        /// </summary>
        public virtual long Length { get; set; }

        /// <summary>
        /// 后缀名
        /// </summary>
        [StringLength(64)]
        public virtual string Extension { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        public virtual AttachmentApplyType AttachmentApplyType { get; set; }

        /// <summary>
        /// 排序代码
        /// </summary>
        public virtual int SortCode { get; set; }

        /// <summary>
        /// 附加状态
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(256)]
        public virtual string Remark { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        public virtual Guid? TenantId { get; set; }

        #endregion

        protected Attachment()
        {

        }

        public Attachment(Guid id)
            : base(id)
        {

        }

    }
}

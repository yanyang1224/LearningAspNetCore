using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Invengo.Library.MIS.MIS
{
    [Table("MisTemplate")]
    public class Template : FullAuditedEntity<Guid>, IMultiTenant
    {
        #region 实体
        /// <summary>
        /// 模板名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 缩略图附件id
        /// </summary>
        public virtual Guid Thumbnail { get; set; }

        [ForeignKey("Thumbnail")]
        public virtual Attachment Attachment { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [StringLength(256)]
        public virtual string Description { get; set; }

        /// <summary>
        /// 模板配置,字段格式例：{LeftTop:{Data:1,Shape:1,Cycle:2}}
        /// </summary>
        public virtual string Config { get; set; }

        /// <summary>
        /// 根模板id，以此解析config字段的json
        /// </summary>
        public virtual Guid? RootId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(256)]
        public virtual string Remark { get; set; }

        public virtual Guid? TenantId { get; set; }
        #endregion

        protected Template()
        {

        }

        public Template(Guid id)
            : base(id)
        {

        }
    }
}

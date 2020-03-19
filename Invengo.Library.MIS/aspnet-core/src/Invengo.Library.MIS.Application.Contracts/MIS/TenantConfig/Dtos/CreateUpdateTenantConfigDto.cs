using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class CreateUpdateTenantConfigDto : EntityDto<Guid>
    {
        /// <summary>
        /// 图书馆名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public virtual string LibraryName { get; set; }

        /// <summary>
        /// logo附件
        /// </summary>
        public virtual Guid? Logo { get; set; }

        /// <summary>
        /// 开放时间
        /// </summary>
        [StringLength(256)]
        public virtual string OpenTime { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        [StringLength(32)]
        public virtual string City { get; set; }

        /// <summary>
        /// 所在地址
        /// </summary>
        [StringLength(256)]
        public virtual string Address { get; set; }

        /// <summary>
        /// 所用模板Id
        /// </summary>
        public virtual Guid TemplateId { get; set; }

    }
}

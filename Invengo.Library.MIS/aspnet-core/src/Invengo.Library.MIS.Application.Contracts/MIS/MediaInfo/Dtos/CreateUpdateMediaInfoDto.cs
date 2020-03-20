using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class CreateUpdateMediaInfoDto : EntityDto<Guid>
    {

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(256)]
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
        [StringLength(256)]
        public virtual string Description { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(256)]
        public virtual string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class CreateUpdateActivityDto : EntityDto<Guid>
    {

        /// <summary>
        /// 活动主题
        /// </summary>
        [Required]
        [StringLength(128)]
        public virtual string Subject { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// 活动地点
        /// </summary>
        [Required]
        [StringLength(128)]
        public virtual string Address { get; set; }

        /// <summary>
        /// 活动人群
        /// </summary>
        [Required]
        [StringLength(128)]
        public virtual string Crowd { get; set; }

        /// <summary>
        /// 排序代码
        /// </summary>
        public virtual int SortCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [Required]
        [StringLength(256)]
        public virtual string Description { get; set; }

        /// <summary>
        /// 主办单位
        /// </summary>
        [StringLength(64)]
        public virtual string Sponsor { get; set; }

        /// <summary>
        /// 承办单位
        /// </summary>
        [StringLength(64)]
        public virtual string Organizer { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(256)]
        public virtual string Remark { get; set; }
    }
}

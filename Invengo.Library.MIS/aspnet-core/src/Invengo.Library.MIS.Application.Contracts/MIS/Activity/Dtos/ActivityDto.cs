using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class ActivityDto : FullAuditedEntityDto<Guid>
    {

        /// <summary>
        /// 活动主题
        /// </summary>
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
        public virtual string Address { get; set; }

        /// <summary>
        /// 活动人群
        /// </summary>
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
        public virtual string Description { get; set; }

        /// <summary>
        /// 主办单位
        /// </summary>
        public virtual string Sponsor { get; set; }

        /// <summary>
        /// 承办单位
        /// </summary>
        public virtual string Organizer { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }
    }
}

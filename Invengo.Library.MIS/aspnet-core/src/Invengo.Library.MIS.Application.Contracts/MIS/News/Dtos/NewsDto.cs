using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class NewsDto : FullAuditedEntityDto<Guid>
    {
        public virtual NewsType Type { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public virtual string Author { get; set; }

        /// <summary>
        /// 编辑
        /// </summary>
        public virtual string Editor { get; set; }

        /// <summary>
        /// 主题词
        /// </summary>
        public virtual string Tags { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        public virtual string SourcesName { get; set; }

        /// <summary>
        /// 来源地址
        /// </summary>
        public virtual string SourcesAddress { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public virtual DateTime ReleaseTime { get; set; }

        /// <summary>
        /// 排序代码
        /// </summary>
        public virtual int SortCode { get; set; }

        /// <summary>
        /// 新闻状态
        /// </summary>
        public virtual Status Status { get; set; }

        ///// <summary>
        ///// 导航图片
        ///// </summary>
        //[StringLength(128)]
        //public virtual string NavPic { get; set; }

        /// <summary>
        /// 新闻内容
        /// </summary>
        public virtual string Content { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark { get; set; }

        public virtual Guid? TenantId { get; set; }
    }
}

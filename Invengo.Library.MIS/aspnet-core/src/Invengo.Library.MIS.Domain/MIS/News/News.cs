﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Invengo.Library.MIS.MIS
{
    [Table("MisNews")]
    public class News : FullAuditedEntity<Guid>, IMultiTenant
    {
        #region 实体
        /// <summary>
        /// 新闻类型
        /// </summary>
        public virtual NewsType Type { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        [StringLength(256)]
        public virtual string Title { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [StringLength(64)]
        public virtual string Author { get; set; }

        /// <summary>
        /// 编辑
        /// </summary>
        [Required]
        [StringLength(64)]
        public virtual string Editor { get; set; }

        /// <summary>
        /// 主题词
        /// </summary>
        [StringLength(128)]
        public virtual string Tags { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [StringLength(256)]
        public virtual string Description { get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        [StringLength(64)]
        public virtual string SourcesName { get; set; }

        /// <summary>
        /// 来源地址
        /// </summary>
        [StringLength(128)]
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
        [Required]
        public virtual string Content { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(256)]
        public virtual string Remark { get; set; }

        public virtual Guid? TenantId { get; set; }
        #endregion

        protected News()
        {

        }

        public News(Guid id)
            : base(id)
        {

        }

    }
}

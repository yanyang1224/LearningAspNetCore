﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.MIS.MIS
{
    public class CreateUpdateAttachmentDto : EntityDto<Guid>
    {
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
        [Required]
        [StringLength(64)]
        public virtual string Extension { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        public virtual AttachmentApplyType AttachmentApplyType { get; set; }
    }
}

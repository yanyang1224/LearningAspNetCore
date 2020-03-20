using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Invengo.Library.MIS.MIS
{
    public class AttachmentAppService :
        CrudAppService<
            Attachment,
            AttachmentDto, // Used to show
            Guid, // Primary key
            PagedAndSortedResultRequestDto, // Used for paging/sorting on getting a list of attachment
            CreateUpdateAttachmentDto, // Used to create
            CreateUpdateAttachmentDto> // Used to update
        , IAttachmentAppService
    {
        private IRepository<Attachment, Guid> _attachmentRepository;
        private readonly IConfiguration _config;

        public AttachmentAppService(
            IRepository<Attachment, Guid> attachmentRepository,
            IConfiguration config)
            : base(attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
            _config = config;
        }

        #region 获取数据

        /// <summary>
        /// 返回文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FileContentResult> GetFileAsync(Guid id)
        {
            var attachment = await _attachmentRepository.GetAsync(id);
            if(attachment == null)
            {
                throw new UserFriendlyException("未找到附件信息");
            }
            var path = _config["AttachmentPath"] + attachment.AttachmentApplyType + "/" + attachment.Name;
            if(!new FileInfo(path).Exists)
            {
                throw new UserFriendlyException("文件已丢失");
            }
            var file = new FileContentResult(File.ReadAllBytes(path), attachment.Extension)
            {
                FileDownloadName = attachment.Name
            };
            return file;

        }

        /// <summary>
        /// 返回文件流
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FileStream> GetStreamAsync(Guid id)
        {
            var attachment = await _attachmentRepository.GetAsync(id);
            if (attachment == null)
            {
                throw new UserFriendlyException("未找到附件信息");
            }
            var path = _config["AttachmentPath"] + attachment.AttachmentApplyType + "/" + attachment.Name;
            if (!new FileInfo(path).Exists)
            {
                throw new UserFriendlyException("文件已丢失");
            }
            return File.OpenRead(path);
        }

        #endregion


        #region 提交数据

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AttachmentDto> UploadFile([FromForm]UploadFileInput input)
        {
            CheckContentType(input);

            var attachment = new Attachment(GuidGenerator.Create())
            {
                Name = input.File.FileName,
                Length = input.File.Length,
                Extension = input.File.ContentType,
                AttachmentApplyType = input.AttachmentApplyType
            };

            var dir = _config["AttachmentPath"] + input.AttachmentApplyType + "/";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            using (FileStream fileStream = System.IO.File.Create(dir + input.File.FileName))
            {
                await input.File.CopyToAsync(fileStream);
                fileStream.Flush();
            }

            var result = await _attachmentRepository.InsertAsync(attachment);
            return ObjectMapper.Map<Attachment,AttachmentDto>(result);
        }

        /// <summary>
        /// 检查类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected void CheckContentType(UploadFileInput input)
        {
            switch (input.AttachmentApplyType)
            {
                case AttachmentApplyType.Picture:
                case AttachmentApplyType.Logo:
                    if (!input.File.ContentType.StartsWith("image", StringComparison.CurrentCultureIgnoreCase))
                    {
                        throw new UserFriendlyException("仅支持上传JPG、JPEG、PNG等图片文件");
                    }
                    break;
                case AttachmentApplyType.Video:
                    if (!input.File.ContentType.StartsWith("video", StringComparison.CurrentCultureIgnoreCase))
                    {
                        throw new UserFriendlyException("仅支持上传avi、wma、MP4等图片文件");
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

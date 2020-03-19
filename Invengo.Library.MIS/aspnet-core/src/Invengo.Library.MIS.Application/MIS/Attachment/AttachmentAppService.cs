using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
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

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<Guid> UploadPicture([Required]IFormFile file)
        {
            if (!file.ContentType.StartsWith("image", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new UserFriendlyException("仅支持上传JPG、JPEG、PNG等图片文件");
            }
            return await UploadFile(new UploadFileInput() { 
                File=file,
                AttachmentApplyType=AttachmentApplyType.Picture
            });
        }

        /// <summary>
        /// 上传视频
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<Guid> UploadVideo([Required]IFormFile file)
        {
            if (!file.ContentType.StartsWith("video", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new UserFriendlyException("仅支持上传avi、wma、MP4等图片文件");
            }
            return await UploadFile(new UploadFileInput()
            {
                File = file,
                AttachmentApplyType = AttachmentApplyType.Video
            });
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<Guid> UploadFile([FromForm]UploadFileInput input)
        {
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
            return result.Id;
        }

    }
}

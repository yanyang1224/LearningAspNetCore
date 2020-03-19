using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Invengo.Library.MIS.MIS
{
    public class UploadFileInput
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public AttachmentApplyType AttachmentApplyType { get; set; }
    }
}

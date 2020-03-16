using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Invengo.Library.ResourceService
{
    public class DoubanBookDto : EntityDto<Guid>
    {
        public string Title { get; set; }

        public string ISBN10 { get; set; }

        public string ISBN13 { get; set; }
    }
}

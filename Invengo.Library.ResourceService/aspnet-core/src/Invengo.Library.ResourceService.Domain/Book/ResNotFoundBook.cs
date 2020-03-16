using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Invengo.Library.ResourceService
{
    public class ResNotFoundBook : Entity<Guid>
    {
        public string ISBN { get; set; }

        public bool IsCrawl { get; set; }
    }
}

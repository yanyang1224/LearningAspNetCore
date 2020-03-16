using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Invengo.Library.ResourceService
{
    public class CreateUpdateDoubanBookDto
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }


        public string ISBN10 { get; set; }

        public string ISBN13 { get; set; }
    }
}

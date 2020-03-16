using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Invengo.Library.ResourceService
{
    public class DoubanBook : AggregateRoot<Guid>
    {
        public object Rating { get; set; }

        public string Subtitle { get; set; }

        public List<string> Author { get; set; }

        public string Pubdate { get; set; }

        public List<string> Tags { get; set; }

        public string OriginTitle { get; set; }

        public string Image { get; set; }

        public string Binding { get; set; }

        public List<string> Translator { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string ISBN10 { get; set; }

        public string ISBN13 { get; set; }
    }
}

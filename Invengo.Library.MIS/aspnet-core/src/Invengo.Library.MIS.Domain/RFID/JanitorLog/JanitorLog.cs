using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("JanitorLog")]
    public class JanitorLog : Entity<int>
    {
        [Column("nJanitorLogID")]
        public override int Id { get; protected set; }

        public DateTime? dtLogTime { get; set; }

        public string szJanitorName { get; set; }

        public long? lEPCOrder { get; set; }

        public string szBookID { get; set; }

        public string szBookName { get; set; }

        public string szBookIndex { get; set; }

        public int? nBookStatus { get; set; }
    }
}

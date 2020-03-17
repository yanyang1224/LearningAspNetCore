using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("VerifyIdentity")]
    public class VerifyIdentity : Entity<int>
    {
        [Column("nID")]
        public override int Id { get; protected set; }

        public string VerifyIdentityName { get; set; }

        public DateTime? dtRecordTime { get; set; }

        public short? CardType { get; set; }

        public string CardNumber { get; set; }

        public string ReaderName { get; set; }
    }
}

﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("ReaderINOUTLog")]
    public class ReaderINOUTLog : Entity<int>
    {
        [Column("nID")]
        public override int Id { get; protected set; }

        public DateTime? dtRecordTime { get; set; }

        public short? nType { get; set; }

        public int nCounter { get; set; }

        public string szJanitorName { get; set; }

        public string szReaderID { get; set; }
    }
}

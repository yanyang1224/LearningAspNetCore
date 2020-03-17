using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("CardType")]
    public class CardType : Entity<int>
    {
        [Column("nCardTypeID")]
        public override int Id { get; protected set; }

        public string szCardType { get; set; }

        public int? nLevel { get; set; }

        public int? nStaffID { get; set; }

        public string szStaffName { get; set; }

        public DateTime? dtAddDate { get; set; }

        public double? fDeposit { get; set; }

        public int? ValidDay { get; set; }

        public string szILSTypeCode { get; set; }

        public string beginTime { get; set; }

        public string endTime { get; set; }
    }
}

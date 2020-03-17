using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("Reader")]
    public class Reader : Entity<string>
    {
        [Column("szReaderID")]
        public override string Id { get; protected set; }

        public string nCardID { get; set; }

        public long? nEPCOrder { get; set; }

        public string szName { get; set; }

        public bool? bSex { get; set; }

        public DateTime? dtBirthday { get; set; }

        public string szCompany { get; set; }

        public string szAddress { get; set; }

        public string szTelephone { get; set; }

        public DateTime? dtRegisterDate { get; set; }

        public decimal? fDeposit { get; set; }

        public decimal? fBalance { get; set; }

        public string szCardPswd { get; set; }

        public int? nLibraryNo { get; set; }

        public string szidentityCard { get; set; }

        public DateTime? dtlapse { get; set; }

        public int? nConvertStaffID { get; set; }

        public DateTime? dtConvertDate { get; set; }

        public byte[] imgPic { get; set; }

        public string szFinger { get; set; }

        public int? nCardTypeID { get; set; }

        public int? nCardStatusID { get; set; }

        public string szEmail { get; set; }

        public string szMobile { get; set; }

        public short? nCardOrder { get; set; }

        public string szRemark { get; set; }

        public decimal? fOwe { get; set; }

        public string szMajorName { get; set; }

        public string szEduLevel { get; set; }

        public string szMajorNameSub { get; set; }

        public string szProRanks { get; set; }
    }
}

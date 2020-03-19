using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("CRD_TRANS_Recd")]
    public class CRD_TRANS_Recd : Entity<int>
    {
        #region 实体
        [Column("nID")]
        public override int Id { get; protected set; }

        public string szIdentifyCard { get; set; }

        public string szReaderID { get; set; }

        public string szName { get; set; }

        public string nCardID { get; set; }

        public int? nCardTypeID { get; set; }

        public decimal? fDeposit { get; set; }

        public string szOperateDesc { get; set; }

        public string szRemark { get; set; }

        public DateTime? dtTransDate { get; set; }

        public bool? bError { get; set; }

        public bool? bAddReaderRsult { get; set; }

        public DateTime? dtTransBegin { get; set; }

        public decimal? fNeedDeposit { get; set; }

        public bool? bSendCard { get; set; }

        public DateTime? dtSendCard { get; set; }

        public bool? bReBackCard { get; set; }

        public string szCardDevice { get; set; }

        public string szStep { get; set; }

        public string szDeviceName { get; set; }

        public short nOperateType { get; set; }

        public bool bSettleAccounts { get; set; }

        public DateTime? dtSettleAccounts { get; set; }

        public string szStaffName { get; set; }

        public short nRecordStep { get; set; }
        #endregion

        protected CRD_TRANS_Recd()
        {

        }

        public CRD_TRANS_Recd(int id)
            : base(id)
        {

        }

    }
}

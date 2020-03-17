using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("BorrowHisIndex")]
    public class BorrowHisIndex : Entity<int>
    {
        [Column("nHisIndexID")]
        public override int Id { get; protected set; }

        public DateTime? dtOperateDate { get; set; }

        public int? nOperateType { get; set; }

        public string szIPAdd { get; set; }

        public string szMacAdd { get; set; }

        public string szMachineName { get; set; }

        public int? nStaffID { get; set; }

        public string szGlideID { get; set; }

        public int? nGlideIndex { get; set; }

        public int? nSucCount { get; set; }

        public int? nFailCount { get; set; }

        public string szReaderID { get; set; }

        public string szReaderName { get; set; }

        public string szReaderPwd { get; set; }

        public string szInterLendNO { get; set; }

        public string szInterLendLib { get; set; }
    }
}

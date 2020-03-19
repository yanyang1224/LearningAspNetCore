using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("BorrowHistory")]
    public class BorrowHistory : Entity<int>
    {
        #region 实体
        [Column("nHistoryID")]
        public override int Id { get; protected set; }
 
        public int? nHisIndexID { get; set; }

        public string szBookID { get; set; }

        public string szReaderID { get; set; }

        public bool? bResult { get; set; }

        public string szMemo { get; set; }

        public DateTime? dtNeedBack { get; set; }

        public string szBookIndex { get; set; }

        public bool bBooking { get; set; }

        public string szBookName { get; set; }

        public string szReaderName { get; set; }

        public int? nBooksTypeID { get; set; }

        public string szBooksType { get; set; }

        public string szLibCDByType { get; set; }

        public short? nHavePrint { get; set; }

        public string szCheckInfo { get; set; }

        public string szCardType { get; set; }
        #endregion

        protected BorrowHistory()
        {

        }

        public BorrowHistory(int id)
            : base(id)
        {

        }
    }
}

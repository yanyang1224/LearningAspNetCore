using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("BookInfo")]
    public class BookInfo : Entity<string>
    {
        #region 实体
        [Column("szBookID")]
        public override string Id { get; protected set; }

        public string nLabelID { get; set; }
         
        public long? nEPCOrder { get; set; }
    
        public string szBookCaseNo { get; set; }

        public int? nBooksTypeID { get; set; }

        public int? nPublishID { get; set; }

        public string szBookSSID { get; set; }

        public string szSeriesID { get; set; }

        public int? nBookStatus { get; set; }

        public string szCardID { get; set; }

        public DateTime? dtBorrowDate { get; set; }

        public DateTime? dtNeedBackDate { get; set; }

        public DateTime? dtLastRead { get; set; }

        public int? nStaffID { get; set; }

        public string szISBN { get; set; }

        public string szName { get; set; }

        public string szAuthor { get; set; }

        public decimal? fPrice { get; set; }

        public DateTime? dtPublishDate { get; set; }

        public int? nPages { get; set; }

        public string szBookIndex { get; set; }

        public string szMainWord { get; set; }

        public string szClassNO { get; set; }

        public string szlibCD { get; set; }

        public string szMemo { get; set; }

        public int? nStartYear { get; set; }

        public string szPublishyear { get; set; }

        public int? nConvertStaffID { get; set; }

        public DateTime? dtConvertDate { get; set; }

        public int? nUpdateStaffID { get; set; }

        public DateTime? dtUpdateDate { get; set; }

        public string szMoneyType { get; set; }

        public string szPretendIndexNum { get; set; }

        public bool? bForceSortCase { get; set; }

        public string szConvertStaff { get; set; }

        public DateTime? dtAutoUpdate { get; set; }

        public int? nRenewTime { get; set; }

        public int? nBookLenType { get; set; }

        public string szBookLen { get; set; }

        public int? nBookThickness { get; set; }

        public int? nSetInfoCount { get; set; }

        public int? nSetInfoOrder { get; set; }

        public string szTemplibCD { get; set; }

        public string szMedicalLib { get; set; }

        public bool? bBookLabelChecked { get; set; }

        public int? bLostBookFlag { get; set; }
        #endregion

        protected BookInfo()
        {

        }

        public BookInfo(string id)
            : base(id)
        {

        }
    }
}

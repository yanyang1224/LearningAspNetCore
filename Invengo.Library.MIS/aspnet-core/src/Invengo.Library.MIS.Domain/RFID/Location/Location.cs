using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("Location")]
    public class Location : Entity<int>
    {
        [Column("nID")]
        public override int Id { get; protected set; }

        public string szName { get; set; }

        public string szShortName { get; set; }

        public int nDefaultStatus { get; set; }

        public int? nStaffID { get; set; }

        public string szStaffName { get; set; }

        public DateTime? dtAddDate { get; set; }

        public bool? bForceSortCase { get; set; }

        public bool? bInitSortOver { get; set; }

        public string szMedicalLib { get; set; }
    }
}

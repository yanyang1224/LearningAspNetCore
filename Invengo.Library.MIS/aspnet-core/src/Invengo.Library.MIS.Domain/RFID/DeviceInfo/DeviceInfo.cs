using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("DeviceInfo")]
    public class DeviceInfo : Entity<int>
    {
        [Column("nDeviceID")]
        public override int Id { get; protected set; }

        public string szDeviceName { get; set; }

        public int? nTypeNo { get; set; }

        public string szIP { get; set; }

        public int nBuildingNo { get; set; }

        public int nFloorNo { get; set; }

        public int nRoomNo { get; set; }

        public int nXCoordinate { get; set; }

        public int nYCoordinate { get; set; }

        public int nVideoNum { get; set; }

        public int nVideoChannel1 { get; set; }

        public int nVideoChannel2 { get; set; }

        public int nVideoChannel3 { get; set; }

        public int nVideoChannel4 { get; set; }

        public bool bIsValid { get; set; }

        public DateTime? dtUpdateDate { get; set; }

        public int? nStaffID { get; set; }

        public int? nSubSystemID { get; set; }

        public bool? bAutoSaveVideo { get; set; }

        public string szDescription { get; set; }

        public bool? bCanPing { get; set; }
    }
}

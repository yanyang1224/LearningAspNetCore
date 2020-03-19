using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Invengo.Library.MIS.RFID
{
    [Table("duStaff")]
    public class duStaff : Entity<int>
    {
        #region 实体
        [Column("nStaffID")]
        public override int Id { get; protected set; }

        public string szName { get; set; }

        public string szUserName { get; set; }

        public string szPassword { get; set; }

        public bool? bIsValid { get; set; }

        public bool? bSex { get; set; }

        public string szTelephone { get; set; }

        public string szAddress { get; set; }

        public bool? bIsAdmin { get; set; }

        public int? nDeptID { get; set; }

        public string szFinger { get; set; }

        public string szMobile { get; set; }

        public string szEMail { get; set; }
        #endregion

        protected duStaff()
        {

        }

        public duStaff(int id)
            : base(id)
        {

        }
    }
}

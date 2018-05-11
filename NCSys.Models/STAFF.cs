using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class STAFF
    {
        [Key]
        public int PARTY_ROLE_ID { get; set; }//	参与人角色标识	NUMBER(9,0)
        [StringLength(15)]
        public string STAFF_CODE { get; set; }//	员工号	VARCHAR2(15)
        [StringLength(250)]
        public string STAFF_DESC { get; set; }//	员工描述	VARCHAR2(250)

        [ForeignKey("PARTY_ROLE_ID")]
        public PARTY_ROLE PARTY_ROLE { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class STAFF_PRIVILEGE
    {
        [Key]
        public int STAFF_PRIVILEGE_ID { get; set; }//	角色权限标识	NUMBER(9,0)
        public int PARTY_ROLE_ID { get; set; }//	参与人角色标识	NUMBER(9,0)
        public int REGION_ID { get; set; }//	区域标识	NUMBER(12,0)
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        public int PRIVILEGE_ID { get; set; }//	权限标识	NUMBER(9,0)
        public string REGION_TYPE { get; set; }//	区域类型	CHAR(3)
        public string PRIVILEGE_TYPE { get; set; }//	权限类型	CHAR(1)

        [ForeignKey("PARTY_ROLE_ID")]
        public PARTY_ROLE PARTY_ROLE { get; set; }

        [ForeignKey("PRIVILEGE_ID")]
        public PRIVILEGE PRIVILEGE { get; set; }

        [ForeignKey("REGION_ID")]
        public REGION REGION { get; set; }

    }
}

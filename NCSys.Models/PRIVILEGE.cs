using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class PRIVILEGE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRIVILEGE_ID { get; set; }//	权限标识	NUMBER(9,0)
        public int PARENT_PRG_ID { get; set; }//	上级权限标识	NUMBER(9,0)
        public string PRIVILEGE_NAME { get; set; }//	权限名称	VARCHAR2(50)
        public string PRIVILEGE_TYPE { get; set; }//	使用类型	VARCHAR2(3)
        public string PRIVILEGE_DESC { get; set; }//	权限描述	VARCHAR2(250)
        public string PRIVILEGE_CODE { get; set; }//	权限编码	VARCHAR2(6)
        public int PARTY_ROLE_ID { get; set; }//	参与人角色标识	NUMBER(9,0)

        [ForeignKey("PARTY_ROLE_ID")]
        public PARTY_ROLE PARTY_ROLE { get; set; }

        [ForeignKey("PARENT_PRG_ID")]
        public PRIVILEGE PARENT_PRG { get; set; }

    }
}

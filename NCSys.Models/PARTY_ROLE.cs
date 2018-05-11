using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class PARTY_ROLE
    {
        [Key]
        public int PARTY_ROLE_ID { get; set; }//	参与人角色标识	NUMBER(9,0)
        [StringLength(50)]
        public string PARTY_ROLE_NAME { get; set; }//	参与人角色名称	VARCHAR2(50)
        [StringLength(64)]
        public string PASSWORD { get; set; }//	登录密码	VARCHAR2(64)
        [StringLength(3)]
        public string PARTY_ROLE_TYPE { get; set; }//	参与人角色类型	VARCHAR2(3)
        [StringLength(1)]
        public string ORG_MANEGER { get; set; }//	组织管理者	VARCHAR2(1)
        public int PARTY_ID { get; set; }//	参与人标识	NUMBER(12,0)
        public int office_ID { get; set; }//	办公地点标识	NUMBER(9,0)
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        public char PWDVALIDTYPE { get; set; }//	密码有效期类型	CHAR(1)
        public DateTime update_time { get; set; }//	密码上次修改时间	DATE
        public DateTime incor_starttime { get; set; }//	输入错误密码时间	DATE
        public char login_status { get; set; }//	登录状态	CHAR(1)
        public int login_count { get; set; }//	登录次数	NUMBER(12,0)
        public int limit_count { get; set; }//	登录次数限制	NUMBER(12,0)
        [StringLength(10)]
        public string default_menu_code { get; set; }//	缺省登录菜单项	VARCHAR2(10)
        public char auto_audit_flag { get; set; }//	是否可以自动对帐	CHAR(1)
        public char party_role_property { get; set; }//	参与人角色特性	CHAR(1)
        public int machine_id { get; set; }//	机位标识	NUMBER(9,0)
        [StringLength(31)]
        public string contact_nbr { get; set; }//	联系电话	VARCHAR2(31)
        [StringLength(20)]
        public string third_party_role_id { get; set; }//	第三方系统的系统标识	VARCHAR2(20)
        [StringLength(20)]
        public string crm_staff_code { get; set; }//	crm_staff_code	VARCHAR2(20)
        [StringLength(10)]
        public string MENU_CODE { get; set; }//	MENU_CODE	CHAR(10)

        [ForeignKey("PARTY_ID")]
        public PARTY PARTY { get; set; }


    }
}
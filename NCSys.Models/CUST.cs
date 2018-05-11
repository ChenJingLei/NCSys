using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class CUST
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CUST_ID { get; set; } //	客户标识	NUMBER(12,0)

        [StringLength(250)]
        public string CUST_NAME { get; set; } //	客户名称	VARCHAR2(250)
        public Char TYPE_FLAG { get; set; } //	个客标识	CHAR(1)
        public int INDUSTRY_ID { get; set; } //	行业标识	NUMBER(9,0)
        public int CUST_LOCATION { get; set; } //	服务归属	NUMBER(9,0)
        public int PARENT_ID { get; set; } //	上级客户标识	NUMBER(12,0)
        [StringLength(20)]
        public string CUST_CODE { get; set; } //	客户统一编号	VARCHAR2(20)
        [StringLength(3)]
        public string STATE { get; set; } //	状态	VARCHAR2(3)
        public DateTime EFF_DATE { get; set; } //	生效时间	DATE
        public DateTime EXP_DATE { get; set; } //	失效时间	DATE
        [StringLength(30)]
        public string PASSWD { get; set; } //	口令	VARCHAR2(32)
        public int CUST_CATEGORY { get; set; } //	客户分组	NUMBER(9,0)
        public int AGREEMENT_ID { get; set; } //	协议标识	NUMBER(12,0)
        [StringLength(6)]
        public string IS_VIP { get; set; } //	重点客户标志	VARCHAR2(6)
        public int LATN_ID { get; set; } //	本地网标识	NUMBER(9,0)
        [StringLength(9)]
        public string IMP_CUST_TYPE { get; set; } //	重要客户类型	VARCHAR2(9)
        [StringLength(9)]
        public string CUST_CLASS { get; set; } //	客户分类	VARCHAR2(9)
        [StringLength(3)]
        public string CUST_TYPE { get; set; } //	客户类别	VARCHAR2(3)
        [StringLength(4)]
        public string CHARGE_PROVINCE_CODE { get; set; } //	收费省编码	VARCHAR2(4)
        public int CHARGE_LATN_ID { get; set; } //	收费本地网	NUMBER(9,0)
        [StringLength(4)]
        public string CUST_SUB_BRAND { get; set; } //	客户子品牌	VARCHAR2(4)
        [StringLength(4)]
        public string CUST_BRAND { get; set; } //	客户品牌	VARCHAR2(4)
        [StringLength(3)]
        public string CUST_SERVD_LEVEL { get; set; } //	客户服务等级	VARCHAR2(3)
        public int SALE_ORGANIZE_ID { get; set; } //	销售组织标识	NUMBER(9,0)
        public int COUNTY_TYPE { get; set; } //	城乡属性	NUMBER(3,0)
        public int MANAGE_LEVEL { get; set; } //	管控属性	NUMBER(3,0)
        [StringLength(30)]
        public string GRID_CODE { get; set; } //	网格编码	VARCHAR2(30)
        [StringLength(6)]
        public string NEW_CUST_TYPE { get; set; } //	新战略分群	VARCHAR2(6)
        public int AREA_ID { get; set; } //	营业区标识	NUMBER(9,0)
        public int MANAGE_CUST_ID { get; set; } //	管控客户标识	NUMBER(9,0)
        public char OCS_USER_FLAG { get; set; } //	OCS用户标识	CHAR(1)
        [StringLength(3)]
        public string GROUP_GRADE { get; set; } //	客户级别	VARCHAR2(3)
        public int CUST_TYPE_ID { get; set; } //	客户类型	NUMBER(9,0)
        public int REGION_SALE_CODE { get; set; } //	区域销售中心	NUMBER(9,0)

        [ForeignKey("MANAGE_CUST_ID")]
        public MANAGE_CUST_INFO MANAGE_CUST_INFO { get; set; }

        [ForeignKey("CUST_TYPE_ID")]
        public CUST_TYPE Cust_Type { get; set; }

    }
}
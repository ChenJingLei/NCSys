using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class SERV
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SERV_ID { get; set; }//	主产品实例标识	NUMBER(12,0)
        public int CUST_ID { get; set; }//	客户标识	NUMBER(12,0)
        public int PRODUCT_ID { get; set; }//	产品标识	NUMBER(9,0)
        public int AGREEMENT_ID { get; set; }//	客户协议标识	NUMBER(12,0)
        public int BILLING_CYCLE_TYPE_ID { get; set; }//	帐务周期类别标识	NUMBER(9,0)
        public int BILLING_MODE_ID { get; set; }//	计费模式标识	NUMBER(9,0)
        public DateTime COMPLETED_DATE { get; set; }//	竣工日期	DATE
        public DateTime RENT_DATE { get; set; }//	起租日期	DATE
        public DateTime CREATE_DATE { get; set; }//	建立日期	DATE
        public DateTime EFF_DATE { get; set; }//	生效日期	DATE
        public DateTime EXP_DATE { get; set; }//	失效日期	DATE
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime STATE_DATE { get; set; }//	状态时间	DATE
        public int CUST_CATEGORY { get; set; }//	客户分组	NUMBER(9,0)
        public int CREDIT_LIMIT_PLAN_ID { get; set; }//	限额计划标识	NUMBER(6,0)
        public int BONUS_PLAN_ID { get; set; }//	积分计划标识	NUMBER(9,0)
        public int HOT_BILLING_FLAG { get; set; }//	是否是准实时用户	NUMBER(9,0)
        public int LATN_ID { get; set; }//	本地网标识	NUMBER(9,0)
        [StringLength(10)]
        public string USER_SUB_BRAND { get; set; }//	用户子品牌	VARCHAR2(10)
        [StringLength(10)]
        public string USER_BRAND { get; set; }//	用户品牌	VARCHAR2(10)

        // Foreign Key

        // Navigation property
        [ForeignKey("CUST_ID")]
        public CUST CUST { get; set; }

        [ForeignKey("BILLING_CYCLE_TYPE_ID")]
        public BILLING_CYCLE_TYPE BILLING_CYCLE_TYPE { get; set; }

        [ForeignKey("PRODUCT_ID")]
        public PRODUCT PRODUCT { get; set; }

    }
}
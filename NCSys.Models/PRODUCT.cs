using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class PRODUCT
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRODUCT_ID { get; set; }//	产品标识	NUMBER(9,0)
        public int PRODUCT_PROVIDER_ID { get; set; }//	产品提供者标识	NUMBER(9,0)
        public int PRICING_PLAN_ID { get; set; }//	定价计划标识	NUMBER(9,0)
        public int product_family_id { get; set; }//	产品家族标识	NUMBER(9,0)
        [StringLength(50)]
        public string PRODUCT_NAME { get; set; }//	产品名称	VARCHAR2(50)
        [StringLength(250)]
        public string product_comments { get; set; }//	产品描述	VARCHAR2(250)
        [StringLength(3)]
        public string PRODUCT_TYPE { get; set; }//	产品类型	VARCHAR2(3)
        [StringLength(3)]
        public string PRODUCT_CLASSIFICATION { get; set; }//	产品类别	VARCHAR2(3)
        [StringLength(15)]
        public string PRODUCT_CODE { get; set; }//	产品编码	VARCHAR2(15)
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        public int limit_num { get; set; }//	最大数量	NUMBER(6,0)
        public int no_rent_flag { get; set; }//	免月租标志	NUMBER(4,0)
        public DateTime CREATED_DATE { get; set; }//	创建时间	DATE
        public DateTime STATE_DATE { get; set; }//	状态修改时间	DATE
        public char IF_BILL_CONCERN { get; set; }//	IF_BILL_CONCERN	CHAR(1)

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class EXCHANGE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EXCHANGE_ID { get; set; }//	局向标识	NUMBER(9,0)
        public int REGION_ID { get; set; }//	区域标识	NUMBER(9,0)
        [StringLength(30)]
        public string EXCHANGE_CODE { get; set; }//	局向代码	VARCHAR2(30)
        [StringLength(50)]
        public string EXCHANGE_NAME { get; set; }//	局向名称	VARCHAR2(50)
        [StringLength(20)]
        public string ACC_NBR_BEGIN { get; set; }//	起始号码	VARCHAR2(20)
        [StringLength(20)]
        public string ACC_NBR_END { get; set; }//	终止号码	VARCHAR2(20)
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        public int area_id { get; set; }//	营业区标识	NUMBER(9,0)
        public int product_family_id { get; set; }//	产品家族标识	NUMBER(9,0)
        public int acc_nbr_tag { get; set; }//	固网号码	NUMBER(1,0)
        public int SITE_ID { get; set; }//	组织Id	NUMBER(12,0)

        [ForeignKey("REGION_ID")]
        public REGION REGION { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class SERV_IDENTIFICATION
    {
        [Key]
        public int SERV_ID { get; set; }//	主产品实例标识	NUMBER(12,0)
        public int AGREEMENT_ID { get; set; }//	客户协议标识	NUMBER(12,0)
        public int SEQ_NBR { get; set; }//	序列号	NUMBER(3,0)
        public int product_family_id { get; set; }//	产品家族标识	NUMBER(9,0)
        [StringLength(15)]
        public string AREA_CODE { get; set; }//	区号	VARCHAR2(15)
        [StringLength(31)]
        public string ACC_NBR { get; set; }//	主业务号码	VARCHAR2(31)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        [StringLength(31)]
        public string physical_nbr { get; set; }//	物理号码	VARCHAR2(31)
        public int latn_id { get; set; }//	本地网标识	NUMBER(9,0)


        [ForeignKey("SERV_ID")]
        public SERV SERV { get; set; }
    }
}

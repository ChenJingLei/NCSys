using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class SERV_LOCATION
    {
        [Key]
        public int SERV_ID { get; set; }//	主产品实例标识	NUMBER(12,0)
        public int SEQ_NBR { get; set; }//	序列号	NUMBER(3,0)
        public int AGREEMENT_ID { get; set; }//	客户协议标识	NUMBER(12,0)
        public int ADDRESS_ID { get; set; }//	地址标识	NUMBER(12,0)
        public int REGION_ID { get; set; }//	区域标识	NUMBER(9,0)
        public int EXCHANGE_ID { get; set; }//	局向标识	NUMBER(9,0)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        public DateTime EXP_DATE { get; set; }//	失效时间	DATE
        public int serv_type_id { get; set; }//	设备类型标识	NUMBER(4,0)
        public int billing_type_id { get; set; }//	计费类型标识	NUMBER(4,0)
        public int latn_id { get; set; }//	本地网标识	NUMBER(9,0)

        [ForeignKey("SERV_ID")]
        public SERV SERV { get; set; }

        [ForeignKey("ADDRESS_ID")]
        public ADDRESS ADDRESS { get; set; }

//        [ForeignKey("REGION_ID")]
//        public REGION REGION { get; set; }

        [ForeignKey("EXCHANGE_ID")]
        public EXCHANGE EXCHANGE { get; set; }

    }
}
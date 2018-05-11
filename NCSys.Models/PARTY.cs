using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class PARTY
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PARTY_ID { get; set; }//	参与人标识	NUMBER(12,0)
        [StringLength(50)]
        public string PARTY_NAME { get; set; }//	参与人名称	VARCHAR2(50)
        public DateTime EFF_DATE { get; set; }//	生效时间	DATE
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime STATE_DATE { get; set; }//	状态时间	DATE
        public int region_id { get; set; }//	网元标识	NUMBER(9,0)
        [StringLength(250)]
        public string PARTY_SOURCE_DESC { get; set; }//	PARTY_SOURCE_DESC	VARCHAR2(250)

//        [ForeignKey("region_id")]
//        public REGION REGION { get; set; }

    }
}
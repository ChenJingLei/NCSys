using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class PARTY_SERV
    {   
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PARTY_SERV_ID { get; set; }
        public int PARTY_ID { get; set; }//	参与人标识	NUMBER(12,0)
        public int SERV_ID { get; set; }//	主产品实例标识	NUMBER(12,0)
        [StringLength(10)]
        public string STATE { get; set; }//	状态	VARCHAR2(10)
        public DateTime LAST_UPDATE_DATE { get; set; }//	上一次更新时间	DATE

        [ForeignKey("PARTY_ID")]
        public PARTY PARTY { get; set; }

        [ForeignKey("SERV_ID")]
        public SERV SERV { get; set; }

    }
}
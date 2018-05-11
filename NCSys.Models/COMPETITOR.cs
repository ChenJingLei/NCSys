using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class COMPETITOR
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PARTY_ROLE_ID { get; set; }//	参与人角色标识	NUMBER(9,0)
        [StringLength(30)]
        public string COMPETITOR_CODE { get; set; }//	运营商编号	VARCHAR2(30)
        [StringLength(30)]
        public string COMPETITOR_NAME { get; set; }//	运营商名称	VARCHAR2(30)
        [StringLength(250)]
        public string COMPETITOR_DESC { get; set; }//	运营商描述	VARCHAR2(250)

        [ForeignKey("PARTY_ROLE_ID")]
        public PARTY_ROLE PARTY_ROLE { get; set; }

    }
}
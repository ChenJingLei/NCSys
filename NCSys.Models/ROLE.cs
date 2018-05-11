using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class ROLE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROLE_ID { get; set; }//	职位标识	NUMBER(9,0)
        [StringLength(50)]
        public string ROLE_NAME { get; set; }//	职位名称	VARCHAR2(50)
        [StringLength(250)]
        public string ROLE_DESC { get; set; }//	职位描述	VARCHAR2(250)
        public int party_role_id { get; set; }//	职位的员工标识	NUMBER(9,0)
        public int region_id { get; set; }//	网元标识	NUMBER(9,0)
        [StringLength(3)]
        public string state { get; set; }//	状态	CHAR(3)
        public DateTime State_date { get; set; }//	日期	DATE

//        [ForeignKey("region_id")]
//        public REGION REGION { get; set; }

    }
}

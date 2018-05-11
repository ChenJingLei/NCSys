using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class MANAGE_CUST_INFO
    {
        [Key]
        public int MANAGE_CUST_ID { get; set; }//	管控客户标识	NUMBER(9,0)
        [StringLength(200)]
        public string MANAGE_CUST_NAME { get; set; }//	管控客户名称	VARCHAR2(200)
        [StringLength(30)]
        public string MANAGE_CUST_CODE { get; set; }//	管控客户编码	VARCHAR2(30)
        [StringLength(250)]
        public string MANAGE_CUST_DESC { get; set; }//	管控客户说明	VARCHAR2(250)

    }
}

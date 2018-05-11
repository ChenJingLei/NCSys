using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class ROLE_PRIVILEGE
    {
        [Key]
        public int ROLE_ID { get; set; }//	职位标识	NUMBER(9,0)
        public int PRIVILEGE_ID { get; set; }//	权限标识	NUMBER(9,0)
        public char PRIVILEGE_TYPE { get; set; }//	权限类型	CHAR(1)
        public string state { get; set; }//	状态	CHAR(3)
        public DateTime State_date { get; set; }//	日期	DATE

        [ForeignKey("ROLE_ID")]
        public ROLE ROLE { get; set; }

        [ForeignKey("PRIVILEGE_ID")]
        public PRIVILEGE PRIVILEGE { get; set; }


    }
}

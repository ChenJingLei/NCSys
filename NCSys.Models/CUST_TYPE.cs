using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class CUST_TYPE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CUST_TYPE_ID { get; set; }//	客户类型标识	NUMBER(9,0)
        [StringLength(50)]
        public string CUST_TYPE_NAME { get; set; }//	客户类型名称	VARCHAR2(50)
        public int PARENT_TYPE_ID { get; set; }//	父类型标识	NUMBER(9,0)
        public int TYPE_LEVEL { get; set; }//	类型级别	NUMBER(1,0)
        public int PARENT_CUST_TYPE_ID { get; set; }//	父客户类型标识	NUMBER(9,0)

        [ForeignKey("PARENT_CUST_TYPE_ID")]
        public CUST_TYPE PARENT_CUST_TYPE { get; set; }

    }
}

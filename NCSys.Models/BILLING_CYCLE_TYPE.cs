using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class BILLING_CYCLE_TYPE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BILLING_CYCLE_TYPE_ID { get; set; }//	帐务周期类别标识	NUMBER(9,0)
        public int REGION_ID { get; set; }//	电信管理区域标识	NUMBER(9,0)
        [StringLength(50)]
        public string BILLING_CYCLE_TYPE_NAME { get; set; }//	帐务周期类别名称	VARCHAR2(50)
        [StringLength(3)]
        public string CYCLE_UNIT { get; set; }//	周期单位	VARCHAR2(3)
        public int UNIT_COUNT { get; set; }//	单位间隔数	NUMBER(5,0)
        public int CYCLE_DURATION { get; set; }//	单位偏移量	NUMBER(5,0)
        public int CYCLE_DURATION_DAYS { get; set; }//	偏移天数	NUMBER(5,0)

//        [ForeignKey("REGION_ID")]
//        public REGION REGION { get; set; }
    }
}

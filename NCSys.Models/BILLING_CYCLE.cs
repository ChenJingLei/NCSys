using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class BILLING_CYCLE
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BILLING_CYCLE_ID { get; set; }//	帐务周期标识	NUMBER(9,0)
        public int BILLING_CYCLE_TYPE_ID { get; set; }//	帐务周期类别标识	NUMBER(9,0)
        public int LAST_BILLING_CYCLE_ID { get; set; }//	上个帐务周期	NUMBER(9,0)
        public DateTime CYCLE_BEGIN_DATE { get; set; }//	周期开始时间	DATE
        public DateTime CYCLE_END_DATE { get; set; }//	周期截止时间	DATE
        public double AMOUNT { get; set; }//	金额	NUMBER(16,5)
        public DateTime BLOCK_DATE { get; set; }//	应停机日期	DATE
        public string STATE { get; set; }//	状态	VARCHAR2(3)
        public DateTime STATE_DATE { get; set; }//	状态时间	DATE
        public char cycle_cc_flag { get; set; }//	帐期信控标志	char(1)

        [ForeignKey("BILLING_CYCLE_TYPE_ID")]
        public BILLING_CYCLE_TYPE BILLING_CYCLE_TYPE { get; set; }

        [ForeignKey("LAST_BILLING_CYCLE_ID")]
        public BILLING_CYCLE LAST_BILLING_CYCLE { get; set; }

    }
}

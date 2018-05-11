using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSys.Models
{
    public class REGION
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int REGION_ID { get; set; }//	区域标识	NUMBER(9,0)
        public int PARENT_REGION_ID { get; set; }//	上级区域标识	NUMBER(9,0)
        [StringLength(3)]
        public string REGION_LEVEL { get; set; }//	区域级别	VARCHAR2(3)
        [StringLength(50)]
        public string REGION_NAME { get; set; }//	区域名称	VARCHAR2(50)
        [StringLength(250)]
        public string REGION_DESC { get; set; }//	区域描述	VARCHAR2(250)
        [StringLength(20)]
        public string REGION_CODE { get; set; }//	区域编码	VARCHAR2(20)
        [StringLength(4)]
        public string PROVINCE_CODE { get; set; }//	省代码	VARCHAR2(4)
        [StringLength(4)]
        public string uni_code { get; set; }//	标准编码	VARCHAR2(4)
        public char IS_ACTUAL_REGION { get; set; }//	大客户区域标识	CHAR(1)
        public char REGION_TYPE { get; set; }//	区域类型	CHAR(1)

        [ForeignKey("PARENT_REGION_ID")]
        public REGION PARENT_REGION { get; set; }

    }
}

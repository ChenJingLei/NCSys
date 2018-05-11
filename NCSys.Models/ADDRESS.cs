using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCSys.Models
{
    public class ADDRESS
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ADDRESS_ID { get; set; }//	地址标识	NUMBER(12,0)
        public double LONGITUDE { get; set; }//	精度	
        public double LATITUDE { get; set; }//	维度	
        [StringLength(30)]
        public string PROVINCE_NAME { get; set; }//	省名	VARCHAR2(30)
        [StringLength(30)]
        public string CITY_NAME { get; set; }//	城市名	VARCHAR2(30)
        [StringLength(30)]
        public string DISTRICT_NAME { get; set; }//	行政区名	VARCHAR2(30)
        [StringLength(30)]
        public string STREET_NAME { get; set; }//	街道名	VARCHAR2(30)
        [StringLength(30)]
        public string STREET_NBR { get; set; }//	门牌号	VARCHAR2(30)
        [StringLength(30)]
        public string COMMUNITY_NAME { get; set; }//	小区名	VARCHAR2(30)
        [StringLength(30)]
        public string BUILDING_NAME { get; set; }//	楼名	VARCHAR2(30)
        [StringLength(30)]
        public string UNIT_NBR { get; set; }//	单元	VARCHAR2(30)
        [StringLength(30)]
        public string ROOM_NBR { get; set; }//	房间号	VARCHAR2(30)
        [StringLength(300)]
        public string DETAIL { get; set; }//	详细信息	VARCHAR2(300)
        [StringLength(30)]
        public string POSTCODE { get; set; }//	邮政编码	VARCHAR2(30)
        public int latn_id { get; set; }//	本地网标识	NUMBER(9,0)
        [StringLength(3)]
        public string STATE { get; set; }//	状态	VARCAHR2(3)

    }
}
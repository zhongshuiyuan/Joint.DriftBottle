//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joint.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class JingQing : BaseModel
    {
        public int ID { get; set; }
        public string UnitCode { get; set; }
        public string Caption { get; set; }
        public string BJROpenID { get; set; }
        public Nullable<double> Lng { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<short> State { get; set; }
        public string Intro { get; set; }
        public Nullable<int> NewsNum { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Address { get; set; }
        public string BJRXM { get; set; }
        public string BJRTel { get; set; }
        public Nullable<System.DateTime> ChuJingTime { get; set; }
        public Nullable<short> JQType { get; set; }
        public Nullable<short> IsWeiXinJQ { get; set; }
        public Nullable<System.DateTime> WeiInfoUpdateTime { get; set; }
        public string hasRead { get; set; }
        public string JJXUserName { get; set; }
        public string JJDBH { get; set; }
        public string DCFeedback { get; set; }
        public string CZFeedback { get; set; }
        public string QianShouRen { get; set; }
        public Nullable<System.DateTime> QianShouTime { get; set; }
        public Nullable<double> QianShouLng { get; set; }
        public Nullable<double> QianShouLat { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblm_visit_detail
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> psr_id { get; set; }
        public Nullable<int> route_id { get; set; }
        public Nullable<int> outlet_id { get; set; }
        public Nullable<int> visit_type { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string remark { get; set; }
    }
}
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
    
    public partial class tbld_distribution_employee
    {
        public int id { get; set; }
        public string Emp_code { get; set; }
        public string Name { get; set; }
        public string Emp_address { get; set; }
        public Nullable<int> User_role_id { get; set; }
        public Nullable<int> DistributionId { get; set; }
        public string login_user_id { get; set; }
        public string login_user_password { get; set; }
        public string contact_no { get; set; }
        public Nullable<System.DateTime> joining_date { get; set; }
        public string designation { get; set; }
        public Nullable<int> Emp_Type { get; set; }
        public Nullable<System.DateTime> d_o_b { get; set; }
        public string email { get; set; }
        public string emergency_contact_person { get; set; }
        public string emergency_contact_number { get; set; }
        public string educational_qualification { get; set; }
        public string image { get; set; }
        public Nullable<int> active { get; set; }
    }
}
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
    
    public partial class tbld_AdjustmentStockItem
    {
        public int ItemID { get; set; }
        public int AdjustmentStockID { get; set; }
        public int SKUID { get; set; }
        public Nullable<int> BatchNo { get; set; }
        public int PreviousQty { get; set; }
        public int CurrentQty { get; set; }
        public int AdjustedQty { get; set; }
    
        public virtual tbld_AdjustmentStock tbld_AdjustmentStock { get; set; }
    }
}
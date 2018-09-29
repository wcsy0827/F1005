//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace F1005.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsersData()
        {
            this.SummaryTable = new HashSet<SummaryTable>();
            this.Fund = new HashSet<Fund>();
            this.Insurances = new HashSet<Insurances>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<bool> RememberMe { get; set; }
        public string AnyOne { get; set; }
        public Nullable<double> CashValue { get; set; }
        public Nullable<double> StockValue { get; set; }
        public Nullable<double> FXValue { get; set; }
        public Nullable<double> InsuranceValue { get; set; }
        public Nullable<double> FundValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SummaryTable> SummaryTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fund> Fund { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Insurances> Insurances { get; set; }
    }
}
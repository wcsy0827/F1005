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
    
    public partial class CurrencyRate
    {
        public int ID { get; set; }
        public string CurrencyClass { get; set; }
        public string CashBuy { get; set; }
        public string CashSell { get; set; }
        public string OnlineBuy { get; set; }
        public string OnlineSell { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
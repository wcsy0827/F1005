﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyInvestEntities : DbContext
    {
        public MyInvestEntities()
            : base("name=MyInvestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CashExpense> CashExpense { get; set; }
        public virtual DbSet<CashIncome> CashIncome { get; set; }
        public virtual DbSet<StockHistory> StockHistory { get; set; }
        public virtual DbSet<StockIDList> StockIDList { get; set; }
        public virtual DbSet<SummaryTable> SummaryTable { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UsersData> UsersData { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<FXtradeTable> FXtradeTable { get; set; }
        public virtual DbSet<Fund> Fund { get; set; }
        public virtual DbSet<Insurances> Insurances { get; set; }
    }
}
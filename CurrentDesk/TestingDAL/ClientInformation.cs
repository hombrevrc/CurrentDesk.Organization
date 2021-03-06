//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace TestingDAL
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(AccountCurrency))]
    [KnownType(typeof(AccountType))]
    [KnownType(typeof(L_Account))]
    [KnownType(typeof(TradingPlatform))]
    public partial class ClientInformation
    {
        public ClientInformation()
        {
            this.AccountCurrencies = new HashSet<AccountCurrency>();
            this.AccountTypes = new HashSet<AccountType>();
            this.L_Account = new HashSet<L_Account>();
            this.TradingPlatforms = new HashSet<TradingPlatform>();
        }
    
        [DataMember]
        public int PK_ClientID { get; set; }
        [DataMember]
        public string ClientName { get; set; }
    
        [DataMember]
        public virtual ICollection<AccountCurrency> AccountCurrencies { get; set; }
        [DataMember]
        public virtual ICollection<AccountType> AccountTypes { get; set; }
        [DataMember]
        public virtual ICollection<L_Account> L_Account { get; set; }
        [DataMember]
        public virtual ICollection<TradingPlatform> TradingPlatforms { get; set; }
    }
    
}

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
    [KnownType(typeof(IntroducingBroker))]
    [KnownType(typeof(L_Account))]
    [KnownType(typeof(L_Country))]
    [KnownType(typeof(L_Languages))]
    [KnownType(typeof(TradingPlatform))]
    public partial class LiveLead
    {
        [DataMember]
        public int PK_LeadID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string PhoneNo { get; set; }
        [DataMember]
        public Nullable<int> FK_AccountID { get; set; }
        [DataMember]
        public Nullable<int> FK_ResidenceCountry { get; set; }
        [DataMember]
        public Nullable<int> FK_IntroducingBrokerID { get; set; }
        [DataMember]
        public Nullable<int> FK_AccountTypeID { get; set; }
        [DataMember]
        public Nullable<int> FK_AccountCurrencyID { get; set; }
        [DataMember]
        public Nullable<int> FK_PlatformID { get; set; }
        [DataMember]
        public Nullable<int> FK_PreferedCommunicationLanguage { get; set; }
        [DataMember]
        public Nullable<bool> IsEnglishSpeaking { get; set; }
        [DataMember]
        public string Password { get; set; }
    
        [DataMember]
        public virtual AccountCurrency AccountCurrency { get; set; }
        [DataMember]
        public virtual AccountType AccountType { get; set; }
        [DataMember]
        public virtual IntroducingBroker IntroducingBroker { get; set; }
        [DataMember]
        public virtual L_Account L_Account { get; set; }
        [DataMember]
        public virtual L_Country L_Country { get; set; }
        [DataMember]
        public virtual L_Languages L_Languages { get; set; }
        [DataMember]
        public virtual TradingPlatform TradingPlatform { get; set; }
    }
    
}
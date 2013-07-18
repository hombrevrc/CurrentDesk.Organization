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
    [KnownType(typeof(Client))]
    [KnownType(typeof(CorporateAccountInformation))]
    [KnownType(typeof(DemoLead))]
    [KnownType(typeof(IndividualAccountInformation))]
    [KnownType(typeof(JointAccountInformation))]
    [KnownType(typeof(LiveLead))]
    [KnownType(typeof(TrustAccountInformation))]
    public partial class L_Country
    {
        public L_Country()
        {
            this.Clients = new HashSet<Client>();
            this.CorporateAccountInformations = new HashSet<CorporateAccountInformation>();
            this.CorporateAccountInformations1 = new HashSet<CorporateAccountInformation>();
            this.CorporateAccountInformations2 = new HashSet<CorporateAccountInformation>();
            this.CorporateAccountInformations3 = new HashSet<CorporateAccountInformation>();
            this.DemoLeads = new HashSet<DemoLead>();
            this.IndividualAccountInformations = new HashSet<IndividualAccountInformation>();
            this.IndividualAccountInformations1 = new HashSet<IndividualAccountInformation>();
            this.IndividualAccountInformations2 = new HashSet<IndividualAccountInformation>();
            this.IndividualAccountInformations3 = new HashSet<IndividualAccountInformation>();
            this.JointAccountInformations = new HashSet<JointAccountInformation>();
            this.JointAccountInformations1 = new HashSet<JointAccountInformation>();
            this.JointAccountInformations2 = new HashSet<JointAccountInformation>();
            this.JointAccountInformations3 = new HashSet<JointAccountInformation>();
            this.JointAccountInformations4 = new HashSet<JointAccountInformation>();
            this.JointAccountInformations5 = new HashSet<JointAccountInformation>();
            this.LiveLeads = new HashSet<LiveLead>();
            this.TrustAccountInformations = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations1 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations2 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations3 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations4 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations5 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations6 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations7 = new HashSet<TrustAccountInformation>();
            this.TrustAccountInformations8 = new HashSet<TrustAccountInformation>();
        }
    
        [DataMember]
        public int PK_CountryID { get; set; }
        [DataMember]
        public string CountryName { get; set; }
    
        [DataMember]
        public virtual ICollection<Client> Clients { get; set; }
        [DataMember]
        public virtual ICollection<CorporateAccountInformation> CorporateAccountInformations { get; set; }
        [DataMember]
        public virtual ICollection<CorporateAccountInformation> CorporateAccountInformations1 { get; set; }
        [DataMember]
        public virtual ICollection<CorporateAccountInformation> CorporateAccountInformations2 { get; set; }
        [DataMember]
        public virtual ICollection<CorporateAccountInformation> CorporateAccountInformations3 { get; set; }
        [DataMember]
        public virtual ICollection<DemoLead> DemoLeads { get; set; }
        [DataMember]
        public virtual ICollection<IndividualAccountInformation> IndividualAccountInformations { get; set; }
        [DataMember]
        public virtual ICollection<IndividualAccountInformation> IndividualAccountInformations1 { get; set; }
        [DataMember]
        public virtual ICollection<IndividualAccountInformation> IndividualAccountInformations2 { get; set; }
        [DataMember]
        public virtual ICollection<IndividualAccountInformation> IndividualAccountInformations3 { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations1 { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations2 { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations3 { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations4 { get; set; }
        [DataMember]
        public virtual ICollection<JointAccountInformation> JointAccountInformations5 { get; set; }
        [DataMember]
        public virtual ICollection<LiveLead> LiveLeads { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations1 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations2 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations3 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations4 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations5 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations6 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations7 { get; set; }
        [DataMember]
        public virtual ICollection<TrustAccountInformation> TrustAccountInformations8 { get; set; }
    }
    
}
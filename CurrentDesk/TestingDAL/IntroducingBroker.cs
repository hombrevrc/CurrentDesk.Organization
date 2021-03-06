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
    [KnownType(typeof(DemoLead))]
    [KnownType(typeof(LiveLead))]
    public partial class IntroducingBroker
    {
        public IntroducingBroker()
        {
            this.DemoLeads = new HashSet<DemoLead>();
            this.LiveLeads = new HashSet<LiveLead>();
        }
    
        [DataMember]
        public int PK_IntroducingBrokerID { get; set; }
        [DataMember]
        public string IntroducingBrokerName { get; set; }
    
        [DataMember]
        public virtual ICollection<DemoLead> DemoLeads { get; set; }
        [DataMember]
        public virtual ICollection<LiveLead> LiveLeads { get; set; }
    }
    
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


namespace CurrentDesk.Models
{

public partial class L_TicketSize
{
    #region Primitive Properties
    

    public virtual int PK_TicketSizeID
    {

        get;
        set;

    }


    public virtual string TicketSizeValue
    {

        get;
        set;

    }

        #endregion

        #region Navigation Properties
    


    public virtual ICollection<DemoLead> DemoLeads
    {
        get
        {
            if (_demoLeads == null)
            {

                var newCollection = new FixupCollection<DemoLead>();
                newCollection.CollectionChanged += FixupDemoLeads;
                _demoLeads = newCollection;

            }
            return _demoLeads;
        }
        set
        {

            if (!ReferenceEquals(_demoLeads, value))
            {
                var previousValue = _demoLeads as FixupCollection<DemoLead>;
                if (previousValue != null)
                {
                    previousValue.CollectionChanged -= FixupDemoLeads;
                }
                _demoLeads = value;
                var newValue = value as FixupCollection<DemoLead>;
                if (newValue != null)
                {
                    newValue.CollectionChanged += FixupDemoLeads;
                }
            }

        }
    }
    private ICollection<DemoLead> _demoLeads;

        #endregion

        #region Association Fixup
    

    private void FixupDemoLeads(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null)
        {
            foreach (DemoLead item in e.NewItems)
            {

                item.L_TicketSize = this;

            }
        }

        if (e.OldItems != null)
        {
            foreach (DemoLead item in e.OldItems)
            {

                if (ReferenceEquals(item.L_TicketSize, this))
                {
                    item.L_TicketSize = null;
                }

            }
        }
    }

        #endregion

    
}

}

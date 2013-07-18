
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

public partial class LeadNote
{
    #region Primitive Properties
    

    public virtual int PK_LeadNotesID
    {

        get;
        set;

    }


    public virtual Nullable<int> FK_LeadID
    {

        get { return _fK_LeadID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_LeadID != value)

            {

                if (DemoLead != null && DemoLead.PK_LeadID != value)

                {

                    DemoLead = null;

                }

                _fK_LeadID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_LeadID;


    public virtual Nullable<int> FK_EmployeeID
    {

        get { return _fK_EmployeeID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_EmployeeID != value)

            {

                if (Employee != null && Employee.PK_EmployeeID != value)

                {

                    Employee = null;

                }

                _fK_EmployeeID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_EmployeeID;


    public virtual Nullable<System.DateTime> TimeStamp
    {

        get;
        set;

    }


    public virtual string Note
    {

        get;
        set;

    }

        #endregion

        #region Navigation Properties
    


    public virtual Employee Employee
    {

        get { return _employee; }
        set
        {
            if (!ReferenceEquals(_employee, value))
            {
                var previousValue = _employee;
                _employee = value;
                FixupEmployee(previousValue);
            }
        }
    }
    private Employee _employee;



    public virtual DemoLead DemoLead
    {

        get { return _demoLead; }
        set
        {
            if (!ReferenceEquals(_demoLead, value))
            {
                var previousValue = _demoLead;
                _demoLead = value;
                FixupDemoLead(previousValue);
            }
        }
    }
    private DemoLead _demoLead;

        #endregion

        #region Association Fixup
    

    private bool _settingFK = false;


    private void FixupEmployee(Employee previousValue)
    {

        if (previousValue != null && previousValue.LeadNotes.Contains(this))
        {
            previousValue.LeadNotes.Remove(this);
        }


        if (Employee != null)
        {
            if (!Employee.LeadNotes.Contains(this))
            {
                Employee.LeadNotes.Add(this);
            }

            if (FK_EmployeeID != Employee.PK_EmployeeID)

            {
                FK_EmployeeID = Employee.PK_EmployeeID;
            }

        }

        else if (!_settingFK)

        {

            FK_EmployeeID = null;

        }

    }


    private void FixupDemoLead(DemoLead previousValue)
    {

        if (previousValue != null && previousValue.LeadNotes.Contains(this))
        {
            previousValue.LeadNotes.Remove(this);
        }


        if (DemoLead != null)
        {
            if (!DemoLead.LeadNotes.Contains(this))
            {
                DemoLead.LeadNotes.Add(this);
            }

            if (FK_LeadID != DemoLead.PK_LeadID)

            {
                FK_LeadID = DemoLead.PK_LeadID;
            }

        }

        else if (!_settingFK)

        {

            FK_LeadID = null;

        }

    }

        #endregion

    
}

}
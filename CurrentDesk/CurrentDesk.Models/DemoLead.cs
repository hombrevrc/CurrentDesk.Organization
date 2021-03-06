
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

public partial class DemoLead
{
    #region Primitive Properties
    

    public virtual int PK_LeadID
    {

        get;
        set;

    }


    public virtual string FirstName
    {

        get;
        set;

    }


    public virtual string LastName
    {

        get;
        set;

    }


    public virtual string EmailAddress
    {

        get;
        set;

    }


    public virtual string PhoneNo
    {

        get;
        set;

    }


    public virtual Nullable<int> FK_ResidenceCountry
    {

        get { return _fK_ResidenceCountry; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_ResidenceCountry != value)

            {

                if (L_Country != null && L_Country.PK_CountryID != value)

                {

                    L_Country = null;

                }

                _fK_ResidenceCountry = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_ResidenceCountry;


    public virtual Nullable<int> FK_AccountTypeID
    {

        get { return _fK_AccountTypeID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_AccountTypeID != value)

            {

                if (AccountType != null && AccountType.PK_AccountType != value)

                {

                    AccountType = null;

                }

                _fK_AccountTypeID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_AccountTypeID;


    public virtual Nullable<int> FK_AccountCurrencyID
    {

        get { return _fK_AccountCurrencyID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_AccountCurrencyID != value)

            {

                if (AccountCurrency != null && AccountCurrency.PK_AccountCurrencyID != value)

                {

                    AccountCurrency = null;

                }

                _fK_AccountCurrencyID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_AccountCurrencyID;


    public virtual Nullable<int> FK_PlatformID
    {

        get { return _fK_PlatformID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_PlatformID != value)

            {

                if (TradingPlatform != null && TradingPlatform.PK_TradingPlatformID != value)

                {

                    TradingPlatform = null;

                }

                _fK_PlatformID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_PlatformID;


    public virtual Nullable<int> FK_ExperienceID
    {

        get { return _fK_ExperienceID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_ExperienceID != value)

            {

                if (L_TradingExperience != null && L_TradingExperience.PK_ExperienceID != value)

                {

                    L_TradingExperience = null;

                }

                _fK_ExperienceID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_ExperienceID;


    public virtual Nullable<int> FK_InvestmentID
    {

        get { return _fK_InvestmentID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_InvestmentID != value)

            {

                if (L_InitialInvestment != null && L_InitialInvestment.PK_InitialInvestmentID != value)

                {

                    L_InitialInvestment = null;

                }

                _fK_InvestmentID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_InvestmentID;


    public virtual Nullable<int> FK_TicketSizeID
    {

        get { return _fK_TicketSizeID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_TicketSizeID != value)

            {

                if (L_TicketSize != null && L_TicketSize.PK_TicketSizeID != value)

                {

                    L_TicketSize = null;

                }

                _fK_TicketSizeID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_TicketSizeID;


    public virtual Nullable<int> FK_PreferedCommunicationLanguage
    {

        get { return _fK_PreferedCommunicationLanguage; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_PreferedCommunicationLanguage != value)

            {

                if (L_Languages != null && L_Languages.PK_LanguageID != value)

                {

                    L_Languages = null;

                }

                _fK_PreferedCommunicationLanguage = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_PreferedCommunicationLanguage;


    public virtual bool IsEnglishSpeaking
    {

        get;
        set;

    }


    public virtual string Password
    {

        get;
        set;

    }


    public virtual Nullable<int> FK_AccountID
    {

        get { return _fK_AccountID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_AccountID != value)

            {

                if (L_AccountCode != null && L_AccountCode.PK_AccountID != value)

                {

                    L_AccountCode = null;

                }

                _fK_AccountID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_AccountID;


    public virtual string IntroducingBrokerOrAgent
    {

        get;
        set;

    }


    public virtual int FK_OrganizationID
    {

        get { return _fK_OrganizationID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_OrganizationID != value)

            {

                if (Organization != null && Organization.PK_OrganizationID != value)

                {

                    Organization = null;

                }

                _fK_OrganizationID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private int _fK_OrganizationID;

        #endregion

        #region Navigation Properties
    


    public virtual AccountCurrency AccountCurrency
    {

        get { return _accountCurrency; }
        set
        {
            if (!ReferenceEquals(_accountCurrency, value))
            {
                var previousValue = _accountCurrency;
                _accountCurrency = value;
                FixupAccountCurrency(previousValue);
            }
        }
    }
    private AccountCurrency _accountCurrency;



    public virtual AccountType AccountType
    {

        get { return _accountType; }
        set
        {
            if (!ReferenceEquals(_accountType, value))
            {
                var previousValue = _accountType;
                _accountType = value;
                FixupAccountType(previousValue);
            }
        }
    }
    private AccountType _accountType;



    public virtual L_AccountCode L_AccountCode
    {

        get { return _l_AccountCode; }
        set
        {
            if (!ReferenceEquals(_l_AccountCode, value))
            {
                var previousValue = _l_AccountCode;
                _l_AccountCode = value;
                FixupL_AccountCode(previousValue);
            }
        }
    }
    private L_AccountCode _l_AccountCode;



    public virtual L_Country L_Country
    {

        get { return _l_Country; }
        set
        {
            if (!ReferenceEquals(_l_Country, value))
            {
                var previousValue = _l_Country;
                _l_Country = value;
                FixupL_Country(previousValue);
            }
        }
    }
    private L_Country _l_Country;



    public virtual L_InitialInvestment L_InitialInvestment
    {

        get { return _l_InitialInvestment; }
        set
        {
            if (!ReferenceEquals(_l_InitialInvestment, value))
            {
                var previousValue = _l_InitialInvestment;
                _l_InitialInvestment = value;
                FixupL_InitialInvestment(previousValue);
            }
        }
    }
    private L_InitialInvestment _l_InitialInvestment;



    public virtual L_Languages L_Languages
    {

        get { return _l_Languages; }
        set
        {
            if (!ReferenceEquals(_l_Languages, value))
            {
                var previousValue = _l_Languages;
                _l_Languages = value;
                FixupL_Languages(previousValue);
            }
        }
    }
    private L_Languages _l_Languages;



    public virtual L_TicketSize L_TicketSize
    {

        get { return _l_TicketSize; }
        set
        {
            if (!ReferenceEquals(_l_TicketSize, value))
            {
                var previousValue = _l_TicketSize;
                _l_TicketSize = value;
                FixupL_TicketSize(previousValue);
            }
        }
    }
    private L_TicketSize _l_TicketSize;



    public virtual L_TradingExperience L_TradingExperience
    {

        get { return _l_TradingExperience; }
        set
        {
            if (!ReferenceEquals(_l_TradingExperience, value))
            {
                var previousValue = _l_TradingExperience;
                _l_TradingExperience = value;
                FixupL_TradingExperience(previousValue);
            }
        }
    }
    private L_TradingExperience _l_TradingExperience;



    public virtual TradingPlatform TradingPlatform
    {

        get { return _tradingPlatform; }
        set
        {
            if (!ReferenceEquals(_tradingPlatform, value))
            {
                var previousValue = _tradingPlatform;
                _tradingPlatform = value;
                FixupTradingPlatform(previousValue);
            }
        }
    }
    private TradingPlatform _tradingPlatform;



    public virtual ICollection<LeadNote> LeadNotes
    {
        get
        {
            if (_leadNotes == null)
            {

                var newCollection = new FixupCollection<LeadNote>();
                newCollection.CollectionChanged += FixupLeadNotes;
                _leadNotes = newCollection;

            }
            return _leadNotes;
        }
        set
        {

            if (!ReferenceEquals(_leadNotes, value))
            {
                var previousValue = _leadNotes as FixupCollection<LeadNote>;
                if (previousValue != null)
                {
                    previousValue.CollectionChanged -= FixupLeadNotes;
                }
                _leadNotes = value;
                var newValue = value as FixupCollection<LeadNote>;
                if (newValue != null)
                {
                    newValue.CollectionChanged += FixupLeadNotes;
                }
            }

        }
    }
    private ICollection<LeadNote> _leadNotes;



    public virtual Organization Organization
    {

        get { return _organization; }
        set
        {
            if (!ReferenceEquals(_organization, value))
            {
                var previousValue = _organization;
                _organization = value;
                FixupOrganization(previousValue);
            }
        }
    }
    private Organization _organization;

        #endregion

        #region Association Fixup
    

    private bool _settingFK = false;


    private void FixupAccountCurrency(AccountCurrency previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (AccountCurrency != null)
        {
            if (!AccountCurrency.DemoLeads.Contains(this))
            {
                AccountCurrency.DemoLeads.Add(this);
            }

            if (FK_AccountCurrencyID != AccountCurrency.PK_AccountCurrencyID)

            {
                FK_AccountCurrencyID = AccountCurrency.PK_AccountCurrencyID;
            }

        }

        else if (!_settingFK)

        {

            FK_AccountCurrencyID = null;

        }

    }


    private void FixupAccountType(AccountType previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (AccountType != null)
        {
            if (!AccountType.DemoLeads.Contains(this))
            {
                AccountType.DemoLeads.Add(this);
            }

            if (FK_AccountTypeID != AccountType.PK_AccountType)

            {
                FK_AccountTypeID = AccountType.PK_AccountType;
            }

        }

        else if (!_settingFK)

        {

            FK_AccountTypeID = null;

        }

    }


    private void FixupL_AccountCode(L_AccountCode previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_AccountCode != null)
        {
            if (!L_AccountCode.DemoLeads.Contains(this))
            {
                L_AccountCode.DemoLeads.Add(this);
            }

            if (FK_AccountID != L_AccountCode.PK_AccountID)

            {
                FK_AccountID = L_AccountCode.PK_AccountID;
            }

        }

        else if (!_settingFK)

        {

            FK_AccountID = null;

        }

    }


    private void FixupL_Country(L_Country previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_Country != null)
        {
            if (!L_Country.DemoLeads.Contains(this))
            {
                L_Country.DemoLeads.Add(this);
            }

            if (FK_ResidenceCountry != L_Country.PK_CountryID)

            {
                FK_ResidenceCountry = L_Country.PK_CountryID;
            }

        }

        else if (!_settingFK)

        {

            FK_ResidenceCountry = null;

        }

    }


    private void FixupL_InitialInvestment(L_InitialInvestment previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_InitialInvestment != null)
        {
            if (!L_InitialInvestment.DemoLeads.Contains(this))
            {
                L_InitialInvestment.DemoLeads.Add(this);
            }

            if (FK_InvestmentID != L_InitialInvestment.PK_InitialInvestmentID)

            {
                FK_InvestmentID = L_InitialInvestment.PK_InitialInvestmentID;
            }

        }

        else if (!_settingFK)

        {

            FK_InvestmentID = null;

        }

    }


    private void FixupL_Languages(L_Languages previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_Languages != null)
        {
            if (!L_Languages.DemoLeads.Contains(this))
            {
                L_Languages.DemoLeads.Add(this);
            }

            if (FK_PreferedCommunicationLanguage != L_Languages.PK_LanguageID)

            {
                FK_PreferedCommunicationLanguage = L_Languages.PK_LanguageID;
            }

        }

        else if (!_settingFK)

        {

            FK_PreferedCommunicationLanguage = null;

        }

    }


    private void FixupL_TicketSize(L_TicketSize previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_TicketSize != null)
        {
            if (!L_TicketSize.DemoLeads.Contains(this))
            {
                L_TicketSize.DemoLeads.Add(this);
            }

            if (FK_TicketSizeID != L_TicketSize.PK_TicketSizeID)

            {
                FK_TicketSizeID = L_TicketSize.PK_TicketSizeID;
            }

        }

        else if (!_settingFK)

        {

            FK_TicketSizeID = null;

        }

    }


    private void FixupL_TradingExperience(L_TradingExperience previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (L_TradingExperience != null)
        {
            if (!L_TradingExperience.DemoLeads.Contains(this))
            {
                L_TradingExperience.DemoLeads.Add(this);
            }

            if (FK_ExperienceID != L_TradingExperience.PK_ExperienceID)

            {
                FK_ExperienceID = L_TradingExperience.PK_ExperienceID;
            }

        }

        else if (!_settingFK)

        {

            FK_ExperienceID = null;

        }

    }


    private void FixupTradingPlatform(TradingPlatform previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (TradingPlatform != null)
        {
            if (!TradingPlatform.DemoLeads.Contains(this))
            {
                TradingPlatform.DemoLeads.Add(this);
            }

            if (FK_PlatformID != TradingPlatform.PK_TradingPlatformID)

            {
                FK_PlatformID = TradingPlatform.PK_TradingPlatformID;
            }

        }

        else if (!_settingFK)

        {

            FK_PlatformID = null;

        }

    }


    private void FixupOrganization(Organization previousValue)
    {

        if (previousValue != null && previousValue.DemoLeads.Contains(this))
        {
            previousValue.DemoLeads.Remove(this);
        }


        if (Organization != null)
        {
            if (!Organization.DemoLeads.Contains(this))
            {
                Organization.DemoLeads.Add(this);
            }

            if (FK_OrganizationID != Organization.PK_OrganizationID)

            {
                FK_OrganizationID = Organization.PK_OrganizationID;
            }

        }

    }


    private void FixupLeadNotes(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null)
        {
            foreach (LeadNote item in e.NewItems)
            {

                item.DemoLead = this;

            }
        }

        if (e.OldItems != null)
        {
            foreach (LeadNote item in e.OldItems)
            {

                if (ReferenceEquals(item.DemoLead, this))
                {
                    item.DemoLead = null;
                }

            }
        }
    }

        #endregion

    
}

}

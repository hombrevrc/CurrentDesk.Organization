
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

public partial class FundingSourceAcceptedCurrency
{
    #region Primitive Properties
    

    public virtual int PK_ID
    {

        get;
        set;

    }


    public virtual Nullable<int> FK_FundingSourceID
    {

        get { return _fK_FundingSourceID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_FundingSourceID != value)

            {

                if (FundingSource != null && FundingSource.PK_FundingSourceID != value)

                {

                    FundingSource = null;

                }

                _fK_FundingSourceID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_FundingSourceID;


    public virtual Nullable<int> FK_LCurrencyValueID
    {

        get { return _fK_LCurrencyValueID; }
        set
        {

            try
            {
                _settingFK = true;

            if (_fK_LCurrencyValueID != value)

            {

                if (L_CurrencyValue != null && L_CurrencyValue.PK_CurrencyValueID != value)

                {

                    L_CurrencyValue = null;

                }

                _fK_LCurrencyValueID = value;
            }

            }
            finally
            {
                _settingFK = false;
            }

        }

    }

    private Nullable<int> _fK_LCurrencyValueID;


    public virtual Nullable<bool> IsDeleted
    {

        get;
        set;

    }

        #endregion

        #region Navigation Properties
    


    public virtual L_CurrencyValue L_CurrencyValue
    {

        get { return _l_CurrencyValue; }
        set
        {
            if (!ReferenceEquals(_l_CurrencyValue, value))
            {
                var previousValue = _l_CurrencyValue;
                _l_CurrencyValue = value;
                FixupL_CurrencyValue(previousValue);
            }
        }
    }
    private L_CurrencyValue _l_CurrencyValue;



    public virtual FundingSource FundingSource
    {

        get { return _fundingSource; }
        set
        {
            if (!ReferenceEquals(_fundingSource, value))
            {
                var previousValue = _fundingSource;
                _fundingSource = value;
                FixupFundingSource(previousValue);
            }
        }
    }
    private FundingSource _fundingSource;

        #endregion

        #region Association Fixup
    

    private bool _settingFK = false;


    private void FixupL_CurrencyValue(L_CurrencyValue previousValue)
    {

        if (previousValue != null && previousValue.FundingSourceAcceptedCurrencies.Contains(this))
        {
            previousValue.FundingSourceAcceptedCurrencies.Remove(this);
        }


        if (L_CurrencyValue != null)
        {
            if (!L_CurrencyValue.FundingSourceAcceptedCurrencies.Contains(this))
            {
                L_CurrencyValue.FundingSourceAcceptedCurrencies.Add(this);
            }

            if (FK_LCurrencyValueID != L_CurrencyValue.PK_CurrencyValueID)

            {
                FK_LCurrencyValueID = L_CurrencyValue.PK_CurrencyValueID;
            }

        }

        else if (!_settingFK)

        {

            FK_LCurrencyValueID = null;

        }

    }


    private void FixupFundingSource(FundingSource previousValue)
    {

        if (previousValue != null && previousValue.FundingSourceAcceptedCurrencies.Contains(this))
        {
            previousValue.FundingSourceAcceptedCurrencies.Remove(this);
        }


        if (FundingSource != null)
        {
            if (!FundingSource.FundingSourceAcceptedCurrencies.Contains(this))
            {
                FundingSource.FundingSourceAcceptedCurrencies.Add(this);
            }

            if (FK_FundingSourceID != FundingSource.PK_FundingSourceID)

            {
                FK_FundingSourceID = FundingSource.PK_FundingSourceID;
            }

        }

        else if (!_settingFK)

        {

            FK_FundingSourceID = null;

        }

    }

        #endregion

    
}

}
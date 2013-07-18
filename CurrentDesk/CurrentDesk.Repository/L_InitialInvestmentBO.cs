/* **************************************************************
* File Name     :- L_InitialInvestmentBO.cs
* Author        :- Mukesh Nayak
* Copyright     :- Mindfire Solutions 
* Date          :- 25thd Dec 2012
* Modified Date :- 2nd Jan 2013
* Description   :- This file with all the buisness logic Related to L_InitialInvestment
****************************************************************/

#region Namespace Defined
using System.Collections.Generic;
using System.Linq;
using CurrentDesk.Models;
using CurrentDesk.Repository.Utility;
using System;
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template at 12/25/2012 2:56:23 PM
//	   and this file should not get overridden 
//
//     Add your own data access methods.
// </auto-generated>
//------------------------------------------------------------------------------ 
	
namespace CurrentDesk.Repository.CurrentDesk
{   
    /// <summary>
    /// Buisness Object for Initial Investment
    /// </summary>
	public class L_InitialInvestmentBO
	{
        /// <summary>
        /// This Function Will return all initialInvestment
        /// </summary>
        /// <returns></returns>
        public List<L_InitialInvestment> GetInitialInvestment()
        {
            try
            {
                var initialInvestmentKey = CacheKey.CDS_INITIALINVESTMENTS;
                var initialInvestmentList = new List<L_InitialInvestment>();

                if (StaticCache.Exist(initialInvestmentKey))
                {
                    initialInvestmentList = (List<L_InitialInvestment>)StaticCache.Get(initialInvestmentKey);
                }
                else
                {
                    using (var unitOfWork = new EFUnitOfWork())
                    {
                        var initialInvestmentRepo =
                            new L_InitialInvestmentRepository(new EFRepository<L_InitialInvestment>(), unitOfWork);

                        initialInvestmentList =  initialInvestmentRepo.All().ToList();

                        StaticCache.Max(initialInvestmentKey, initialInvestmentList);
                    }
                }

                return initialInvestmentList;
            }
            catch(Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
	}
}
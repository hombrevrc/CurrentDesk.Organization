using System;
using System.Linq;
using System.Collections.Generic;
using CurrentDesk.DAL;
using CurrentDesk.Models;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template at 14/5/2013 12:32:02 PM
//	   and this file should not get overridden 
//
//     Add your own data access methods.
// </auto-generated>
//------------------------------------------------------------------------------ 
	
namespace CurrentDesk.Repository.CurrentDesk
{   
	public class ConversionActivityBO
	{
		// Add your own data access methods here.  If you wish to
		// expose your public method to a WCF service, marked them with
		// the attribute [NCPublish], and another T4 template will generate your service contract

        /// <summary>
        /// This method inserts conversion activity details in db
        /// </summary>
        /// <param name="pkUsrActivityID">pkUsrActivityID</param>
        /// <param name="fromCurrID">fromCurrID</param>
        /// <param name="toCurrID">toCurrID</param>
        /// <param name="amount">amount</param>
        /// <param name="exchangeRate">exchangeRate</param>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="toAcc">toAcc</param>
        /// <param name="status">status</param>
        public void InsertConversionActivityDetails(int pkUsrActivityID, int fromCurrID, int toCurrID, double amount, double exchangeRate, string fromAcc, string toAcc, string status)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var convActRepo =
                        new ConversionActivityRepository(new EFRepository<ConversionActivity>(), unitOfWork);

                    ConversionActivity newConvAct = new ConversionActivity();
                    newConvAct.FK_UserActivityID = pkUsrActivityID;
                    newConvAct.FK_FromCurrencyID = fromCurrID;
                    newConvAct.FK_ToCurrencyID = toCurrID;
                    newConvAct.ConversionAmount = Convert.ToDecimal(amount);
                    newConvAct.ExchangeRate = exchangeRate;
                    newConvAct.FromAccount = fromAcc;
                    newConvAct.ToAccount = toAcc;
                    newConvAct.ConversionStatus = status;

                    convActRepo.Add(newConvAct);
                    convActRepo.Save();
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method inserts inter client conversion activity details in db
        /// </summary>
        /// <param name="pkUsrActivityId">pkUsrActivityId</param>
        /// <param name="fromUserId">fromUserId</param>
        /// <param name="toUserId">toUserId</param>
        /// <param name="fromCurrId">fromCurrId</param>
        /// <param name="toCurrId">toCurrId</param>
        /// <param name="amount">amount</param>
        /// <param name="exchangeRate">exchangeRate</param>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="toAcc">toAcc</param>
        /// <param name="status">status</param>
        public void InsertInterClientConversionActivityDetails(int pkUsrActivityId, int? fromUserId, int? toUserId, int fromCurrId, int toCurrId, double amount, double exchangeRate, string fromAcc, string toAcc, string status)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var convActRepo =
                        new ConversionActivityRepository(new EFRepository<ConversionActivity>(), unitOfWork);

                    ConversionActivity newConvAct = new ConversionActivity();
                    newConvAct.FK_UserActivityID = pkUsrActivityId;
                    newConvAct.FK_FromCurrencyID = fromCurrId;
                    newConvAct.FK_ToCurrencyID = toCurrId;
                    newConvAct.ConversionAmount = Convert.ToDecimal(amount);
                    newConvAct.ExchangeRate = exchangeRate;
                    newConvAct.FromAccount = fromAcc;
                    newConvAct.ToAccount = toAcc;
                    newConvAct.FK_FromUserID = fromUserId;
                    newConvAct.FK_ToUserID = toUserId;
                    newConvAct.ConversionStatus = status;

                    convActRepo.Add(newConvAct);
                    convActRepo.Save();
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
	}
}
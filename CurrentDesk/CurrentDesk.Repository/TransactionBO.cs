using System;
using System.Linq;
using System.Collections.Generic;
using CurrentDesk.DAL;
using CurrentDesk.Models;
using System.Data.Objects;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template at 27/2/2013 2:48:59 PM
//	   and this file should not get overridden 
//
//     Add your own data access methods.
// </auto-generated>
//------------------------------------------------------------------------------ 
	
namespace CurrentDesk.Repository.CurrentDesk
{   
	public class TransactionBO
	{
		// Add your own data access methods here.  If you wish to
		// expose your public method to a WCF service, marked them with
		// the attribute [NCPublish], and another T4 template will generate your service contract

        /// <summary>
        /// This method logs transaction details in Transactions table
        /// </summary>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="toAcc">toAcc</param>
        /// <param name="fromCurrID">fromCurrID</param>
        /// <param name="toCurrID">toCurrID</param>
        /// <param name="amount">amount</param>
        /// <param name="exchangeRate">exchangeRate</param>
        /// <param name="notes">notes</param>
        /// <returns>int</returns>
        public int InternalFundTransfer(string fromAcc, string toAcc, int fromCurrID, int toCurrID, double amount, double exchangeRate, string notes)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    ObjectSet<Transaction> transactionObjSet =
                    ((CurrentDeskClientsEntities)transactionRepo.Repository.UnitOfWork.Context).Transactions;

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = fromCurrID;
                    newTransaction.FK_ToCurrencyID = toCurrID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = fromAcc;
                    newTransaction.ToAccount = toAcc;
                    newTransaction.ExchangeRate = exchangeRate.ToString();
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Internal";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method logs transaction details in Transactions table
        /// </summary>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="toAcc">toAcc</param>
        /// <param name="fromCurrID">fromCurrID</param>
        /// <param name="toCurrID">toCurrID</param>
        /// <param name="amount">amount</param>
        /// <param name="exchangeRate">exchangeRate</param>
        /// <param name="notes">notes</param>
        /// <param name="organizationID">organizationID</param>
        /// <returns>int</returns>
        public int InternalFundTransfer(string fromAcc, string toAcc, int fromCurrID, int toCurrID, double amount, double exchangeRate, string notes, int organizationID)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    ObjectSet<Transaction> transactionObjSet =
                    ((CurrentDeskClientsEntities)transactionRepo.Repository.UnitOfWork.Context).Transactions;

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = fromCurrID;
                    newTransaction.FK_ToCurrencyID = toCurrID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = fromAcc;
                    newTransaction.ToAccount = toAcc;
                    newTransaction.ExchangeRate = exchangeRate.ToString();
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Internal";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;
                    newTransaction.FK_OrganizationID = organizationID;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method logs fee transaction details in Transactions table
        /// </summary>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="fromCurrID">fromCurrID</param>
        /// <param name="toCurrID">toCurrID</param>
        /// <param name="fee">fee</param>
        /// <returns>int</returns>
        public int InternalFeeTransaction(string fromAcc, int fromCurrID, int toCurrID, double fee)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    ObjectSet<Transaction> transactionObjSet =
                    ((CurrentDeskClientsEntities)transactionRepo.Repository.UnitOfWork.Context).Transactions;

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = fromCurrID;
                    newTransaction.FK_ToCurrencyID = toCurrID;
                    newTransaction.Amount = Convert.ToDecimal(fee);
                    newTransaction.FromAccount = fromAcc;
                    newTransaction.TransactionType = "Fee";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method logs fee transaction details in Transactions table
        /// </summary>
        /// <param name="fromAcc">fromAcc</param>
        /// <param name="fromCurrID">fromCurrID</param>
        /// <param name="toCurrID">toCurrID</param>
        /// <param name="fee">fee</param>
        /// <param name="organizationID">organizationID</param>
        /// <returns>int</returns>
        public int InternalFeeTransaction(string fromAcc, int fromCurrID, int toCurrID, double fee, int organizationID)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    ObjectSet<Transaction> transactionObjSet =
                    ((CurrentDeskClientsEntities)transactionRepo.Repository.UnitOfWork.Context).Transactions;

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = fromCurrID;
                    newTransaction.FK_ToCurrencyID = toCurrID;
                    newTransaction.Amount = Convert.ToDecimal(fee);
                    newTransaction.FromAccount = fromAcc;
                    newTransaction.TransactionType = "Fee";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;
                    newTransaction.FK_OrganizationID = organizationID;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method inserts deposit transaction in table
        /// </summary>
        /// <param name="accountNumber">accountNumber</param>
        /// <param name="currID">currID</param>
        /// <param name="amount">amount</param>
        /// <param name="notes">notes</param>
        /// <returns></returns>
        public int FundDeposit(string accountNumber, int currID, decimal amount, string notes)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = currID;
                    newTransaction.FK_ToCurrencyID = currID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = accountNumber;
                    newTransaction.ToAccount = accountNumber;
                    newTransaction.ExchangeRate = "1";
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Deposit";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method inserts deposit transaction in table
        /// </summary>
        /// <param name="accountNumber">accountNumber</param>
        /// <param name="currID">currID</param>
        /// <param name="amount">amount</param>
        /// <param name="notes">notes</param>
        /// <param name="organizationID">organizationID</param>
        /// <returns></returns>
        public int FundDeposit(string accountNumber, int currID, decimal amount, string notes, int organizationID)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = currID;
                    newTransaction.FK_ToCurrencyID = currID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = accountNumber;
                    newTransaction.ToAccount = accountNumber;
                    newTransaction.ExchangeRate = "1";
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Deposit";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;
                    newTransaction.FK_OrganizationID = organizationID;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method inserts withdraw record transaction in table
        /// </summary>
        /// <param name="accountNumber">accountNumber</param>
        /// <param name="currID">currID</param>
        /// <param name="amount">amount</param>
        /// <param name="notes">notes</param>
        /// <returns></returns>
        public int FundWithdraw(string accountNumber, int currID, decimal amount, string notes)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = currID;
                    newTransaction.FK_ToCurrencyID = currID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = accountNumber;
                    newTransaction.ToAccount = accountNumber;
                    newTransaction.ExchangeRate = "1";
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Withdraw";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method inserts withdraw record transaction in table
        /// </summary>
        /// <param name="accountNumber">accountNumber</param>
        /// <param name="currID">currID</param>
        /// <param name="amount">amount</param>
        /// <param name="notes">notes</param>
        /// <param name="organizationID">organizationID</param>
        /// <returns></returns>
        public int FundWithdraw(string accountNumber, int currID, decimal amount, string notes, int organizationID)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var transactionRepo =
                     new TransactionRepository(new EFRepository<Transaction>(), unitOfWork);

                    Transaction newTransaction = new Transaction();
                    newTransaction.FK_FromCurrencyID = currID;
                    newTransaction.FK_ToCurrencyID = currID;
                    newTransaction.Amount = Convert.ToDecimal(amount);
                    newTransaction.FromAccount = accountNumber;
                    newTransaction.ToAccount = accountNumber;
                    newTransaction.ExchangeRate = "1";
                    newTransaction.Notes = notes;
                    newTransaction.TransactionType = "Withdraw";
                    newTransaction.TransactionDateTime = DateTime.UtcNow;
                    newTransaction.FK_OrganizationID = organizationID;

                    transactionRepo.Add(newTransaction);
                    transactionRepo.Save();

                    return newTransaction.PK_TransactionID;
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
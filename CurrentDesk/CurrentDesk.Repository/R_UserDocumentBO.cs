using System;
using System.Linq;
using System.Collections.Generic;
using CurrentDesk.DAL;
using CurrentDesk.Models;
using System.Data.Objects;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template at 5/4/2013 3:40:41 PM
//	   and this file should not get overridden 
//
//     Add your own data access methods.
// </auto-generated>
//------------------------------------------------------------------------------ 
	
namespace CurrentDesk.Repository.CurrentDesk
{   
	public class R_UserDocumentBO
	{
		// Add your own data access methods here.  If you wish to
		// expose your public method to a WCF service, marked them with
		// the attribute [NCPublish], and another T4 template will generate your service contract

        /// <summary>
        /// This method returns all required documents for
        /// a particular account type
        /// </summary>
        /// <param name="accType">accType</param>
        /// <returns></returns>
        public List<R_UserDocument> GetAllDocumentsOfAccountType(int accType)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var userDocRepo =
                        new R_UserDocumentRepository(new EFRepository<R_UserDocument>(), unitOfWork);

                    ObjectSet<R_UserDocument> userDocObjSet =
                     ((CurrentDeskClientsEntities)userDocRepo.Repository.UnitOfWork.Context).R_UserDocument;

                    return userDocObjSet.Include("Document").Where(doc => doc.FK_AccountTypeID == accType && doc.IsBrokerForm == false).ToList();
                }
            }
            catch (Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        /// <summary>
        /// This method returns all required broker forms for
        /// a particular account type
        /// </summary>
        /// <param name="accType">accType</param>
        /// <returns></returns>
        public List<R_UserDocument> GetAllBrokerFormsOfAccountType(int accType)
        {
            try
            {
                using (var unitOfWork = new EFUnitOfWork())
                {
                    var userDocRepo =
                        new R_UserDocumentRepository(new EFRepository<R_UserDocument>(), unitOfWork);

                    ObjectSet<R_UserDocument> userDocObjSet =
                     ((CurrentDeskClientsEntities)userDocRepo.Repository.UnitOfWork.Context).R_UserDocument;

                    return userDocObjSet.Include("Document").Where(doc => doc.FK_AccountTypeID == accType && doc.IsBrokerForm == true).ToList();
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
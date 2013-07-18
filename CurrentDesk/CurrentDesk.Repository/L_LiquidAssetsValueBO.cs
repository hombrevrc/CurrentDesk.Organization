using System;
using System.Linq;
using System.Collections.Generic;
using CurrentDesk.Models;
using System.Data.Objects;
using CurrentDesk.DAL;
using CurrentDesk.Repository.Utility;

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
	public class L_LiquidAssetsValueBO
	{
        /// <summary>
        /// This Function Will return all the liquid assets values
        /// </summary>
        /// <returns></returns>
        public List<L_LiquidAssetsValue> GetLiquidAssetsValues()
        {
            try
            {
                var liquidAssetKey = CacheKey.CDS_LIQUIDASSETS;
                var liquidAssetList = new List<L_LiquidAssetsValue>();

                if (StaticCache.Exist(liquidAssetKey))
                {
                    liquidAssetList = (List<L_LiquidAssetsValue>)StaticCache.Get(liquidAssetKey);
                }
                else
                {
                    using (var unitOfWork = new EFUnitOfWork())
                    {
                        var lLiquidAssetsRepo =
                            new L_LiquidAssetsValueRepository(new EFRepository<L_LiquidAssetsValue>(), unitOfWork);

                        //Returning list of liquid assets values
                        liquidAssetList =  lLiquidAssetsRepo.All().ToList();

                        StaticCache.Max(liquidAssetKey, liquidAssetList);
                    }
                }

                return liquidAssetList;
            }
            catch(Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

        public string GetSelectedLiquidAsset(int liquidAssetID)
        {
            try
            {
                return GetLiquidAssetsValues().Where(liqAss => liqAss.PK_LiquidAssetID == liquidAssetID).
                        Select(liqAss => liqAss.LiquidAsset).SingleOrDefault();

                //using (var unitOfWork = new EFUnitOfWork())
                //{
                //    var lLiquidAssetsRepo =
                //        new L_LiquidAssetsValueRepository(new EFRepository<L_LiquidAssetsValue>(), unitOfWork);

                //    //Creating Liquid Asset Objeset to Query
                //    ObjectSet<L_LiquidAssetsValue> liquidAssetObjSet =
                //      ((CurrentDeskClientsEntities)lLiquidAssetsRepo.Repository.UnitOfWork.Context).L_LiquidAssetsValue;

                //    //Return the selected string
                //    return liquidAssetObjSet.Where(liqAss => liqAss.PK_LiquidAssetID == liquidAssetID).
                //        Select(liqAss => liqAss.LiquidAsset).SingleOrDefault();

                //}
            }
            catch(Exception ex)
            {
                CommonErrorLogger.CommonErrorLog(ex, System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }

		
	}
}
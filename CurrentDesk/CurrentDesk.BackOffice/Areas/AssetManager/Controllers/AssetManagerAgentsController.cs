﻿#region Header Information
/*****************************************************************
 * File Name     : IntroducingBrokerAgentsController.cs
 * Author        : Chinmoy Dey
 * Copyright     : Mindfire Solutions
 * Creation Date : 19th April 2013
 * Modified Date : 19th April 2013
 * Description   : This file contains AssetManagerAgents controller and related
 *                 actions to handle AM-Agents functionality
 * ***************************************************************/
#endregion

#region Namespace Used
using CurrentDesk.BackOffice.Areas.IntroducingBroker.Models.IBAgents;
using CurrentDesk.BackOffice.Custom;
using CurrentDesk.BackOffice.Security;
using CurrentDesk.Common;
using CurrentDesk.Logging;
using CurrentDesk.Models;
using CurrentDesk.Repository.CurrentDesk;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
#endregion

namespace CurrentDesk.BackOffice.Areas.AssetManager.Controllers
{
    /// <summary>
    /// This class represents AssetManagersAgents controller and contains
    /// related actions to handle AM-Agents functionality
    /// </summary>
    [AuthorizeRoles(AccountCode = Constants.K_ACCTCODE_AM), NoCache]
    public class AssetManagerAgentsController : Controller
    {
        #region Variables
        private L_CountryBO countryBO = new L_CountryBO();
        private L_RecievingBankBO receivingBankInfoBO = new L_RecievingBankBO();
        private AgentBO agentBO = new AgentBO();
        private IntroducingBrokerBO introducingBrokerBO = new IntroducingBrokerBO();
        private Client_AccountBO clientAccBO = new Client_AccountBO();
        #endregion

        /// <summary>
        /// This action returns Index view to show list
        /// of agents under a particular AM
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    ViewData["Country"] = new SelectList(countryBO.GetCountries(), "PK_CountryID", "CountryName");
                    ViewData["ReceivingBankInfo"] = new SelectList(receivingBankInfoBO.GetReceivingBankInfo(), "PK_RecievingBankID", "RecievingBankName");

                    return View();
                }
                else
                {
                    return RedirectToAction("Login", "Account", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action returns list of all agents under AM
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAgentsList()
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    //Get all agents under IB
                    LoginInformation loginInfo = SessionManagement.UserInfo;
                    var agentList = agentBO.GetAllAgentsOfIB(loginInfo.UserID);

                    List<AgentInfo> lstAgent = new List<AgentInfo>();

                    //Iterate through each agent
                    foreach (var agent in agentList)
                    {
                        AgentInfo agnt = new AgentInfo();
                        agnt.AgentID = String.Format("{0:000}", agent.AgentIntroducingBrokerCode);
                        agnt.FirstName = agent.FirstName;
                        agnt.LastName = agent.LastName;
                        agnt.Action = agent.IsActive == true ? "<a class='icon active' href='#' title='Disable Agent' onclick='disableAgent(" + agent.AgentIntroducingBrokerCode + ")'>Disable Agent</a>" : "<a class='icon inactive' href='#' title='Enable Agent' onclick='enableAgent(" + agent.AgentIntroducingBrokerCode + ")'>Enable Agent</a>";

                        lstAgent.Add(agnt);
                    }

                    return Json(new
                    {
                        total = 1,
                        page = 1,
                        records = lstAgent.Count,
                        rows = lstAgent
                    }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return RedirectToAction("Login", "Account", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action method adds new agent info into db
        /// </summary>
        /// <param name="model">model</param>
        /// <returns></returns>
        public ActionResult AddNewAgentInfo(Agent model)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    LoginInformation loginInfo = SessionManagement.UserInfo;
                    return Json(agentBO.AddNewAgent(model, loginInfo.UserID));
                }
                else
                {
                    return RedirectToAction("Login", "Account", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action enables an agent of AM
        /// </summary>
        /// <param name="agentID">agentID</param>
        /// <returns></returns>
        public ActionResult EnableAgent(int agentID)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    LoginInformation loginInfo = SessionManagement.UserInfo;

                    return Json(agentBO.EnableAgent(agentID, loginInfo.UserID));
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action disables an agent of AM
        /// </summary>
        /// <param name="agentID">agentID</param>
        /// <returns></returns>
        public ActionResult DisableAgent(int agentID)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    LoginInformation loginInfo = SessionManagement.UserInfo;

                    return Json(agentBO.DisableAgent(agentID, loginInfo.UserID));
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action returns AgentDetails view
        /// with required data passed as model
        /// </summary>
        /// <returns></returns>
        public ActionResult AgentDetails(int agentID)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    LoginInformation loginInfo = SessionManagement.UserInfo;

                    var agentDetail = agentBO.GetAgentDetails(agentID, loginInfo.UserID);
                    AgentDetailsModel model = new AgentDetailsModel();

                    if (agentDetail != null)
                    {
                        model.FirstName = agentDetail.FirstName;
                        model.LastName = agentDetail.LastName;
                        model.BirthDate = Convert.ToDateTime(agentDetail.BirthDate).ToString("dd/MM/yyyy");
                        model.PhoneNumber = agentDetail.PhoneNumber;
                        model.EmailAddress = agentDetail.EmailAddress;
                        model.PhoneID = agentDetail.PhoneID;
                        model.Password = agentDetail.Password;
                        model.AgentAddress = agentDetail.AgentAddress;
                        model.AgentCity = agentDetail.City;
                        model.AgentCountry = countryBO.GetSelectedCountry((int)agentDetail.FK_CountryID);
                        model.AgentPostalCode = agentDetail.PostalCode;
                        model.BankName = agentDetail.BankName;
                        model.AccountNumber = agentDetail.AccountNumber;
                        model.BicOrSwiftCode = agentDetail.BicOrSwiftCode;
                        model.ReceivingBankInfo = agentDetail.FK_ReceivingBankInfoID != null ? receivingBankInfoBO.GetSelectedRecievingBankInfo((int)agentDetail.FK_ReceivingBankInfoID) : null;
                        model.ReceivingBankInfoDetail = agentDetail.ReceivingBankInfo;
                        model.BankAddress = agentDetail.BankAddress;
                        model.BankCity = agentDetail.BankCity;
                        model.BankCountry = agentDetail.FK_BankCountryID != null ? countryBO.GetSelectedCountry((int)agentDetail.FK_BankCountryID) : null;
                        model.BankPostalCode = agentDetail.BankPostalCode;
                        model.AgentID = (int)agentDetail.AgentIntroducingBrokerCode;
                    }

                    //For referral links
                    ViewData["CustomizedLink"] = introducingBrokerBO.GetCustomizedLinkOfIB(loginInfo.UserID);
                    ViewData["AccountNumber"] = clientAccBO.GetAccountNumberOfUser(loginInfo.LogAccountType, loginInfo.UserID).Split('-')[2];

                    return View(model);
                }
                else
                {
                    return RedirectToAction("Login", "Account", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action returns AgentReferralFees view with referral
        /// fee data of agent passed as model
        /// </summary>
        /// <returns></returns>
        public ActionResult AgentReferralFees(int agentID, string agentName)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    AgentReferralFeesModel model = new AgentReferralFeesModel();

                    model.AgentID = agentID;
                    model.AgentName = agentName;

                    LoginInformation loginInfo = SessionManagement.UserInfo;

                    //Get agent fees details
                    var agentDetail = agentBO.GetAgentDetails(agentID, loginInfo.UserID);
                    if (agentDetail != null)
                    {
                        model.ManagementFee = agentDetail.ManagementFee != null ? (int)agentDetail.ManagementFee : 0;
                        model.PerformanceFee = agentDetail.PerformanceFee != null ? (int)agentDetail.PerformanceFee : 0;
                        model.RebatePercentage = agentDetail.RebatePercentage != null ? (int)agentDetail.RebatePercentage : 0;
                    }
                    else
                    {
                        return View("ErrorMessage");
                    }

                    return View(model);
                }
                else
                {
                    return RedirectToAction("Login", "Account", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

        /// <summary>
        /// This action updates agent referral fees in database
        /// </summary>
        /// <param name="agentID">agentID</param>
        /// <param name="performanceFee">performanceFee</param>
        /// <param name="managementFee">managementFee</param>
        /// <param name="rebatePercentage">rebatePercentage</param>
        /// <returns></returns>
        public ActionResult UpdateAgentReferralFees(int agentID, int performanceFee, int managementFee, int rebatePercentage)
        {
            try
            {
                if (SessionManagement.UserInfo != null)
                {
                    LoginInformation loginInfo = SessionManagement.UserInfo;

                    return Json(agentBO.UpdateAgentReferralFees(agentID, loginInfo.UserID, performanceFee, managementFee, rebatePercentage));
                }
                else
                {
                    return RedirectToAction("Login", "Action", new { Area = "" });
                }
            }
            catch (Exception ex)
            {
                CurrentDeskLog.Error(ex.Message, ex);
                return View("ErrorMessage");
            }
        }

    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using CurrentDesk.DAL;
using CurrentDesk.Models;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template at 15-07-13 10:25:32 AM
//	   and will be overwritten as soon as the template is executed

//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrentDesk.Repository.CurrentDesk
{   
	internal partial class R_Employee_IntroducingBrokerRepository
	{
		private IRepository<R_Employee_IntroducingBroker> _repository {get;set;}
		public IRepository<R_Employee_IntroducingBroker> Repository
		{
			get { return _repository; }
			set { _repository = value; }
		}
		
		public R_Employee_IntroducingBrokerRepository(IRepository<R_Employee_IntroducingBroker> repository, IUnitOfWork unitOfWork)
    	{
    		Repository = repository;
			Repository.UnitOfWork = unitOfWork;
    	}
		
		public IQueryable<R_Employee_IntroducingBroker> All()
		{
			return Repository.All();
		}

		public void Add(R_Employee_IntroducingBroker entity)
		{
			Repository.Add(entity);
		}
		
		public void Delete(R_Employee_IntroducingBroker entity)
		{
			Repository.Delete(entity);
		}

		public void Save()
		{
			Repository.Save();
		}
	}
}
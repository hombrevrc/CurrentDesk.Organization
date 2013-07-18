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
	internal partial class UserDocumentRepository
	{
		private IRepository<UserDocument> _repository {get;set;}
		public IRepository<UserDocument> Repository
		{
			get { return _repository; }
			set { _repository = value; }
		}
		
		public UserDocumentRepository(IRepository<UserDocument> repository, IUnitOfWork unitOfWork)
    	{
    		Repository = repository;
			Repository.UnitOfWork = unitOfWork;
    	}
		
		public IQueryable<UserDocument> All()
		{
			return Repository.All();
		}

		public void Add(UserDocument entity)
		{
			Repository.Add(entity);
		}
		
		public void Delete(UserDocument entity)
		{
			Repository.Delete(entity);
		}

		public void Save()
		{
			Repository.Save();
		}
	}
}
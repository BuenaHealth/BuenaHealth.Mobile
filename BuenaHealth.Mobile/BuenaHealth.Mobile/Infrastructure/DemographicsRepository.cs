﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Mobile.Interfaces;
using BuenaHealth.Mobile.Models;

namespace BuenaHealth.Mobile.Infrastructure
{
    public class DemographicsRepository : IRepository<Demographics>
    {
        public IQueryable<Demographics> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Demographics> Find(Expression<Func<Demographics, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Demographics Single(Expression<Func<Demographics, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Demographics SingleOrDefault(Expression<Func<Demographics, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Demographics First(Expression<Func<Demographics, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Demographics GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Add(Demographics entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Demographics entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Demographics entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Demographics entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Demographics> entities)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class NotesRepository : IRepository<Notes>
    {
        public IQueryable<Notes> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Notes> Find(Expression<Func<Notes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Notes Single(Expression<Func<Notes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Notes SingleOrDefault(Expression<Func<Notes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Notes First(Expression<Func<Notes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Notes GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Add(Notes entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notes entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Notes entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Notes entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Notes> entities)
        {
            throw new NotImplementedException();
        }
    }
}

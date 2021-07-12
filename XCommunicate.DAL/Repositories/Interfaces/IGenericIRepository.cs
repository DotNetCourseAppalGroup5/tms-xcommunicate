﻿using System;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Delete(int id);
        void Edit(TEntity entity);
    }
}

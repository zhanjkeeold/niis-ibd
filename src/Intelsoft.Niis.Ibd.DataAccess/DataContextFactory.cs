﻿using System;
using Intelsoft.Niis.Ibd.DataAccess.Interfaces;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Intelsoft.Niis.Ibd.DataAccess
{
    public class DataContextFactory : IDataContextFactory
    {
        private readonly DbContextOptions<DataContext> _dbContextOptions;

        public DataContextFactory([NotNull] DbContextOptions<DataContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions ?? throw new ArgumentNullException(nameof(dbContextOptions));
        }

        public IDataContext Create()
        {
            return new DataContext(_dbContextOptions);
        }
    }
}

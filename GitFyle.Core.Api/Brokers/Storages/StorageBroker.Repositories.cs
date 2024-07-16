﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GitFyle.Core.Api.Brokers.Storages
{
    internal partial class StorageBroker
    {
        public DbSet<Repository> Repositories { get; set; }
      
        public async ValueTask<Repository> InsertRepositoryAsync(Repository repository) =>
            await InsertAsync(repository);

        public async ValueTask<Repository> DeleteRepositoryAsync(Repository repository) =>
            await DeleteAsync(repository);
    }
}

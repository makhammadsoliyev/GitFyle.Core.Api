﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using GitFyle.Core.Api.Models.Foundations.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GitFyle.Core.Api.Brokers.Storages
{
    internal partial class StorageBroker
    {
        public DbSet<Repository> Repositories { get; set; }

        public async ValueTask<Repository> SelectRepositoryByIdAsync(Guid repositoryId) =>
            await SelectAsync<Repository>(repositoryId);    
    }
}


﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Business.EntityFrameworkCore
{
    public class BusinessMigrationDbContext : AbpDbContext<BusinessMigrationDbContext>    
    {
        public BusinessMigrationDbContext(
            DbContextOptions<BusinessMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBusiness();
        }
    }
}

using Common.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Models.Aggregates.UserRoleAggregate;

namespace OnlineShop.Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable(nameof(AppRole)).
                HasData(
                new AppRole()
                {
                    Id = DatabaseConstants.DefaultRoles.GodAdminId,
                    Name = DatabaseConstants.DefaultRoles.GodAdminName,
                    NormalizedName = DatabaseConstants.DefaultRoles.GodAdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.GodAdminConcurrencyStamp,
                },
                new AppRole()
                {
                    Id = DatabaseConstants.DefaultRoles.AdminId,
                    Name = DatabaseConstants.DefaultRoles.AdminName,
                    NormalizedName = DatabaseConstants.DefaultRoles.AdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.AdminConcurrencyStamp,
                },
        
                new AppRole()
                {
                    Id = DatabaseConstants.DefaultRoles.userNumOneId,
                    Name = DatabaseConstants.DefaultRoles.userNumOneName,
                    NormalizedName = DatabaseConstants.DefaultRoles.userNumOneNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.userNumOneConcurrencyStamp,
                }
                
            );

        }
    }
}

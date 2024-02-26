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
    public class UserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(p => new
            {
                p.UserId,
                p.RoleId,
            });
            builder.ToTable(nameof(AppUserRole))
                .HasData(
                    new AppUserRole() { UserId = DatabaseConstants.GodAdminUsers.IzadniaUserId, RoleId = DatabaseConstants.DefaultRoles.GodAdminId },
                    new AppUserRole() { UserId = DatabaseConstants.GodAdminUsers.BahmanyarUserId, RoleId = DatabaseConstants.DefaultRoles.GodAdminId }
            );

        }
    }
}

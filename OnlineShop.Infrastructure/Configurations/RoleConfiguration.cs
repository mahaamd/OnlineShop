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
    public class RoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(nameof(UserRole)).
                HasData(
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.GodAdminId,
                    Name = DatabaseConstants.DefaultRoles.GodAdminName,
                    NormalizedName = DatabaseConstants.DefaultRoles.GodAdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.GodAdminConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.AdminId,
                    Name = DatabaseConstants.DefaultRoles.AdminName,
                    NormalizedName = DatabaseConstants.DefaultRoles.AdminNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.AdminConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.SupportId,
                    Name = DatabaseConstants.DefaultRoles.SupportName,
                    NormalizedName = DatabaseConstants.DefaultRoles.SupportNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.SupportConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.SurgeonId,
                    Name = DatabaseConstants.DefaultRoles.SurgeonName,
                    NormalizedName = DatabaseConstants.DefaultRoles.SurgeonNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.SurgeonConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.GpId,
                    Name = DatabaseConstants.DefaultRoles.GpName,
                    NormalizedName = DatabaseConstants.DefaultRoles.GpNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.GpConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.GpAssistantId,
                    Name = DatabaseConstants.DefaultRoles.GpAssistantName,
                    NormalizedName = DatabaseConstants.DefaultRoles.GpAssistantNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.GpAssistantConcurrencyStamp,
                },
                new UserRole()
                {
                    Id = DatabaseConstants.DefaultRoles.PatientId,
                    Name = DatabaseConstants.DefaultRoles.PatientName,
                    NormalizedName = DatabaseConstants.DefaultRoles.PatientNormalizedName,
                    ConcurrencyStamp = DatabaseConstants.DefaultRoles.PatientConcurrencyStamp,
                }
            );

        }
    }
}

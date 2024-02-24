using Common.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.Models.Aggregates.AppUserAggregate;


namespace OnlineShop.Infrastructure.Configurations
{
    public class MbssUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            #region [- GodAdminUsers Data Entry -]
            builder.ToTable(nameof(AppUser))
                .HasData(
                new AppUser
                {
                    Id = DatabaseConstants.GodAdminUsers.IzadniaUserId,
                    FirstName = DatabaseConstants.GodAdminUsers.IzadniaFirstName,
                    LastName = DatabaseConstants.GodAdminUsers.IzadniaLastName,
                    NationalId = DatabaseConstants.GodAdminUsers.IzadniaNationalId,
                    NationalIdConfirmed = true,
                    UserName = DatabaseConstants.GodAdminUsers.IzadniaUserName,
                    PasswordHash = DatabaseConstants.GodAdminUsers.IzadniaPassword.GetHashCode().ToString(),
                    CellPhone = DatabaseConstants.GodAdminUsers.IzadniaCellphone
                },
                new AppUser
                {
                    Id = DatabaseConstants.GodAdminUsers.BahmanyarUserId,
                    FirstName = DatabaseConstants.GodAdminUsers.BahmanyarFirstName,
                    LastName = DatabaseConstants.GodAdminUsers.BahmanyarLastName,
                    NationalId = DatabaseConstants.GodAdminUsers.BahmanyarNationalId,
                    NationalIdConfirmed = true,
                    UserName = DatabaseConstants.GodAdminUsers.BahmanyarUserName,
                    PasswordHash = DatabaseConstants.GodAdminUsers.BahmanyarPassword.GetHashCode().ToString(),
                    CellPhone = DatabaseConstants.GodAdminUsers.BahmanyarCellphone
                }
                );
            #endregion

            builder.ToTable(table => table.HasCheckConstraint(
                DatabaseConstants.CheckConstraints.CellphoneOnlyNumericalTitle,
                DatabaseConstants.CheckConstraints.CellphoneOnlyNumerical));
            builder.ToTable(table => table.HasCheckConstraint(
                DatabaseConstants.CheckConstraints.NationalIdOnlyNumericalTitle,
                DatabaseConstants.CheckConstraints.NationalIdOnlyNumerical));

            builder.ToTable(table => table.HasCheckConstraint(
                DatabaseConstants.CheckConstraints.NationalIdCharacterNumberTitle,
                DatabaseConstants.CheckConstraints.NationalIdCharacterNumber));

            builder.Property(p => p.CellPhone).IsRequired();
            builder.HasIndex(p => p.CellPhone).IsUnique();

            builder.Property(p => p.NationalId).IsRequired();
            builder.HasIndex(p => p.NationalId).IsUnique();
            builder.Property(p => p.NationalIdConfirmed).HasDefaultValue(false);

            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.DateCreatedLatin).IsRequired().HasDefaultValue(System.DateTime.Now);
            builder.Property(p => p.IsModified).HasDefaultValue(false);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
        }
    }
}



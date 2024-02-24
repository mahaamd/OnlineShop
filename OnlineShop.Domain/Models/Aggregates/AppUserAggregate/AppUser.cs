using Microsoft.AspNetCore.Identity;
using OnlineShop.Domain.Models.FrameWorks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShop.Domain.Models.Aggregates.AppUserAggregate
{
    public class AppUser : IdentityUser, IActiveEntity, ICreatedEntity, IModifiedEntity, ISoftDeletedEntity, IDbSetEntity
    {
        //Fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public bool CellPhoneConfirmed { get; set; }
        public string NationalId { get; set; }
        public bool NationalIdConfirmed { get; set; }
        public byte[]? Picture { get; set; }
        public string? Location { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateSoftDeletedLatin { get; set; }
        public string? DateSoftDeletedPersian { get; set; }
        public DateTime DateCreatedLatin { get; set; }
        public string? DateCreatedPersian { get; set; }
        public bool IsModified { get; set; }
        public DateTime DateModifiedLatin { get; set; }
        public string? DateModifiedPersian { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

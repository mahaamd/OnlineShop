using Microsoft.AspNetCore.Identity;
using OnlineShop.Domain.Models.FrameWorks.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Models.Aggregates.UserRoleAggregate
{
    public class UserRole: IdentityRole, IDbSetEntity
    {
        //Fields


    }
}

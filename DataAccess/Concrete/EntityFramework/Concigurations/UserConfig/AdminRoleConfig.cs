using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Concigurations.UserConfig
{
    public class AdminRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var UserRoleId = "166299AA-9939-44BF-9D42-31FE8D83836C";
            var AdminRoleId = "F070D0B3-C7DE-474F-BA91-75CCDB5A3D39";

            var AdminUserId = "124B603F-CF74-4483-AA5C-FEB5C21B36E4";

            var AdminRole = new List<IdentityUserRole<string>>
            {
                new ()
                {
                    UserId = AdminUserId,
                    RoleId = UserRoleId
                },
                new()
                {
                    UserId = AdminUserId,
                    RoleId = AdminRoleId
                }
            };
            builder.HasData(AdminRole);
        }
    }
}

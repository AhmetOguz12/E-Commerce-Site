
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
    public class RolesConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var UserRoleId = "166299AA-9939-44BF-9D42-31FE8D83836C";
            var AdminRoleId = "F070D0B3-C7DE-474F-BA91-75CCDB5A3D39";

            var Roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = UserRoleId,
                    Name= "userRole",
                    NormalizedName = "userRole".ToUpper(),
                    ConcurrencyStamp = UserRoleId
                },
                new IdentityRole()
                {
                    Id  = AdminRoleId,
                    Name="adminRole",
                    NormalizedName = "adminRole".ToUpper(),
                    ConcurrencyStamp= AdminRoleId
                }
            };
            builder.HasData(Roles);
        }
    }
}

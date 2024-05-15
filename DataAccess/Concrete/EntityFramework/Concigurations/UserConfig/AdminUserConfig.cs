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
    public class AdminUserConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var AdminUserId = "124B603F-CF74-4483-AA5C-FEB5C21B36E4";

            var AdminUser = new IdentityUser
            {
                //İ Yİ VERİTABINDA GİRİŞ YAPARKEN KABULE TMİYOR BU YÜZDEN HATA DÖNÜYORK
                Id = AdminUserId,
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
            };
            AdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(AdminUser, "123456");
            builder.HasData(AdminUser);

        }
    }
}

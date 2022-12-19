using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template_DesignPattern.DAL.Entities;

namespace Template_DesignPattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CSTSJL1\\MSSQLSERVER2019;initial catalog=ZTemplateDesignDb;integrated security=true");
        }


    }
}

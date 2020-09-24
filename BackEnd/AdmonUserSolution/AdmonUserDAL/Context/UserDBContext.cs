using System;
using System.Collections.Generic;
using System.Text;
using AdmonUserEntities.Model;
using Microsoft.EntityFrameworkCore;

namespace AdmonUserDAL.Context
{
    public class UserDBContext : DbContext
    {
        public UserDBContext()
        {
        }

        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vtorres\\source\\repos\\AdmonUserSolution\\AdmonUserDAL\\Database\\AdminUserDB.mdf;Integrated Security=True");
            }
        }
    }
}

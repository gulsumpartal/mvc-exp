﻿using System.Data.Entity;
using System.Configuration;
using MvcExample.Domain.Department;
using MvcExample.Domain.User;

namespace MvcExample.Core
{
    public class DatabaseContext :DbContext
    {
        #region "Constructors"
        public DatabaseContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].Name)
        {

        }

        #endregion

        #region "Entities"

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }

        #endregion

    }
}

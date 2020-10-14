using HttpAPIs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpAPIs.Database
{
    public interface IAppContext
    {
        public DbSet<User> Users { get; set; }
    }
}

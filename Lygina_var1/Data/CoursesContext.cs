using Lygina_var1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lygina_var1.Data
{
    public class CoursesContext : DbContext
    {
        public CoursesContext(DbContextOptions<CoursesContext> options)
            : base(options)
        {
        }

        public DbSet<CoursesModel> Courses { get; set; }
    }
}

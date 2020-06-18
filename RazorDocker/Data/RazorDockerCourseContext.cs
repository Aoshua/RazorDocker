using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorDocker.Data
{
    public class RazorDockerCourseContext : DbContext
    {
        public RazorDockerCourseContext(DbContextOptions<RazorDockerCourseContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Course> Course { get; set; }
    }
}

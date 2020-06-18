using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorDocker.Data;
using RazorDocker.Models;

namespace RazorDocker.Pages
{
    public class CoursesModel : PageModel
    {
        private readonly RazorDockerCourseContext _context;

        public CoursesModel(RazorDockerCourseContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get;set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Course.ToListAsync();
            Debug.WriteLine("Woohoo!");
        }
    }
}

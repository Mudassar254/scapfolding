using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using scapfolding.Data;
using scapfolding.Models;

namespace scapfolding.Views.Students
{
    public class IndexModel : PageModel
    {
        private readonly scapfolding.Data.scapfoldingContext _context;

        public IndexModel(scapfolding.Data.scapfoldingContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CalendarDBContext:DbContext
    {
        public CalendarDBContext()
        {
            
        }
        public CalendarDBContext(DbContextOptions<CalendarDBContext> dbContextOptions) : base(dbContextOptions) 
        { }

        public DbSet<CalendarDay> calendarDays { get; set; }
     
    }
    
}

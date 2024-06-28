using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CalendarDay : ICalendarDayRepository
    {
        private readonly CalendarDBContext _calendarDbContext;
        public CalendarDay(CalendarDBContext calendarDbContext)
        {
            _calendarDbContext=calendarDbContext;
        }
        public async Task<List<Domain.Entities.CalendarDay>> GetAllAsync()
        {
            return await _calendarDbContext.calendarDays.ToListAsync();
        }

        public async Task<Domain.Entities.CalendarDay> GetByIdAsync(int id)
        {
            return await _calendarDbContext.calendarDays.AsNoTracking()
              .FirstOrDefaultAsync(b => b.KeyId == id);
        }
    }
}

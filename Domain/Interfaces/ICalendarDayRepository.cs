using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICalendarDayRepository
    {
        Task<List<CalendarDay>> GetAllAsync();
        Task<CalendarDay> GetByIdAsync(int id);
    }
}

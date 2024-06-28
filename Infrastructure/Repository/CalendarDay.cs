using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;

namespace Infrastructure.Repository
{
    public class CalendarDay : ICalendarDayRepository
    {
        public Task<List<Domain.Entities.CalendarDay>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.CalendarDay> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

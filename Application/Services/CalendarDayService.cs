using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CalendarDayService : ICalendarDayServices
    {
        private readonly ICalendarDayRepository _CalendarDayRepository;
        public CalendarDayService(ICalendarDayRepository calendarDayRepository)
        {
            _CalendarDayRepository = calendarDayRepository; 
        }
        public async Task<List<CalendarDay>> GetAllAsync()
        {
            return await _CalendarDayRepository.GetAllAsync();
        }

        public async Task<CalendarDay> GetByIdAsync(int id)
        {
            return await _CalendarDayRepository.GetByIdAsync(id);
        }
    }
}

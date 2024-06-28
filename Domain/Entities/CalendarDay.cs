using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CalendarDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int KeyId { get; set; }
        public string CalendarCode {  get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public string color {  get; set; }
    }
}

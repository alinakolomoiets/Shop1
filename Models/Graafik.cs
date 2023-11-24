using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Graafik
    {
        public int Id { get; set; }
        public DayOfWeek Paev { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public DateTime AvatudAeg { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public DateTime SuletudAeg { get; set; }
        public int PoodId { get; set; }
    }
}
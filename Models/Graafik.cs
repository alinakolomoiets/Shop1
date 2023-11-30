using Shop.Models;

public class Graafik
{
    public int Id { get; set; }
    public DayOfWeek Paev { get; set; }
    public DateTime AvatudAeg { get; set; }
    public DateTime SuletudAeg { get; set; }
    public int PoodId { get; set; }  
    public Pood Pood { get; set; }
    public string PoodName => Pood?.PoodName;
}

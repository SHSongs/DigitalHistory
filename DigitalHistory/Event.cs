namespace DigitalHistory
{
  public class Event
  {
    public string Name { get; set; }
    public string Date { get; set; }
    public string Image { get; set; }

    public Event(string name, string date, string image)
    {
      Name = name;
      Date = date;
      Image = image;
    }
  }
}

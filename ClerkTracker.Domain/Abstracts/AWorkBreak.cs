namespace ClerkTracker.Domain.Abstracts
{
  public class AWorkBreak
  {
    public string Name {get; set;} = "";
    public string StartTime {get; set;}//<@t>
    public string EndTime {get; set;}//<@t>
    public int Duration {get; protected set;}//<@t>

    // [III]. FOOT
    public override string ToString()
    {
      return $"{Name}: {StartTime}-{EndTime}  {Duration}";
    }
  }// /cla 'AWorkBreak'
}// /ns '..Abstracts'
//[EoF]
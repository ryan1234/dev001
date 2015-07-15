public class SpiritualPerson 
{
	public IGod God { get; set; }
	public bool IsAlive { get; set; }
	
	public SpiritualPerson(bool isAlive)
	{
		this.God = new BiblicalGod();
		this.IsAlive = isAlive;
	}
	
	public string Think() 
	{
		return God.thoughtOk(new Thought()) ? "peaceful" : "uneasy"; 
	}
	
	public string Act()
	{
		return God.actionOk(new Action()) ? "peaceful" : "uneasy";
	}
}
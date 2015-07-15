public class Thought 
{
	private string[] _thoughts = new string[] 
	{
		"Anger",
		"Jealousy",
		"Rebellion",
		"Patience",
		"SelfControl",
		"Kindness"
	};
	
	public string ThoughtType { get; set; }
	
	public Thought() 
	{
		this.ThoughtType = _thoughts[Utils.Random.Next(0, 6)];
	}
}
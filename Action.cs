public class Action
{
	private string[] _actions = new string[] 
	{
		"Lie",
		"Cheat",
		"Steal",
		"Bless",
		"Pray", 
		"Worship"
	};
	
	public string ActionType { get; set; } 
	
	public Action()
	{
		this.ActionType = _actions[Utils.Random.Next(0, 6)];
	}
}
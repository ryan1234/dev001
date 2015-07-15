using System.Linq;

public sealed class BiblicalGod : IGod
{
	private string[] _sinfulActions = new string[] { "Lie", "Cheat", "Steal" };
	private string[] _sinfulThoughts = new string[] { "Anger", "Jealousy", "Rebellion" };
	
	public bool actionOk(Action action)
	{
		return _sinfulActions.Contains(action.ActionType);
	}
	
	public bool thoughtOk(Thought thought)
	{
		return _sinfulThoughts.Contains(thought.ThoughtType);
	}
}
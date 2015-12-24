using System.Collections.Generic;

public class Election
{
	public string id { get; set; }
	public List<Vote> votes { get; set; }
	
	/*Vote is representing a class,the constructed votes is a list of Vote*/ 
	public Election()
	{
		votes = new List<Vote>();
	}
}

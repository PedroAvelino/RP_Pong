using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{
	public Player[] players;
	public Puck puck;
	
    void Start()
    {
		for ( int i = 0; i < players.Length; i++ )
		{
			// Direct access to variables is ok for a prototype. Development code should have better scoping
			players[i].matchIndex = i;
		}

		// Magic numbers are ok for prototype
		// For development, it'd be better to store it in a variable
		puck.playerToFollow = players[0];
		players[0].TakePuck( puck );
	}
	
    void Update()
    {
        
    }

	public void OnGoalScored( int matchIndexScorer, int matchIndexScored )
	{
		puck.playerToFollow = players[matchIndexScored];
		players[matchIndexScored].TakePuck( puck );
	}

}

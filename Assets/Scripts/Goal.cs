using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public Player opposingPlayer;
	public Player goalOwner;

	public MatchManager matchManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter( Collider other )
	{
		if ( other.name == "Puck" )
		{
			opposingPlayer.ScoreGoal();
			matchManager.OnGoalScored( opposingPlayer.matchIndex, goalOwner.matchIndex );
		}
	}
}

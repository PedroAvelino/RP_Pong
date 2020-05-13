using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// Not all of these variables needed to be public, but for a prototype it's fine
	public int matchIndex;
	public Transform launchPos;
	public float movSpeed;
	public int score;
	public string axis;
	public bool shootsLeftToRight = false;
	public Puck puck;
	
    void Start()
    {
        
    }
	
    void Update()
    {
		float movement = ( Input.GetAxis( axis ) * movSpeed );
		GetComponent<Rigidbody>().velocity = new Vector3( 0, 0, movement );

		if ( Input.GetButtonDown( "Shoot" ) && puck != null )
		{
			puck.Launch( shootsLeftToRight );
			puck = null;
		}
    }

	public void ScoreGoal()
	{
		score += 1;
	}

	public void TakePuck( Puck puck )
	{
		this.puck = puck;
	}
}

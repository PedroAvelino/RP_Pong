using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
	// Not all of these variables needed to be public, but for a prototype it's fine
	public Player playerToFollow;
	public Vector3 startVel;
	public Vector3 currVel;
	public float bounceForce = 30;
	
	void Start()
    {
    }
	
    void Update()
    {
		if ( playerToFollow != null )
		{
			transform.position = playerToFollow.launchPos.position;
		}
		else
		{
			GetComponent<Rigidbody>().velocity = currVel;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if ( collision.gameObject.tag == "player" )
		{
			currVel.x = currVel.x * -1f;
			currVel.z = currVel.z * -1f;
		}
		else if ( collision.gameObject.tag == "wall" )
		{
			currVel.z = currVel.z * -1f;
		}
	}

	public void Launch( bool leftToRight )
	{
		currVel = leftToRight ? startVel : startVel * -1f;
		playerToFollow = null;
	}
}

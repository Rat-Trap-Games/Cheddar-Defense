using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {

	public GameObject player;       //Public variable to store a reference to the player game object

	public Vector3 offset;   //Private variable to store the offset distance between the player and camera

	// LateUpdate is called after Update each frame

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = player.transform.position + offset;
	}
}
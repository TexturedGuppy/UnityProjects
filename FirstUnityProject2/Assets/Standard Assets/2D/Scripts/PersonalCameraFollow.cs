using UnityEngine;
using System.Collections;

public class PersonalCameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Player Created");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawLine(Vector3.zero, Vector3.one);
        //transform.position.x += .1f; //Unity rule will not allow this
        //transform.position += new Vector3(.1f, 0, 0);
        //Input.GetKeyDown is for when it is first pressed, won't operate continuously
        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0.1f, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(-0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, -.1f, 0);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(0.1f, 0, 0);
        //}

        Debug.DrawLine(transform.position, transform.position + transform.right * 10);
        Debug.DrawLine(Vector3.zero, transform.right * 10);


        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 5f));
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -5f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(.1f, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(.1f, 0, 0));
        }

        //if(Input.GetMouseButton(0))
        //{
        //    Instantiate(bullet, transform.position, transform.rotation);
        //}
    }
}

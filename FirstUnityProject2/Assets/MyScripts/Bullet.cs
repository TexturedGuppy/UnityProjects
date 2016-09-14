using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public int lifeTime = 2;
    float spawnTime;
    public float bulletSpeed = .1f;
    public int damage = 20;

	// Use this for initialization
	void Start () {
        spawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(Time.deltaTime * bulletSpeed, 0, .1f));//always use time.deltaTime * speed to make up for computers with bad framerate.
	if(Time.time - spawnTime>lifeTime)
        {

            //Destroy(this);//This points to the component, Not the gameobject its attached to
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Danger Will Robinson");
        if (collision.gameObject.tag == "Hittable")
        {
            //Or
            //Asteroid asteroid = collision.gameObject.GetComponent<Asteroid>();
            //asteroid.TakeDamage(damage);
            collision.gameObject.SendMessage("TakeDamage", damage);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Triggered");
    }
    
    
}

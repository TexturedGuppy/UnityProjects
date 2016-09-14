using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
    public int pointValue = 10;
    int health;
    Vector2 direction;
    float rotation;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        health = 100;
        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        rotation = Random.Range(-.3f, .3f);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(direction*1000);
        
	}

	
	// Update is called once per frame
	void Update () {
        //transform.position += Time.deltaTime * direction;
        //transform.Rotate(Vector3.forward, rotation);
	}

    void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {

            Destroy(gameObject);
            Game gameScript = FindObjectOfType<Game>();
            gameScript.DecrementAsteroids();
            gameScript.AddScore(pointValue);

        }
    }
    
}

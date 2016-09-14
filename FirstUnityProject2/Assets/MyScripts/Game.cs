using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public int maxAsteroids = 5;
    public GameObject asteroidPrefab;
    public Text scoreText;
    
    private int numAsteroids = 0;
    private float score = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (numAsteroids < maxAsteroids)
        {
            Instantiate(asteroidPrefab, Vector3.zero, Quaternion.identity);
            numAsteroids++;
        }
	}

    public void DecrementAsteroids()
    {
        numAsteroids--;
    }
    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
        Debug.Log(score);
    }
}


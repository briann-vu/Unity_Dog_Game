using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCollision : MonoBehaviour
{
    /*
Script checks if game is over or not based on win/loss. Player wins if they 
eat 10 steaks in 30 sec without eating a cookie, they lose otherwise. Food items
are destroyed upon colliding with dog.
*/
    public GameObject bone;
    public bool gameOver;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 10 && Time.time <= 30f) {
            // stop game
            Debug.Log("Success!");
            gameOver = true;
        }
        else if ((Time.time > 30f && count != 10) || gameOver) {
            // stop game
            Debug.Log("Fail!");
            gameOver = true;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Steak") {
            Destroy(other.gameObject); // fix cookie destroy time  
            count++;
            float randomY = Random.Range(-60, 60);
            Instantiate(bone, new Vector3(transform.position.x, 0f, 0f), Quaternion.Euler(0f,randomY,0f));
        }
        if (other.tag == "Cookie") {
            Destroy(other.gameObject); 
            gameOver = true;
        }
    }
}

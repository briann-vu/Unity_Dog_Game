using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
/*
Script spawns steak and cookie prefabs on topo of dog to fall, y value is fixed at 5, z = 0,
and x is random. spawning will stop based on if the gameOver condition is true,
*/
{

    public GameObject steak;
    public GameObject cookie;
    public GameObject dog;
    private DogCollision dogCol;
    public float steakTimer;
    public float cookieTimer;

    // Start is called before the first frame update
    void Start()
    {
        dogCol = dog.GetComponent<DogCollision>();
        steakTimer = 2f;
        cookieTimer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (dogCol.gameOver == false) {
            
        
            steakTimer -= Time.deltaTime;
            cookieTimer -= Time.deltaTime;
            if (steakTimer <= 0f) {
                float randomX = Random.Range(-4, 4);
                Instantiate(steak, new Vector3(randomX, 5f, 0f), Quaternion.Euler(90f,0f,0f)); // fix rotation of steak and cookie
                steakTimer = 2f;
            }
            if (cookieTimer <= 0) {
                float randomX = Random.Range(-4, 4);
                Instantiate(cookie, new Vector3(randomX, 5f, 0f), Quaternion.Euler(90f,0f,0f));
                cookieTimer = 3f;
            }
        } 
    }
}

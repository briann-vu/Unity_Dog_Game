using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogControls : MonoBehaviour
/*
This script moves the dog on the x axis once the a or d keys are pressed.
If the dog reaches -4 or 4 on the x axis, it cannot move any further.
*/
{

    public GameObject dog;
    float speed = 6f;
    float leftBound = 4f;
    float rightBound = -4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dog.transform.position.x >= leftBound) {
            dog.transform.position = new Vector3(leftBound, dog.transform.position.y, dog.transform.position.z);
        }
        if (dog.transform.position.x <= rightBound) {
            dog.transform.position = new Vector3(rightBound, dog.transform.position.y, dog.transform.position.z);
        }
        if (Input.GetKey("a")) {
            dog.transform.Translate(speed * Time.deltaTime, 0f , 0f);
        }
        if (Input.GetKey("d")) {
            dog.transform.Translate(-1 * speed * Time.deltaTime, 0f , 0f);
        }
    }
}

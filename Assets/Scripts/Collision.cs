using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /*
Script provides collision reaction between floor zone and items that drop. Items that
drop out of the sky will despawn upon collision.
*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Steak" || other.tag == "Cookie") {
            Destroy(other.gameObject, .4f); // fix cookie destroy time
        }
    }

    
}

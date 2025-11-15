using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform: MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            collisionInfo.collider.transform.parent = transform;
        }
    void OnCollisionExit2D(Collision2D collisionInfo)
    {

        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            collisionInfo.collider.transform.parent = transform;
        }
    }
    }
    
}

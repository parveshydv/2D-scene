using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tween : MonoBehaviour
{
    public Vector3 moveAmount = Vector3.zero;
    public float smoothTime = 0.2f;
    private Vector3 startingPosition;
    private Vector3 targetPosition;

    // current velocity (start at zero)
    private Vector3 velocity = Vector3.zero;
    private bool movingTowardTarget = true;
    public bool cyclic = false;
    // Start is called before the first frame update
    void Start()
    {
       startingPosition = transform.position;
       targetPosition = transform.position + moveAmount; 
    }

    void Update()
    {
      if (movingTowardTarget)
    {
        transform.position = Vector3.SmoothDamp(transform.position,targetPosition,ref velocity,smoothTime);
        if ((transform.position - targetPosition).sqrMagnitude < 0.1f)
        {
            movingTowardTarget = false;
        }
    }
      else if (cyclic)
    {
        transform.position = Vector3.SmoothDamp(transform.position,startingPosition,ref velocity,smoothTime);
        if ((transform.position - startingPosition).sqrMagnitude < 0.1f)
        {
            movingTowardTarget = true;
        }
    }
        
    }
}

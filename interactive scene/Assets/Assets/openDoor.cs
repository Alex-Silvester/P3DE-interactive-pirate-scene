using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    [SerializeField] GameObject hinge;
    [SerializeField] doorTrigger trigger;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger.Open() && transform.rotation.y < -0.6f)
        {
            transform.RotateAround(hinge.transform.position, Vector3.up, speed);
        }
        else if(!trigger.Open() && transform.rotation.y > -0.99)
        {
            transform.RotateAround(hinge.transform.position, Vector3.up, -speed);
        }
    }
}

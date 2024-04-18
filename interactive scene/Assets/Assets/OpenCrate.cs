using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCra : MonoBehaviour
{
    [SerializeField] CrateTrigger trigger;
    bool open;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger.closeEnough() && Input.GetKeyDown(KeyCode.E) && !open)
        {
            transform.position += new Vector3(0, 0, -1);
            open = true;
        }
    }
}

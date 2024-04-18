using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateTrigger : MonoBehaviour
{
    bool close_enough;

    // Start is called before the first frame update
    void Start()
    {
        close_enough = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        close_enough = !close_enough;
    }

    private void OnTriggerExit(Collider other)
    {
        close_enough = !close_enough;
    }

    public bool closeEnough()
    {
        return close_enough;
    }
}

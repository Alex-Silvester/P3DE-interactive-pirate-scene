using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateTrigger : MonoBehaviour
{
    bool close_enough;
    [SerializeField] ShowText text;

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
        text.show();
    }

    private void OnTriggerExit(Collider other)
    {
        close_enough = !close_enough;
        text.show();
    }

    public bool closeEnough()
    {
        return close_enough;
    }
}

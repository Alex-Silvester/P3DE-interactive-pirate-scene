using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateTrigger : MonoBehaviour
{
    bool close_enough;
    bool open;
    [SerializeField] ShowText text;

    private void Awake()
    {
        close_enough = true;
        open = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        text.hide();
    }

    // Update is called once per frame
    void Update()
    {
        text.hide();
        if (close_enough && !open)
        {
            text.show();
        }

        if(close_enough && Input.GetKeyDown(KeyCode.E))
        {
            open = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        close_enough = !close_enough;
    }

    private void OnTriggerExit(Collider other)
    {
        close_enough = false;
    }

    public bool closeEnough()
    {
        return close_enough;
    }
}

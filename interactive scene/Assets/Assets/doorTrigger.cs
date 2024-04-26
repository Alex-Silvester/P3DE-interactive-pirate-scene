using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    bool entered = true;
    [SerializeField] AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        audio_source.Play();
        entered = !entered;
    }

    private void OnTriggerExit(Collider other)
    {
        entered = !entered;
    }

    public bool Open()
    {
        return entered;
    }
}

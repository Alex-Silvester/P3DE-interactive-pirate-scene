using EazyCamera.Legacy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    bool entered = false;
    [SerializeField] Camera player_camera;
    [SerializeField] Camera hut_camera;
    // Start is called before the first frame update
    void Start()
    {
        player_camera.enabled = true;
        hut_camera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        entered = !entered;

        player_camera.enabled = !player_camera.enabled;
        hut_camera.enabled = !hut_camera.enabled;

        Debug.Log(entered ? "enter":"exit");
    }
}

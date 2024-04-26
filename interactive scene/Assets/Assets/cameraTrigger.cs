using EazyCamera.Legacy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTrigger : MonoBehaviour
{
    [SerializeField] Camera player_camera;
    [SerializeField] Camera hut_camera;
    [SerializeField] EazyCamera.EazyCam camera_control;
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
        player_camera.enabled = !player_camera.enabled;
        hut_camera.enabled = !hut_camera.enabled;

        if(!player_camera.enabled)
        {
            camera_control.setRotationSpeed(0);
        }
        else if(player_camera.enabled)
        {
            camera_control.setRotationSpeed(112);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    [SerializeField] GameObject cannonBall;
    [SerializeField] CannonTrigger cannon;
    [SerializeField] AudioSource audio_source;
    bool fired;

    Vector3 ballInitialPos;

    float gravity = 0.1f;
    float Yvel = 0;

    [SerializeField] ShowText fire_text;
    [SerializeField] ShowText reload_text;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //audio_source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

        fired = false;
        ballInitialPos = cannonBall.transform.position;

        fire_text.hide();
        reload_text.hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (cannon.Interactable())
        {
            if(!fired)
            {
                fire_text.show();
                reload_text.hide();
            }
            if(fired)
            {
                fire_text.hide();
                if (cannonBall.transform.position.y < 0)
                {
                    reload_text.show();
                }
            }

            if (Input.GetMouseButtonDown(0) && !fired)
            {
                anim.SetBool("Fire", true);
                audio_source.Play();
                fired = true;
            }
            if (Input.GetMouseButtonDown(1) && cannonBall.transform.position.y < 0 && fired)
            {
                fired = false;
                cannonBall.transform.position = ballInitialPos;
                Yvel = 0;
            }
        }

        if(!cannon.Interactable())
        {
            fire_text.hide();
            reload_text.hide();
        }

        if (fired)
        {
            Yvel -= gravity;
            cannonBall.transform.position += new Vector3(50 * Time.deltaTime, Yvel * Time.deltaTime, 0);
        }
    }
}

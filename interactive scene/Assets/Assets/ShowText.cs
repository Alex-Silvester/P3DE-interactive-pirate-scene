using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    bool shown;
    // Start is called before the first frame update
    void Start()
    {
        shown = true;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        shown = true;
        gameObject.SetActive(shown);
    }

    public void hide()
    {
        shown = false;
        gameObject.SetActive(shown);
    }
}

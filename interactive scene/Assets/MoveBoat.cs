using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    float time = 0.0f, starting_y_pos, starting_x_pos, starting_z_pos;
    [SerializeField] float amplitude = 0.1f;
    [SerializeField] float frequency = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        starting_y_pos = transform.position.y;
        starting_x_pos = transform.position.x;
        starting_z_pos = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        transform.position = new Vector3(starting_x_pos, starting_y_pos + f(time*frequency)*amplitude, starting_z_pos);
    }

    float f(float x)
    {
        return Mathf.Sin(x) - Mathf.Pow(Mathf.Sin(x), 2) + Mathf.Cos(x/2);
    }
}

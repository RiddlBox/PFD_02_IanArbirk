using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float distance = 22 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += distance;
        }
        transform.position = pos;
       
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= distance;
        }
        transform.position = pos;

    }
}

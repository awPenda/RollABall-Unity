using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotating_speed = 1;
    public float mvmt_speed = 1;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Pickup"))
        {
            transform.Rotate(new Vector3(15, 30, 45) * (Time.deltaTime * rotating_speed));
        }
        /*
        else {
            Vector3 mvmt = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            transform.position += mvmt * mvmt_speed;
        }
    */
    }

}

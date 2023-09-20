using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public float speed = 25;
    private float previousTime;
    public float fallTime = 0.8f;
    public float fallSpeed = 25;


    // Update is called once per frame
    void Update()
    {

        // Input.GetKeyDown
        // Input.GetKeyUp
        // Input.GetKey


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        float tempTime = fallTime;
        if ((Time.time - previousTime) > fallTime)
        {
            transform.Translate(Vector3.down * Time.deltaTime * fallSpeed);
            previousTime = Time.time;
        }

    }
}
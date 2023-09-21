using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public float speed = 25;
    private float previousTime;
    public float fallTime = 0.8f;
    public float fallSpeed = 25;
    public static float width;
    public static float height;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        float tempTime = fallTime;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tempTime /= 10;                   //variable /= 45
        }
        if ((Time.time - previousTime) > tempTime)
        {
            transform.Translate(Vector3.down * Time.deltaTime * fallSpeed);
            previousTime = Time.time;
        }


        
    }
    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.x);
            int y = Mathf.RoundToInt(child.transform.y);
        }
    }


}

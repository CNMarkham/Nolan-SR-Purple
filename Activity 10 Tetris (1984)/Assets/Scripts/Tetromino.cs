using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public float speed = 25;
    private float previousTime;
    public float fallTime = 0.8f;
    public float fallSpeed = 25;
    public static float width = 10;
    public static float height = 20;
    public Vector3 rotationPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 convertedPoint = transform.TransformPoint(rotationPoint);
            transform.RotateAround(convertedPoint, Vector3.forward, 90);
            if (!ValidMove())
            {

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left);

                if (!ValidMove())
                {
                    transform.Translate(Vector3.right);
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right);
                if (!ValidMove())
                {
                    transform.Translate(Vector3.left);
                }
            }
            float tempTime = fallTime;
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                tempTime /= 10;
            }
            if ((Time.time - previousTime) > tempTime)
            {
                transform.Translate(Vector3.down);
                if (!ValidMove())
                {
                    transform.Translate(Vector3.up);
                }
                previousTime = Time.time;
            }
        }
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
            if (y < 0 || x < 0)
            {
                return false;
            }

            if (x >= width || y >= height)
            {
                return false;
            }

        }
        return true;
    }
}

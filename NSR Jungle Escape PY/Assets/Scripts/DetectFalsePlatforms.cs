using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    void Update()
    {
        bool hit = Physics.Raycast(transform.position, transform.forward, 3, 1 << 8);

        if (hit)
        {
            Debug.LogWarning("Be Careful");
        }
        if (hit == false)
        {
            Debug.Log("All Clear");
        }

    }
}                   
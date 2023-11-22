using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOff : MonoBehaviour
{
    public GameObject[] laserList;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject redthing in laserList)
            {
                redthing.SetActive(false);
            } 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

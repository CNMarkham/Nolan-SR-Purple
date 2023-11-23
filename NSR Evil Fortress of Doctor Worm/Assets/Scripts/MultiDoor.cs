using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDoor : MonoBehaviour
{
    public GameObject[] doorList;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            foreach (GameObject DoorKaboom in doorList)
            {
                DoorKaboom.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()     
    {
   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("PacMan"))
        {
            Eat();
        }
    }
    protected virtual void Eat()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ploinko : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;

    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
}


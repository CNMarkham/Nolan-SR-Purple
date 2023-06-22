using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
<<<<<<< HEAD:Pong/Assets/Player 1.cs
    // Start is called before the first frame update
    void Start()
    {
        
=======
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * 3;
>>>>>>> 252a61d7ed4c5a6792556f5bd095f4c2f3d60826:Breakout/Assets/Ball.cs
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Pong/Assets/Player 1.cs
        
=======
        if (transform.position.y < player.transform.position.y)
        {
            Time.timeScale = 0;
        }
>>>>>>> 252a61d7ed4c5a6792556f5bd095f4c2f3d60826:Breakout/Assets/Ball.cs
    }
}

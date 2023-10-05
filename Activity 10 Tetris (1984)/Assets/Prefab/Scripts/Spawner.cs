using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tetrominoes;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTetrominos();
    }
    public void SpawnTetrominos()
    {
        int randNum = Random.Range(0, tetrominoes.Length);
        GameObject randomTetromino = tetrominoes[randNum];
        Instantiate(randomTetromino, transform.position, Quaternion.identity);
    }
}

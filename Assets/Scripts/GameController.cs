using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameClearText;
    public GameObject gameOverText;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
        if (blocks.Length == 0)
        {
            gameClearText.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
        }

        if (ball.GetComponent<Ball>().isDead == true)
        {
            gameOverText.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}

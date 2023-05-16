using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    private GameManager gameManager;
    private string Ground_Tag = "Ground";

    private void Start()
    {
        gameManager = GameObject.Find("Player").GetComponent<GameManager>();
    }

    // checking for non-solid collisions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Ground_Tag))
        {
            Destroy(gameObject);
            gameManager.IncrementScore();
        }    
    }

}

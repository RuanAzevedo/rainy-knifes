using UnityEngine;

public class Knife : MonoBehaviour
{
    private const string GROUND_TAG = "Ground";

    private GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // checking for non-solid collisions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(GROUND_TAG))
        {
            Destroy(gameObject);
            gameManager.IncrementScore();
            gameManager.CheckScore();
        }    
    }

}

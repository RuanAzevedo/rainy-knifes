using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject knife;

    [SerializeField]
    private float min_X = 2.5f, max_X = 2.5f;

    private AudioSource playerAudio;
    public float spawnCooldown = 1f;

    public AudioClip fallingSfx;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();        
    }

    public IEnumerator SpawnKnife()
    {
        yield return new WaitForSeconds(spawnCooldown);

        float posX = Random.Range(min_X, max_X);
        float posY = transform.position.y;

        GameObject newKnife = Instantiate(knife);
        newKnife.transform.position = new Vector2(posX, posY);

        playerAudio.PlayOneShot(fallingSfx, 1.0f);

        StartCoroutine(SpawnKnife());
    }

}

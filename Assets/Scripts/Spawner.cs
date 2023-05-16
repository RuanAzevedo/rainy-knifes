using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject knife;

    [SerializeField]
    private float min_X = 2.5f, max_X = 2.5f;

    private AudioSource playerAudio;
    public AudioClip fallingSfx;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        
        StartCoroutine(SpawnKnife());
        
    }

    IEnumerator SpawnKnife()
    {
        yield return new WaitForSeconds(1f);

        GameObject k = Instantiate(knife);

        float x = Random.Range(min_X, max_X);

        k.transform.position = new Vector2(x, transform.position.y);
        playerAudio.PlayOneShot(fallingSfx, 1.0f);

        StartCoroutine(SpawnKnife());
    }

}

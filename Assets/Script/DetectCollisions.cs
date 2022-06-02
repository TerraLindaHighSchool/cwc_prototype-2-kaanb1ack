using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    public AudioClip destroySound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        playerAudio.PlayOneShot(destroySound, 1.0f);
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
}

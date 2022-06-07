using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 17f;
    public float xRange = 20f;

    

    public GameObject projectilePrefab;

    public AudioSource shootSound;


    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            PlayShootSound();
        }
        
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    void Start()
    {
        
        
    }

    public void PlayShootSound()
    {
        shootSound.Play();
    }
}

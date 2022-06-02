using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    public TextMeshProUGUI gameOverText;

    public bool isGameActive;


    void Start()
    {
        isGameActive = true;
        gameOverText = GameObject.Find("GameOverText").GetComponent<TextMeshProUGUI>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            gameOverText.gameObject.SetActive(true);

            Destroy(gameObject);
            isGameActive = false;
        }
    }
}

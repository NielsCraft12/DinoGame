using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private GameObject CanvasDisplay;


    private void Start()
    {
        CanvasDisplay.SetActive(true);
        CanvasDisplay = GameObject.Find("GameOverCanvas");
        CanvasDisplay.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.tag == "Player")
           {
/*           SceneManager.LoadScene("DinoScene");*/
            CanvasDisplay.SetActive(true);
        }
        }
}

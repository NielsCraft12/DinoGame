using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
/*    [SerializeField] private GameObject CanvasDisplay;*/

    public void ClickBackButton()
    {
        //Turn on setting button.
        SceneManager.LoadScene("DinoScene");
/*        CanvasDisplay.SetActive(false);*/
    }
}

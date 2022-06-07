using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverTxt;
    public GameObject resetButton;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameOverTxt.SetActive(true);
            resetButton.SetActive(true);
        }

    }
}

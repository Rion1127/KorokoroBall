using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource; //音楽を再生するコンポーネント

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ゴール！");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public int levelToUnlock;
    private AudioSource finishSound;

    
    int numberOfUnlockedLevel;


    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            numberOfUnlockedLevel = PlayerPrefs.GetInt("levelsUnlocked");

            if(numberOfUnlockedLevel <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevel + 1);
            }

            SceneController.instance.NextLevel();
        }
    }

    
}

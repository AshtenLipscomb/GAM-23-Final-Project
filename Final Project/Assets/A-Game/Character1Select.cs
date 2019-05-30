using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character1Select : MonoBehaviour
{
    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void P1SelectCharacter1()
    {
        PlayerPrefs.SetInt("player1.character", 0);
    }

    public void P1SelectCharacter2()
    {
        PlayerPrefs.SetInt("player1.character", 1);
    }

    public void P1SelectCharacter3()
    {
        PlayerPrefs.SetInt("player1.character", 2);
    }

    public void P1SelectCharacter4()
    {
        PlayerPrefs.SetInt("player1.character", 3);
    }

    public void P1SelectCharacter5()
    {
        PlayerPrefs.SetInt("player1.character", 4);
    }

    public void P1SelectCharacter6()
    {
        PlayerPrefs.SetInt("player1.character", 5);
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

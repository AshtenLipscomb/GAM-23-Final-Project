using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character2Select : MonoBehaviour
{
    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void P2SelectCharacter1()
    {
        PlayerPrefs.SetInt("player2.character", 0);
    }

    public void P2SelectCharacter2()
    {
        PlayerPrefs.SetInt("player2.character", 1);
    }

    public void P2SelectCharacter3()
    {
        PlayerPrefs.SetInt("player2.character", 2);
    }

    public void P2SelectCharacter4()
    {
        PlayerPrefs.SetInt("player2.character", 3);
    }

    public void P2SelectCharacter5()
    {
        PlayerPrefs.SetInt("player2.character", 4);
    }

    public void P2SelectCharacter6()
    {
        PlayerPrefs.SetInt("player2.character", 5);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

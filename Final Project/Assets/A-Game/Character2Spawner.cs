using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2Spawner : MonoBehaviour
{


    

    public GameObject[] characterPrefabs;

    // Use this for initialization
    void Start()
    {
        int selectedCharacterIndex = PlayerPrefs.GetInt("player2.character", 0);

        Instantiate(characterPrefabs[selectedCharacterIndex], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1Spawner : MonoBehaviour
{
    public GameObject[] characterPrefabs;

	void Start ()
    {
        int selectedCharacterIndex = PlayerPrefs.GetInt("player1.character", 0);

        Instantiate(characterPrefabs[selectedCharacterIndex], transform.position, transform.rotation);
	}
}